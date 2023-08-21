using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CheckCasher.util
{
class MICRParser
{
    public MICRParser()
    {
    }

    public MICR parseMicrString(String micr)        
    {
        MICR parsedMICR = new MICR();
        parsedMICR.setRawMICR(micr);
        int onUsIdx = micr.IndexOf(getOnUsSymbol());
        if(onUsIdx >= 0 && onUsIdx <= 10)
        {
            int rtnIdx = micr.IndexOf(getTransitSymbol(), onUsIdx);
            parseAuxOnUs(parsedMICR, micr.Substring(0, rtnIdx));
            parseRTN(parsedMICR, micr.Substring(rtnIdx, rtnIdx + 11));
        } else
        {
            int rtnIdx = micr.IndexOf(getTransitSymbol());
            parseRTN(parsedMICR, micr.Substring(rtnIdx, rtnIdx + 11));
        }
        int lastRtnIdx = micr.LastIndexOf(getTransitSymbol());
        int amtIdx = micr.IndexOf(getAmountSymbol());
        if(lastRtnIdx >= 0 && amtIdx >= 0)
            parseOnUs(parsedMICR, micr.Substring(lastRtnIdx + 1, amtIdx));
        else
        if(lastRtnIdx >= 0 && amtIdx < 0)
            parseOnUs(parsedMICR, micr.Substring(lastRtnIdx + 1));
        if(amtIdx >= 0)
            parseAmount(parsedMICR, micr.Substring(amtIdx));
       
            return parsedMICR;
        
    }

    public void setTransitSymbol(String transitSymbol)
    {
        this.transitSymbol = transitSymbol;
    }

    public String getTransitSymbol()
    {
        return transitSymbol;
    }

    public void setOnUsSymbol(String onUsSymbol)
    {
        this.onUsSymbol = onUsSymbol;
    }

    public String getOnUsSymbol()
    {
        return onUsSymbol;
    }

    public void setAmountSymbol(String amountSymbol)
    {
        this.amountSymbol = amountSymbol;
    }

    public String getAmountSymbol()
    {
        return amountSymbol;
    }

    public void setDashSymbol(String dashSymbol)
    {
        this.dashSymbol = dashSymbol;
    }

    public String getDashSymbol()
    {
        return dashSymbol;
    }

    private void parseAmount(MICR parsed, String fragment)        
    {
        int firstAmtIdx = fragment.IndexOf(getAmountSymbol());
        int lastAmtIdx = fragment.LastIndexOf(getAmountSymbol());
        if(firstAmtIdx != -1 && lastAmtIdx == -1 || firstAmtIdx == lastAmtIdx)
        {
            //throw new MICRParseException("No closing amount symbol:  " + fragment);
        } else
        {
            String amt = fragment.Substring(firstAmtIdx + 1, lastAmtIdx);
            parsed.setAmount(amt);
            return;
        }
    }

    private void parseOnUs(MICR parsed, String fragment)
        
    {
        if(parsed.getAuxOnUs() == null)
        {
            int lastOnUsIdx = fragment.LastIndexOf(getOnUsSymbol());
            //parsed.setOnUs(fragment); 
            String potentialSerial = fragment.Substring(lastOnUsIdx + 1);
            
            
            if (potentialSerial != null && potentialSerial.Length > 1)
            {
                parsed.setSerialNumber(potentialSerial);
                fragment = fragment.Substring(0, lastOnUsIdx);
            }            
            fragment = Regex.Replace(fragment, "[^.0-9]", "");
            parsed.setOnUs(fragment);

        } else
        {
            parsed.setOnUs(fragment != null ? Regex.Replace(fragment, "[^.0-9]", "") : null);
            parsed.setSerialNumber(parsed.getAuxOnUs());
        }
    }

    private void parseAuxOnUs(MICR parsed, String fragment)        
    {
        int idxOpen = fragment.IndexOf(getOnUsSymbol());
        int idxClose = fragment.IndexOf(getOnUsSymbol(), idxOpen + 1);
        if(idxOpen < 0 || idxClose < 0)
        {
            //throw new MICRParseException("Could not find opening or closing on-us symbols in aux-on-us:  " + fragment);
        } else
        {
            String aux = fragment.Substring(idxOpen + 1, idxClose);
            parsed.setAuxOnUs(aux != null ? Regex.Replace(aux, "[^.0-9]", "") : null);
            //parsed.setAuxOnUs(aux);
            return;
        }
    }

    private void parseRTN(MICR parsed, String fragment)        
    {
        int idxOpen = fragment.IndexOf(getTransitSymbol());
        int idxClose = fragment.IndexOf(getTransitSymbol(), idxOpen + 1);
        if(idxOpen < 0 || idxClose < 0)
        {
           // throw new MICRParseException("Could not find opening or closing transit symbols:  " + fragment);
        } else
        {
            String rtn = fragment.Substring(idxOpen + 1, idxClose);
            //parsed.setRtn(rtn);
            parsed.setRtn(rtn != null ? Regex.Replace(rtn, "[^.0-9]", "") : null);
            return;
        }
    }

    private String transitSymbol = "d";
    private String onUsSymbol = "c";
    private String amountSymbol = "b";
    private String dashSymbol = "-";
   
}

}

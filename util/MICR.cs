using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckCasher.util
{
	
 class MICR
{

    public MICR()
    {
    }

    public String getAmount()
    {
        return amount;
    }

    public void setAmount(String amount)
    {
        this.amount = amount;
    }

    public String getAuxOnUs()
    {
        return auxOnUs;
    }

    public void setAuxOnUs(String auxOnUs)
    {
        this.auxOnUs = auxOnUs;
    }

    public String getOnUs()
    {
        return onUs;
    }

    public void setOnUs(String onUs)
    {
        this.onUs = onUs;
    }

    public String getRawMICR()
    {
        return rawMICR;
    }

    public void setRawMICR(String rawMICR)
    {
        this.rawMICR = rawMICR;
    }

    public String getRtn()
    {
        return rtn;
    }

    public void setRtn(String rtn)
    {
        this.rtn = rtn;
    }

    public String getSerialNumber()
    {
        return serialNumber;
    }

    public void setSerialNumber(String serialNumber)
    {
        this.serialNumber = serialNumber;
    }

    private String rawMICR;
    private String auxOnUs;
    private String onUs;
    private String amount;
    private String rtn;
    private String serialNumber;
}

}

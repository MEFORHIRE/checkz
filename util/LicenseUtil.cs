using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections;
using System.IO;
using Microsoft.Win32;
using System.Windows;

namespace CheckCasher.util
{
	class LicenseUtil
	{
        public static string licenseCheck(string path)
        {
            if (File.Exists(path))
            {
                return path;
            }
            else
            {                
                RegistryKey _key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\EWebComputing\\CheckCasher");
                if (_key == null)
                {
                    createTrialLicense(path);
                    RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\EWebComputing\\CheckCasher");                            
                }
                else
                {
                    return null;
                }
                return path;
            }
        }

        private static void createTrialLicense(string path)
        {
            XmlDocument doc = ProduceSingleLicense(Environment.MachineName);
            doc.Save(path);
        }

        private static XmlDocument ProduceSingleLicense(string computerId)
        {
            LicenserAPI.Logic.LicenseInfo licStruct = new LicenserAPI.Logic.LicenseInfo();
            XmlDocument doc = new XmlDocument();
            LicenserAPI.Logic licenseLogic = new LicenserAPI.Logic();

            
            XmlElement elem = doc.CreateElement("CheckCasher");
            doc.AppendChild(elem);

            XmlElement child = doc.CreateElement("LicenseType");
            child.InnerText = "0";
            elem.AppendChild(child);

            child = doc.CreateElement("ComputerId");
            child.InnerText = computerId;
            elem.AppendChild(child);

            child = doc.CreateElement("Features");
            elem.AppendChild(child);
            elem = child;

            licStruct.computerID = computerId;
            licStruct.kind = (LicenserAPI.Logic.LicenseType)LicenserAPI.Logic.LicenseType.Demo; ;
            licStruct.passCode = "inv365";
            ArrayList ar = new ArrayList();

           
                LicenserAPI.Logic.FeatureInfo featureInfo = new LicenserAPI.Logic.FeatureInfo();
               

                featureInfo.featureName = "CheckCasher";
                
                featureInfo.timeDepend = true;
               
                
                featureInfo.expiration = System.DateTime.Today.AddDays(30);
                
                ar.Add(featureInfo);

                child = doc.CreateElement("Feature");
                elem.AppendChild(child);
                XmlAttribute attr = doc.CreateAttribute("Name");
                attr.Value = featureInfo.featureName;
                child.Attributes.Append(attr);

                attr = doc.CreateAttribute("IsTimeDepended");
                attr.Value = XmlConvert.ToString(featureInfo.timeDepend);
                child.Attributes.Append(attr);

                if (featureInfo.timeDepend)
                {
                    attr = doc.CreateAttribute("Expiration");
                    attr.Value = XmlConvert.ToString(featureInfo.expiration,XmlDateTimeSerializationMode.Local);
                    child.Attributes.Append(attr);
                }
            
            licStruct.features = 
                (LicenserAPI.Logic.FeatureInfo[])ar.ToArray(typeof(LicenserAPI.Logic.FeatureInfo));

            elem = doc.CreateElement("Signature");
            doc.DocumentElement.AppendChild(elem);
            LicenserAPI.Logic logic = new LicenserAPI.Logic();
            elem.InnerText = logic.CreateSignature(licStruct);
            return doc;
        }
	}
}

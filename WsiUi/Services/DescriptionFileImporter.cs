using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using WsiUi.Models;

namespace WsiUi.Services
{
    public class DescriptionFileImporter
    {

        public WsiConfig Config { get; set; }

        public string TestLogPath { get; set; }

        public string WsdlPath { get; set; }

        public void DoImport()
        {

            var temp = Path.Combine(Environment.CurrentDirectory, "tempLog.xml");

            string utilityPath = Path.Combine(
                this.Config.WsiPath,
                 @"BPTestToolsProcess-1.2-2.0-Final\BP-Monitor-Final\WSILogger\DescriptionFileImporter\import.bat");
       
            Utils.RunProcess(
                utilityPath,
                String.Format(@"""{0}"" ""{1}"" ""{2}""", TestLogPath, temp, WsdlPath),
                Path.GetDirectoryName(utilityPath));

            File.Copy(temp, TestLogPath, true);
        }

    }
}

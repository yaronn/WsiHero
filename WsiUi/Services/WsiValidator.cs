using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using WsiUi.Models;
using WsiUi.Services;

namespace WsiUi
{
    public class WsiValidator : WsiValidatorBase
    {

        public string UtilityRelativePath { get; set; }

        public string ProfileRulesPath { get; set; }


        public WsiValidator(WsiConfig config) : base(config)
        {
        }

        string UtilityFullPath
        {
            get
            {
                return Path.Combine(
                    this.Config.WsiPath,
                    UtilityRelativePath);
            }
        }

        public override string ResultReportPath
        {
            get { return Path.Combine(Path.GetDirectoryName(UtilityFullPath), "report.xml"); }
        }

        public override void DoWsiValidation()
        {
            DoPrepare();
            DoAnalyze();           
        }

        private void DoPrepare()
        {
            CallJava(
                "make-plugins.xsl", 
                Path.Combine(this.Config.WsiPath, ProfileRulesPath), 
                "taplugins.xsl");           
        }

        private void DoAnalyze()
        {
            CallJava(
                "tadriver.xsl", 
                TestLogPath, 
                this.ResultReportPath);
        }

        private void CallJava(string param1, string param2, string param3)
        {
            string classpath = String.Format(
                @"""{0}\saxon9.jar"";""{0}\saxon9-s9api.jar"";""{0}\saxon9-dom4j.jar"";""{0}\saxon9-dom.jar"";""{0}\saxon9-jdom.jar"";""{0}\saxon9-sql.jar"";""{0}\saxon9-xom.jar"";""{0}\saxon9-xpath.jar"";""{0}\saxon9-xqj.jar"";.", 
                this.Config.Saxon91Path);

            Utils.RunProcess(
                "java",
                String.Format(@"-classpath {0} -jar ""{1}\saxon9.jar"" -s ""{2}"" -o ""{3}"" {4}", 
                classpath, 
                this.Config.Saxon91Path, 
                param2, 
                param3,
                param1),
                this.UtilityFullPath);
        }

    }
}

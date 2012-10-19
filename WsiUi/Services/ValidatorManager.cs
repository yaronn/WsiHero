using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WsiUi.Models;

namespace WsiUi.Services
{
    public class ValidatorManager
    {
        private const string BasicProfile12 = "Basic Profile 1.2";
        private const string BasicProfile20 = "Basic Profile 2.0";
        private const string ReliableSecureProfile10 = "Reliable Secure Profile 1.0";


        public List<string> Files { get; set; }

        public WsiConfig Config { get; set; }

        public WsiValidatorBase Validator { get; private set; }

        public string ReportPath
        {
            get { return Validator.ResultReportPath; }
        }
        
        public string[] Validators
        {
            get { return new[] { BasicProfile12, BasicProfile20, ReliableSecureProfile10 }; }
        }

        private string validatorName;
        public string ValidatorName
        {
            get { return this.validatorName; }
            set
            {
                switch (value)
                {
                    case BasicProfile12:
                        {
                            Validator = new WsiValidator(this.Config)
                                            {
                                                ProfileRulesPath = @"BPTestToolsProcess-1.2-2.0-Final\BPAnalyzer-1.2-Final\BasicProfile-1.2.xml",
                                                UtilityRelativePath =
                                                    @"BPTestToolsProcess-1.2-2.0-Final\BPAnalyzer-1.2-Final\"
                                            };

                            break;
                        }
                    case BasicProfile20:
                        {
                            Validator = new WsiValidator(this.Config)
                                            {
                                                ProfileRulesPath = @"BPTestToolsProcess-1.2-2.0-Final\BPAnalyzer-2.0-Final\BasicProfile-2.0.xml",
                                                UtilityRelativePath =
                                                    @"BPTestToolsProcess-1.2-2.0-Final\BPAnalyzer-2.0-Final\"
                                            };

                            break;
                        }
                    case ReliableSecureProfile10:
                        {
                            Validator = new WsiValidator(this.Config)
                                            {
                                                ProfileRulesPath = @"RSP1.0-Delivery-Package\Analyzer-RSPrev57-Sep13-2010\ReliableSecureProfile-1.0.xml",
                                                UtilityRelativePath =
                                                    @"RSP1.0-Delivery-Package\Analyzer-RSPrev57-Sep13-2010\"
                                            };

                            break;
                        }

                }
                
                

                this.validatorName = value;
            }
        }

        public ValidatorManager(WsiConfig config)
        {
            this.Config = config;
        }

        public void Run()
        {            
            var logPath = Path.Combine(Environment.CurrentDirectory, "log.xml");

            CreateLog(logPath);
            DoRunWsi(logPath);
        }

        private void DoRunWsi(string logPath)
        {

            if (this.Files.Count == 0)
                throw new Exception("At least one document must be added to validation list.");

            Validator.Config = this.Config;            
            Validator.TestLogPath = logPath;

            Validator.DoWsiValidation();
        }

        private void CreateLog(string logPath)
        {
            var b = new WsiLogBuilder()
            {
                Files = this.Files,
                LogPath = logPath,
                WsiConfig = this.Config
            };

            b.BuildLog();
        }
    }
}

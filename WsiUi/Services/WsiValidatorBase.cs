using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WsiUi.Models;

namespace WsiUi
{
    public abstract class WsiValidatorBase
    {       
        public WsiConfig Config { get; set; }

        public string TestLogPath { get; set; }

        public abstract string ResultReportPath { get; }

        public abstract void DoWsiValidation();

        protected WsiValidatorBase(WsiConfig config)
        {
            this.Config = config;
        }

    }
}

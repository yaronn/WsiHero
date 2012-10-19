using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using WsiUi.Models;
using WsiUi.Services;

namespace WsiUi
{
    public class WsiPresenter : INotifyPropertyChanged
    {
        private string files = String.Empty;
        public string Files
        {
            get { return this.files; }
            set
            {
                this.files = value;
                if (PropertyChanged!=null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Files"));
            }
        }

        private string[] FilesList
        {
            get
            {
                return Files.Split(
                    new[] { Environment.NewLine }
                    , StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public WsiConfig Config { get; set; }
     
        public delegate void ShowReportDelegate(object source, string url);

        public event ShowReportDelegate ShowReport;

        private ValidatorManager manager;

        public string[] Validators
        {
            get { return manager.Validators; }
        }

        public WsiPresenter()
        {

            this.Config = new WsiConfig()
            {
                WsiPath = Path.Combine(Environment.CurrentDirectory, "Wsi"),
                Saxon91Path = Path.Combine(Environment.CurrentDirectory, "Saxon91")
            };

            this.manager = new ValidatorManager(this.Config);
        }

        public void DoValidation(string Name)
        {
            manager.ValidatorName = Name;
            manager.Config = this.Config;
            manager.Files = new List<string>(this.FilesList);
            manager.Run();

            OnShowReport(manager.ReportPath);
        }    

        public void OnShowReport(string url)
        {
            if (ShowReport != null)
                ShowReport(this, url);
        }
     
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WsiUi.Services;

namespace WsiUi
{
    public partial class WsiUi : Form
    {
        private class MenuCommand
        {
            public WsiPresenter presenter;
            public string Name;

            public void SplitHandler(object sender, EventArgs e)
            {

                if (presenter.Files.Length==0)
                {
                    MessageBox.Show("Please specify at least one document to validate.");
                    return;
                }

                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    this.presenter.DoValidation(Name);
                }
                catch (Exception err)
                {
                    MessageBox.Show(String.Format("{0}", err.Message));
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }

            } 
        }

        private WsiPresenter presenter;

        public WsiUi()
        {
            InitializeComponent();

            this.presenter = new WsiPresenter();                                 

            presenter.ShowReport += presenter_ShowReport;             
        }

        void presenter_ShowReport(object source, string url)
        {
            Process.Start("iexplore.exe", url);
        }

        private void WsiUi_Load(object sender, EventArgs e)
        {
            try
            {
                new Installer().VerifyInstallation();
            }
            catch
            {
                MessageBox.Show( 
                      @"The WSI zip files are not present in the WsiHero folder.
See readme.txt or http://webservices20.blogspot.com/ for more details.
Also, make sure you run WsiHero.exe from its folder and not from a different working directory.");
            }

            txtFiles.DataBindings.Add("Text", this.presenter, "Files");
            txtFiles.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            foreach (string s in this.presenter.Validators)
            {
                var cmd = new MenuCommand()
                              {
                                 Name = s,
                                 presenter = this.presenter                 
                              };

                splitButton1.AddDropDownItemAndHandle(s, cmd.SplitHandler);    
            }
        }              
    

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://webservices20.blogspot.com/");
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:yaronn01@gmail.com");
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFile.Text))
            {
                txtFiles.Text += txtFile.Text + Environment.NewLine;
                txtFile.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("The document path cannot be empty.");
            }
        }

        private void splitButton1_ButtonClick(object sender, EventArgs e)
        {
            var cmd = new MenuCommand()
            {
                Name = this.presenter.Validators[0],
                presenter = this.presenter
            };
            cmd.SplitHandler(this, e);
        }
       
    }
}

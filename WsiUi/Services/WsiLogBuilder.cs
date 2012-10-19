using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using WsiUi.Models;

namespace WsiUi.Services
{
    public class WsiLogBuilder
    {
        public List<string> Files { get; set; }

        public string LogPath { get; set; }

        public WsiConfig WsiConfig { get; set; }

        public void BuildLog()
        {
            testLog t = GetTestLogWithSoap();
            SerializeTestLog(t);
            AddWsdlsToTestLog();
        }

        private testLog GetTestLogWithSoap()
        {
            var t = new testLog();
            var msgList = new List<message>();

            foreach (var file in this.Files.Where(IsSoap))
            {
                message m = new message();
                m.httpHeaders = new object[]
                                    {
                                        "POST /dummyUrl HTTP/1.1",
                                        new contentTypeHeader
                                            {
                                                parameter = new parameter[]
                                                                {
                                                                  new parameter()
                                                                      {
                                                                           key="charset",
                                                                           value="utf-8"
                                                                      }
                                                                }
                                            }
                                    };

                var x = new XmlDocument();
                x.LoadXml(File.ReadAllText(file));
                
                m.messageContents = new messageContents()
                                        {
                                            Any = x.DocumentElement,                                                                                        
                                        };
                msgList.Add(m);
            }

            t.messageLog = msgList.ToArray();
            
            return t;
        }

        private void AddWsdlsToTestLog()
        {

            foreach (var url in this.Files.Where(IsWsdl))
            {
                var importer = new DescriptionFileImporter()
                {
                    TestLogPath = this.LogPath,
                    WsdlPath = url,
                    Config = this.WsiConfig
                };

                importer.DoImport();
            }
        }

        private void SerializeTestLog(testLog t)
        {
            var fs = new FileStream(this.LogPath, FileMode.Create);
            var x = new XmlSerializer(typeof (testLog));
            x.Serialize(fs, t);
            fs.Close();
        }       

        private bool IsSoap(string file)
        {
            return file.EndsWith(".xml");
        }

        private bool IsWsdl(string file)
        {
            return !IsSoap(file);
        }
    }
}

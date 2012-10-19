using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;

namespace WsiUi.Services
{
    public static class Utils
    {
        public static void RunProcess(string path, string arguments, string workingDir)
        {
            RunProcess(path, arguments, workingDir, false);
        }

        public static void RunProcess(string path, string arguments, string workingDir, bool isVisible)
        {
            if (!Directory.Exists(workingDir))
                throw new Exception(
                    String.Format(
                    @"The directory '{0}' does not exist.
                      This is probably because the WSI utility is not correctly installed.
                      See readme.txt or http://webservices20.blogspot.com/ in order to fix this.
                    ", workingDir));

            var p = new Process();
            p.StartInfo = new ProcessStartInfo()
                              {
                                  CreateNoWindow = !isVisible,
                                  UseShellExecute = false,
                                  WorkingDirectory = workingDir,
                                  FileName = path,
                                  Arguments = arguments
            };

            p.Start();
            p.WaitForExit();

            if (p.ExitCode!=0)
                throw new Exception(String.Format(
                @"Execution of '{0}' failed. 
                
                Some common reasons may be:
                        
                    1. The WSI utility is not correctly installed.
                    1. Java (V5 or higher) is not installed on the machine. 
                    2. One or more of the documents to validate does not exist or is not accessible.

                See readme.txt or http://webservices20.blogspot.com/ in order to fix this.", path));
        }

        public static void UnZipFiles(string zipPathAndFile, string outputFolder, string password, bool deleteZipFile)
        {
            ZipInputStream s = new ZipInputStream(File.OpenRead(zipPathAndFile));
            if (password != null && password != String.Empty)
                s.Password = password;
            ZipEntry theEntry;
            string tmpEntry = String.Empty;
            while ((theEntry = s.GetNextEntry()) != null)
            {
                string directoryName = outputFolder;
                string fileName = Path.GetFileName(theEntry.Name);
                // create directory 
                if (directoryName != "")
                {
                    Directory.CreateDirectory(directoryName);
                }
                if (fileName != String.Empty)
                {
                    if (theEntry.Name.IndexOf(".ini") < 0)
                    {
                        string fullPath = directoryName + "\\" + theEntry.Name;
                        fullPath = fullPath.Replace("\\ ", "\\");
                        string fullDirPath = Path.GetDirectoryName(fullPath);
                        if (!Directory.Exists(fullDirPath)) Directory.CreateDirectory(fullDirPath);
                        FileStream streamWriter = File.Create(fullPath);
                        int size = 2048;
                        byte[] data = new byte[2048];
                        while (true)
                        {
                            size = s.Read(data, 0, data.Length);
                            if (size > 0)
                            {
                                streamWriter.Write(data, 0, size);
                            }
                            else
                            {
                                break;
                            }
                        }
                        streamWriter.Close();
                    }
                }
            }
            s.Close();
            if (deleteZipFile)
                File.Delete(zipPathAndFile);
        }

    }
}

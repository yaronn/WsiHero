using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WsiUi.Services
{
    public class Installer
    {
        public void VerifyInstallation()
        {
            string wsiDir = Path.Combine(Environment.CurrentDirectory, "WSI");
            if (Directory.Exists(wsiDir))
                return;

            string bpzipPath = Path.Combine(Environment.CurrentDirectory, "BPTestToolsProcess-1.2-2.0-Final.zip");
            string rspzipPath = Path.Combine(Environment.CurrentDirectory, "RSP1.0-Delivery-Package.zip");

            if (!File.Exists(bpzipPath) || !File.Exists(rspzipPath))
                throw new Exception(
                    @"The WSI zip files are not present.
See readme.txt or http://webservices20.blogspot.com/ for more details.");

            string bpPath = Path.Combine(Environment.CurrentDirectory, @"WSI\BPTestToolsProcess-1.2-2.0-Final");
            string rspPath = Path.Combine(Environment.CurrentDirectory, @"WSI");

            Utils.UnZipFiles(bpzipPath, bpPath, String.Empty, false);
            Utils.UnZipFiles(rspzipPath, rspPath, String.Empty, false);

            var bpFiles = Directory.GetFiles(bpPath, "*.zip");
            foreach (string f in bpFiles)
            {
                string output = Path.Combine(bpPath, Path.GetFileNameWithoutExtension(f));
                Utils.UnZipFiles(f, output, String.Empty, false);
            }

        }
    }
}

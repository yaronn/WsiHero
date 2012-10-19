using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WsiUi;
using WsiUi.Models;
using WsiUi.Services;

namespace WsiUiTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ValidationManagerTests
    {
       

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [DeploymentItem("soap.xml")]
        public void TestValidation()
        {
            var config = new WsiConfig()
                             {
                                 WsiPath = @"C:\Program Files\WSI\",
                                 Saxon91Path = @"C:\Java\Saxon91\"
                             };
            var manager = new ValidatorManager(config)
            {
                Files = new List<string>()
                            {
                                "http://localhost/MyWebServices/Services/SimpleService.asmx?WSDL", 
                                "soap.xml"
                            },                
            };

            manager.ValidatorName = manager.Validators[0];

            if (File.Exists(manager.ReportPath))
                File.Delete(manager.ReportPath);
                
            manager.Run();

            Assert.IsTrue(File.ReadAllText(manager.ReportPath).Length>100, "report not created");
        }
    }
}

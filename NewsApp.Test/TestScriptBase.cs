using EikonViewsAppUtility.TestStatusReporter;
using log4net;
using NUnit.Core;
using System;
using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium;
using EikonViewsAppUtility.Eikon;

namespace NewsApp.Test
{

    [TestFixture]
    public class TestScriptBase
    {
        public static TestResultReporter addin;
        protected static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TestScriptBase()
        {
            /* Install TestStatusReporter addin */
            if (addin == null)
            {
                Debug.WriteLine("Init addin");
                Logger.Info("Init addin");
                addin = new EikonViewsAppUtility.TestStatusReporter.TestResultReporter();
                bool a = addin.Install(CoreExtensions.Host);
            }
        }

        [TestFixtureTearDown]
        public void FixtureTeardownBase()
        {
            try
            {
                ThomsonReuters.Test.WhiteArk.Shared.Eikon.Framework.WhiteArkTestFramework.Instance.CleanUp();
            }
            catch (Exception)
            {

            }
        }

        protected void KillHomeWebDriver(IWebDriver driver)
        {
            string currentWinHandle = driver.CurrentWindowHandle;
            try
            {
                string homeWinHandl = "";
                foreach (string winhandle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(winhandle);
                    if (driver.Url.ToLower().Contains("/apps/home"))
                    {
                        homeWinHandl = winhandle;
                        Logger.Info("Found an orphan Homepage in background process");
                        driver.Close();
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                if((!currentWinHandle.Equals(homeWinHandl)) && (!currentWinHandle.Equals(driver.CurrentWindowHandle)))
                {
                    driver.SwitchTo().Window(currentWinHandle);
                }
                
            }
            catch (Exception ex)
            {
                Logger.Error("Error when close Homepage. Message: " + ex.Message);
                try
                {
                    driver.SwitchTo().Window(currentWinHandle);
                }
                catch(Exception) { }
                    
            }
            
        }

        protected void QuiteWebDriverForEikonNow(ref IEikonDriver eikonDriver)
        {
            if (!eikonDriver.IsEikonBrowser)
            {
                eikonDriver.Quite();
            }
        }

    }
}

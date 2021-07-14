using System;
using EikonViewsAppUtility.Eikon;
using NUnit.Framework;

namespace NewsApp.Test
{
    public abstract class SmokeBase : TestScriptBase
    {
        protected string param;
        protected IEikonDriver eikonDriver;

        [TestFixtureSetUp]
        public void BaseFixtureSetup()
        {

            EikonDriverOption option = new EikonDriverOption() { UseExistingEikon = true };
            try
            {
                eikonDriver = EikonDriverFactory.Create(option);
                eikonDriver.CloseAllOpenedWindows();
                System.Threading.Thread.Sleep(3000);
                KillHomeWebDriver(eikonDriver.WebDriver);
                eikonDriver.CreateWebDriver();
            }
            catch (Exception ex)
            {
                Logger.Error("Unable to create EikonDriver. " + ex.Message);
                Assert.Inconclusive("Unable to create EikonDriver. " + ex.Message);
                return;
            }
        }


        [TestFixtureTearDown]
        public void TestTearDown()
        {
            ThomsonReuters.Test.WhiteArk.Shared.Eikon.Framework.WhiteArkTestFramework.Instance.CleanUp();
            QuiteWebDriverForEikonNow(ref eikonDriver);
        }
    }
}

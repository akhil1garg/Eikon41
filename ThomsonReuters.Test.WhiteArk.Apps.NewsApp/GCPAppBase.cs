using log4net;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using EikonViewsAppUtility;
using ThomsonReuters.Test.WhiteArk.Core.PageObjects;

using EikonViewsAppUtility.Eikon;


namespace ThomsonReuters.Test.WhiteArk.Apps.NA
{
    public abstract class GCPAppBase : EikonWebApp
    {
        protected static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected IEikonDriver _eikonDriver;
        public string Url;

        public GCPAppBase(IWebDriver webDriver)
            : base(webDriver) 
        {
            SwitchToMainFrame();
        }

        public GCPAppBase(IWebDriver webDriver, string windowHandle)
            : base(webDriver, windowHandle)
        {
            SwitchToHomeAppFrame();
        }

        public GCPAppBase(string title, IWebDriver webDriver)
            : base(title, webDriver)
        {
            SwitchToHomeAppFrame();
        }

        
        public GCPAppBase(IEikonDriver eikonDriver)
            : base(eikonDriver.WebDriver)
        {
            _eikonDriver = eikonDriver;
            SwitchToHomeAppFrame();
        }
    
        public GCPAppBase(IEikonDriver eikonDriver, string path, string param="")
            : base(eikonDriver.WebDriver)
        {
            _eikonDriver = eikonDriver;

            Url = eikonDriver.RootUrl + path;

            if (param.Length > 0)
                Url = Url + "&" + param;

            eikonDriver.WebDriver.Navigate().GoToUrl(Url);
            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(50));
            SwitchToHomeAppFrame();
        }
  
        public GCPAppBase(string cmd, IEikonDriver eikonDriver)
   : base(eikonDriver.WebDriver, cmd)
        {
            _eikonDriver = eikonDriver;
           
         //   Url = Url + "&" + cmd;

            eikonDriver.WebDriver.Navigate().GoToUrl(cmd);
            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(50));
            SwitchToHomeAppFrame();
        }
       
        public override void WaitUntilReady()
        {
            //SetFocus();
            System.Threading.Thread.Sleep(1000);
        }

        /// <summary>
        /// Sometimes WhiteArk returns incorrect window, we have to switch to the correct one.
        /// </summary>
        public void SwitchToHomeAppFrame()
        {
            if (!WebDriver.Title.ToLower().Contains("home"))
            {
                foreach (string winhandle in WebDriver.WindowHandles)
                {
                    WebDriver.SwitchTo().Window(winhandle);
                    if (WebDriver.Title.ToLower().Contains("home"))
                    {
                        break;
                    }
                }
            }
            _eikonDriver.SwitchToAppFrame();

        }

        /// <summary>
        /// Provide object to access to Top Navigation Menu such as Asset Classes, Countries, News and Research, My Eikon, ...
        /// </summary>
        /// <param name="driver"></param>
       /* public TopNavigationBar TopNavigationBar
        {
            get
            {
                return new TopNavigationBar(WebDriver);
            }
        }
        */
        /// <summary>
        /// Get others news except main news in Homepage
        /// </summary>
       /* public IDictionary<string, NewsComponent> NewsComponents
        {
            get
            {
                IDictionary<string, NewsComponent> result = new Dictionary<string, NewsComponent>();
                List<IWebElement> newList = new List<IWebElement>();
                newList.Add(WebDriver.FindElementBy(By.Id("C32_2")));
                newList.Add(WebDriver.FindElementBy(By.Id("C32_3")));
                newList.Add(WebDriver.FindElementBy(By.Id("C32_4")));
                newList.Add(WebDriver.FindElementBy(By.Id("C32_5")));
                newList.Add(WebDriver.FindElementBy(By.Id("C32_6")));

                int number = 1;
                foreach (IWebElement e in newList)
                {
                    NewsComponent n = new NewsComponent(e);
                    result.Add(n.Header.Title.Text, n);
                    number++;
                }
                return result;
            }
        }
        */

        public string findAppVersion()
        {
            try
            {
                var parentDriver = WebDriver.SwitchTo().ParentFrame();
                var parentIframe = parentDriver.FindElementBy(By.CssSelector("iframe"));
                var src = parentIframe.GetAttribute("src");

                return src;
            }
            catch (Exception ex)
            {
                Logger.Info("findAppVersion error. " + ex.Message);
                return "";
            }
            finally
            {
                WebDriver.SwitchToAppFrame();
                System.Threading.Thread.Sleep(2000);
            }
        }

    }
}

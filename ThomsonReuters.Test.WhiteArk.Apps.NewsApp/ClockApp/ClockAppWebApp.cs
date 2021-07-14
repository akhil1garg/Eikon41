using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using EikonViewsAppUtility.Eikon;
using EikonViewsAppUtility;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace ThomsonReuters.Test.WhiteArk.Apps.NA
{
    public class ClockAppWebApp : GCPAppBase
    {
        String title; IWebDriver driver;
        //const string DIRECT_PATH = "/Apps/news-monitor#savedinstance=true";
        const string DIRECT_PATH = "/Apps/AppLibrary#/filtered?searchString=world%20clock";
        // const string REDIRECT_PATH = "/Explorer/EVzFXMMzSPOTxSTREAMING.aspx?s=EUR%3d&st=RIC";
        IWebElement locator;

        #region Constructor for WhiteArk framework
        public ClockAppWebApp(IWebDriver webDriver, string windowHandle)
            : base(webDriver, windowHandle)
        {

        }

        public ClockAppWebApp(IWebDriver webDriver)
            : base(webDriver)
        {

        }
        public ClockAppWebApp(string title, IWebDriver webDriver)
            : base(title, webDriver)
        {

        }

        #endregion

        public ClockAppWebApp(IEikonDriver eikonDriver, string windowTitle)
            : base(eikonDriver)
        {
            Url = eikonDriver.RootUrl + DIRECT_PATH;
        }

        public ClockAppWebApp(IEikonDriver eikonDriver)
            : base(eikonDriver, DIRECT_PATH)
        {
        }

        public void wait()
        {
            Thread.Sleep(7000);
        }
        public String CEMTitle()
        {

            title = WebDriver.Title;
            Console.Write("title of news Monitor " + title);
            return title;
        }


        public IWebElement Clockpopout
        {
            get { return WebDriver.FindElement(By.XPath("//*[@id='container']/div/coral-panel/app-filtered-apps/app-apps-list/div/virtual-scroller/div[2]/div/app-tile[1]/div/div/div[2]/div[2]/coral-button")); }
        }

        public Boolean errorInLoad()
        {

            IWebElement error = driver.FindElement(By.XPath("//*[text()='  An error has occurred.']"));
            if (error.Displayed)
            {
                Console.Write("an error has accurred we can't find the page you are looking for");
                return false;
            }
            else
            {
                Console.Write("page is loaded");
                return true;



            }
        }
        public void Switch_app_frame_window()
        {
            Console.Write("current window beforeclick " + WebDriver.CurrentWindowHandle);



        }
        public void Switch_app_frame_window_child()
        {

            Console.Write("current window afterclick " + WebDriver.WindowHandles.Count);

            foreach (String item in WebDriver.WindowHandles)
            {
                Console.Write(item);
                String text = WebDriver.SwitchTo().Window(item).Title;

                Console.Write(text);
                if (text.Contains("Eikon Messenger"))
                {
                    WebDriver.SwitchTo().Window(item).Close();
                }

                if (text.Contains("Stocks | Halts and Short Sell Restrictions"))
                {
                    String equeity = WebDriver.SwitchTo().Window(item).Title;
                    Console.Write(equeity);

                    break;
                }
            }
        }
        public void Switch_app_frame_window_child_Agg()
        {

            Console.Write("current window afterclick " + WebDriver.WindowHandles.Count);

            foreach (String item in WebDriver.WindowHandles)
            {
                Console.Write(item);
                String text = WebDriver.SwitchTo().Window(item).Title;

                Console.Write(text);

                if (text.Contains("Aggregates Report"))
                {
                    Console.Write(text);
                    String equeity = WebDriver.SwitchTo().Window(item).Title;
                    Console.Write(equeity);
                    WebDriver.SwitchTo().DefaultContent();
                    WebDriver.SwitchTo().Frame(WebDriver.FindElement(By.XPath("//iframe[@src='/Apps/Aggregates/1.15.7/']")));


                    break;
                }
            }
        }
        public void Switch_app_frame_window_child_Top_News()
        {

            Console.Write("current window afterclick " + WebDriver.WindowHandles.Count);

            foreach (String item in WebDriver.WindowHandles)
            {

                Console.Write(item);
                WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));
                String text = WebDriver.SwitchTo().Window(item).Title;

                Console.Write(text);

                if (text.Contains("Top News | Greater China"))
                {
                    Console.Write(text);
                    /*String equeity = WebDriver.SwitchTo().Window(item).Title;
                    Console.Write(equeity);*/
                    WebDriver.SwitchTo().DefaultContent();
                    WebDriver.SwitchTo().Frame(WebDriver.FindElement(By.XPath(" //iframe[@src='/Apps/TopNews/1.246.1/?group=SP_GROUP_001&page=SP_PAGE_001']")));


                    break;
                }
            }
        }
        public void Switch_app_frame_window_Parent()
        {
            Boolean status = false;
            Console.Write("current window afterclick " + WebDriver.WindowHandles.Count);

            foreach (String item in WebDriver.WindowHandles)
            {
                Console.Write(item);
                String text = WebDriver.SwitchTo().Window(item).Title;

                Console.Write(text);

                if (text.Contains("China Equity Market"))
                {
                    String equeity = WebDriver.SwitchTo().Window(item).Title;
                    Console.Write(equeity);
                    WebDriver.SwitchTo().DefaultContent();
                    WebDriver.SwitchTo().Frame(WebDriver.FindElement(By.XPath("//iframe[@src='/Apps/ChinaEquityMarket/1.0.8/']")));

                    // status = true;
                    break;
                }
            }
        }

        public void Generic_By_Then(IWebElement element, String data)
        {
            SelectElement s = new SelectElement(element);

            IList<IWebElement> options = s.Options;

            foreach (var ele in options)
            {
                String text = ele.GetText();
                Console.Write(options);

                if (text.Contains(data))
                {
                    s.SelectByText(text);
                    break;
                }
            }
        }

        public void JSClick(IWebElement ele)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", ele);
            System.Threading.Thread.Sleep(4000);
            WebDriver.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromSeconds(10));

        }
        public IWebElement Aggrigates
        {
            get { return WebDriver.FindElement(By.XPath("//span[text()='AGGREGATES']")); }

        }
    }
}

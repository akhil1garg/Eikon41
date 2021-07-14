using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using EikonViewsAppUtility.Eikon;
using EikonViewsAppUtility;
using OpenQA.Selenium.Support.UI;


using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace ThomsonReuters.Test.WhiteArk.Apps.NA
{
    public class QuoteAppWebApp : GCPAppBase
    {
        String title; IWebDriver driver;
        //const string DIRECT_PATH = "/Apps/news-monitor#savedinstance=true";
        const string DIRECT_PATH = "/Apps/QuoteWebApi?s=IBM.N&level2=false&NYSEOpenBook=false";
        // const string REDIRECT_PATH = "/Explorer/EVzFXMMzSPOTxSTREAMING.aspx?s=EUR%3d&st=RIC";
        IWebElement locator;

        #region Constructor for WhiteArk framework
        public QuoteAppWebApp(IWebDriver webDriver, string windowHandle)
            : base(webDriver, windowHandle)
        {

        }

        public QuoteAppWebApp(IWebDriver webDriver)
            : base(webDriver)
        {

        }

        public QuoteAppWebApp(string title, IWebDriver webDriver)
            : base(title, webDriver)
        {

        }

        #endregion

        public QuoteAppWebApp(IEikonDriver eikonDriver, string windowTitle)
            : base(eikonDriver)
        {
            Url = eikonDriver.RootUrl + DIRECT_PATH;
        }

        public QuoteAppWebApp(IEikonDriver eikonDriver)
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
       
      /*  public Boolean Equities()
        {
            IWebElement webElement = WebDriver.FindElement(By.XPath("//span[text()=' Most Recent ']"));
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));

            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()=' Most Recent ']")));

            if (webElement.Displayed)
            {
                JSclick(webElement);
                return true;

            }
            else
            {
                return false;
            }


        }*/

        public Boolean important()
        {
            IWebElement webElement = WebDriver.FindElement(By.XPath("//li[text()=' Only Important ']"));
            if (webElement.Displayed)
            {
                JSclick(webElement);
                return true;

            }
            else
            {
                return false;
            }


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

      /*  public List<string> Checktable()
        {
            List<string> tableelements= new List<string>();
            IList<IWebElement> items=WebDriver.FindElements(By.XPath("//ul[@class='dropdown-options']/li"));

               foreach(IWebElement ele in items)
               {
               
                String text = ele.GetText().Trim();
                Console.Write(text);
                tableelements.Add(text);
               }


              
            return tableelements;
        }
        public List<string> Halts_sort_sell_table()
        {
            List<string> tableelements = new List<string>();
            IList<IWebElement> items = WebDriver.FindElements(By.XPath("(//table[@class='basic-table ng-scope']//tr)[1]/th"));

            foreach (IWebElement ele in items)
            {

                String text = ele.GetText();
                Console.Write(text);
                tableelements.Add(text);
            }
            Console.Write(tableelements.Count + " " + items.Count);

            
            return tableelements;
        }
        public List<string> Aggregate_Report_val()
        {
            List<string> tableelements = new List<string>();
            IList<IWebElement> items = WebDriver.FindElements(By.XPath(" //div[@class='grid-cell solar-medium grid-cell-text']/span[@class='grid-cell-value']"));

            foreach (IWebElement ele in items)
            {

                String text = ele.GetText();
                Console.Write(text);
                tableelements.Add(text);
            }
            Console.Write(tableelements.Count + " " + items.Count);


            return tableelements;
        }*/
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
                if(text.Contains("Eikon Messenger"))
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

      /*  public IWebElement Frame_CEM_chineequitymarket
        {
           get{ return WebDriver.FindElement(By.XPath("//iframe[@src='/Apps/ChinaEquityMarket/1.0.8/']")); }
        }
        public IWebElement Frame_CEM_equities
        {
            get { return WebDriver.FindElement(By.XPath("//iframe[@src='/Apps/Equities/1.21.1/']")); }
        }
        public IWebElement Frame_CEM_aggrigates
        {
            get { return WebDriver.FindElement(By.XPath("//iframe[@src='/Apps/Aggregates/1.15.7/']")); }
            
        }
            //WebDriver.SwitchTo().DefaultContent();
            /// WebDriver.SwitchTo().Frame(WebDriver.FindElement(By.XPath("//iframe[@src='/Apps/Equities/1.21.1/']")));

        public bool IsEqualList(List<string> list1, List<string> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }
                

            foreach (String ls in list1)
                if (!list2.Contains(ls))
                {
                    return false;
                }
                   
            return true;
        }

        public bool IscountEqualList(List<string> list1, List<string> list2)
        {
            if (list1.Count==list2.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public String Verify_RIC_Table_click()
        {
            Boolean flag = false;
            String Ric = null;
           IWebElement table= WebDriver.FindElement(By.Id("data_table"));

            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));

            Console.Write("No of rows in a Table :- " + rows.Count);
            foreach(IWebElement row in rows)
            {
                IList<IWebElement> columns= row.FindElements(By.TagName("td"));

                Console.Write("No of columns in each and every row :- " + columns.Count);

                foreach(IWebElement col in columns)
                {
                  Ric=   col.GetText();
                    Console.Write("Rics  in a columns :- " + Ric);

                    if(Ric.Contains("EUR3M=CKCC"))
                    {
                        col.Click();
                        flag = true;
                        break;
                    }
                }
                if(flag==true)
                {
                    break;
                }
            }
            return Ric;
        }*/
       
        public void JSclick(IWebElement ele)
        {
         
           IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
             js.ExecuteScript("arguments[0].click()", ele);
            System.Threading.Thread.Sleep(3000); 
 

        }
        public void implicitwaita()
        {
            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));
        }

        public IWebElement News
        {
            get { return WebDriver.FindElement(By.XPath("(//span[@class='my-icon my-icon-news'])[1]")); }
        }

        public IWebElement composite_Text
        {
            get {
                return WebDriver.FindElement(By.XPath("//span[text()='SSE COMPOSITE']")); }
                
            }
        public IWebElement Icon_quote
        {
            get { return WebDriver.FindElement(By.XPath(" (//span[@class='my-icon my-icon-quote'])[1]")); }
           
        }
        public IWebElement Icon_evnt
        {
            get { return WebDriver.FindElement(By.XPath("(//span[@class='my-icon my-icon-event'])[1]")); }
            
        }
        public IWebElement  Icon_Econo
        {
           get { return WebDriver.FindElement(By.XPath("(//span[@class='my-icon my-icon-econo'])[1]")); }

           
        }

        public IWebElement Halt_Short_sell
        {
            get { return WebDriver.FindElement(By.XPath("//a[text()='Halts and Short Sell Restrictions']")); }
        }



            public IWebElement Top_10
           {
              get { return WebDriver.FindElement(By.XPath("//h6[text()='Top 10']")); }

          
            }
        public IWebElement HaltSSR
        {
            get { return WebDriver.FindElement(By.XPath("//span[text()='HaltSSR']")); }


        }
        public IWebElement Top_news
            
        {
            get { return WebDriver.FindElement(By.XPath("//span[text()='China Top News']")); }
            //span[text()='China Top News']
        }
        public IWebElement Great_China_News
        {
            get { return WebDriver.FindElement(By.XPath("//span[text()='NEWS > Greater China']")); }
           
        }
        public IWebElement Language_china
        {
            get { return WebDriver.FindElement(By.XPath("//a[text()='简体中文']")); }

        }

        public List<String>  Top_10_selection_Table()
        {
            List<String> mydata = new List<String>();
            IList<IWebElement> listHeader = WebDriver.FindElements(By.XPath("(//svg[@class='grid-pane-slider'])[5]/div/div/div/span"));

            foreach (var ele in listHeader)
            {

               
                String text = ele.GetText().Trim();
                Console.Write(text);

                mydata.Add(text);

               
            }

            //  Console.Write(mydata.Count + " " + listHeader.Count);
            return mydata;
        }
        public List<String> China_News_Greater()
        {
            List<String> mydata = new List<String>();
            IList<IWebElement> listHeader = WebDriver.FindElements(By.XPath("//h6[@class='ng-binding']"));

            foreach (var ele in listHeader)
            {


                String text = ele.GetText().Trim();
                Console.Write(text);

                mydata.Add(text);

               
            }

            //  Console.Write(mydata.Count + " " + listHeader.Count);
            return mydata;
        }
        public void   Generic_By_Then(IWebElement element,String data)
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
       

        public IWebElement Aggrigates
        {
            get { return WebDriver.FindElement(By.XPath("//span[text()='AGGREGATES']")); }
          
        }

        // Verifcation of page title


    }
}

using NUnit.Framework;
using System;
using EikonViewsAppUtility.TestStatusReporter.CustomAttribute;
using System.Threading;
using ThomsonReuters.Test.WhiteArk.Apps.NA;
using EikonViewsAppUtility.NUnitGroupAssert;
using System.Diagnostics;
using System.Collections.Generic;

namespace NewsApp.Test
{
    public class mostpopularapps : SmokeBase
    {
        [Test]
        [Category("mostpopularapps")]
        [Category("mostpopularapps")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void quoteApp_Tc1_PageTitle()
        {
                       
            QuoteAppWebApp app = new QuoteAppWebApp(eikonDriver);
            var group = new AssertGroup();        
            try
                {
                    Boolean errorresult = app.errorInLoad();
                    if (errorresult)
                    {
                        Logger.Error("an error has accurred we can't find the page you are looking for");
                        Assert.Fail("an error has accurred we can't find the page you are looking for");
                    }
                    else
                    {
                        Console.Write("page is loaded");
                        Assert.IsTrue(errorresult);
                    }
                }
                catch(Exception e)
                {
                    Console.Write(e.Message);
                }
            try
            {
                app.wait();

                String Actualtitle = app.CEMTitle();
                Console.Write("News Monitor:- " + Actualtitle);
               // Assert.AreEqual(Actualtitle, "News: Global Financial News [GLOFIN] AND (News Wires Sources AND Suggested Sources [SUGG] OR Global Press Sources AND Suggested Sources [SUGG] OR Web Sources AND Suggested Sources [SUGG])");
                app.wait();
             
            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                Logger.Error("Unable to Check News Monitor" + e.Message);
                Assert.Fail("Unable to Check News Monitor" + e.Message);
            }
        }

        [Test]
        [Category("mostpopularapps")]
        [Category("mostpopularapps")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void newsApp_Tc()
        {

            NewsAppWebApp app = new NewsAppWebApp(eikonDriver);
            var group = new AssertGroup();
            try
            {

                Boolean errorresult = app.errorInLoad();
                if (errorresult)
                {
                    Logger.Error("an error has accurred we can't find the page you are looking for");
                    Assert.Fail("an error has accurred we can't find the page you are looking for");
                }
                else
                {
                    Console.Write("page is loaded");
                    Assert.IsTrue(errorresult);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            try
            {
                app.wait();

                String Actualtitle = app.CEMTitle();
                Console.Write("News Monitor:- " + Actualtitle);
                // Assert.AreEqual(Actualtitle, "News: Global Financial News [GLOFIN] AND (News Wires Sources AND Suggested Sources [SUGG] OR Global Press Sources AND Suggested Sources [SUGG] OR Web Sources AND Suggested Sources [SUGG])");
                app.wait();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                Logger.Error("Unable to Check News Monitor" + e.Message);
                Assert.Fail("Unable to Check News Monitor" + e.Message);
            }
        }


        [Test]
        [Category("Homepageapps")]
        [Category("Homepageapps")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void homepage_PageTitle()
        {

            HomepageAppWebApp app = new HomepageAppWebApp(eikonDriver);
            var group = new AssertGroup();
            try
            {
                Boolean errorresult = app.errorInLoad();
                if (errorresult)
                {
                    Logger.Error("an error has accurred we can't find the page you are looking for");
                    Assert.Fail("an error has accurred we can't find the page you are looking for");
                }
                else
                {
                    Console.Write("page is loaded");
                    Assert.IsTrue(errorresult);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            try
            {
                app.wait();

                String Actualtitle = app.CEMTitle();
                Console.Write("News Monitor:- " + Actualtitle);
                // Assert.AreEqual(Actualtitle, "News: Global Financial News [GLOFIN] AND (News Wires Sources AND Suggested Sources [SUGG] OR Global Press Sources AND Suggested Sources [SUGG] OR Web Sources AND Suggested Sources [SUGG])");
                app.wait();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                Logger.Error("Unable to Check News Monitor" + e.Message);
                Assert.Fail("Unable to Check News Monitor" + e.Message);
            }
        }
        [Test]
        [Category("Topnewsapps")]
        [Category("Topnewsapps")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void topnews_PageTitle()
        {

            TopNewsAppWebApp app = new TopNewsAppWebApp(eikonDriver);
            var group = new AssertGroup();
            try
            {
                Boolean errorresult = app.errorInLoad();
                if (errorresult)
                {
                    Logger.Error("an error has accurred we can't find the page you are looking for");
                    Assert.Fail("an error has accurred we can't find the page you are looking for");
                }
                else
                {
                    Console.Write("page is loaded");
                    Assert.IsTrue(errorresult);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            try
            {
                app.wait();

                String Actualtitle = app.CEMTitle();
                Console.Write("News Monitor:- " + Actualtitle);
                // Assert.AreEqual(Actualtitle, "News: Global Financial News [GLOFIN] AND (News Wires Sources AND Suggested Sources [SUGG] OR Global Press Sources AND Suggested Sources [SUGG] OR Web Sources AND Suggested Sources [SUGG])");
                app.wait();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                Logger.Error("Unable to Check News Monitor" + e.Message);
                Assert.Fail("Unable to Check News Monitor" + e.Message);
            }
        }

        [Test]
        [Category("Searchapps")]
        [Category("Searchapps")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void Ssearchapp_PageTitle()
        {

            SearchAppWebApp app = new SearchAppWebApp(eikonDriver);
            var group = new AssertGroup();
            try
            {
                Boolean errorresult = app.errorInLoad();
                if (errorresult)
                {
                    Logger.Error("an error has accurred we can't find the page you are looking for");
                    Assert.Fail("an error has accurred we can't find the page you are looking for");
                }
                else
                {
                    Console.Write("page is loaded");
                    Assert.IsTrue(errorresult);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            try
            {
                app.wait();

                String Actualtitle = app.CEMTitle();
                Console.Write("News Monitor:- " + Actualtitle);
                // Assert.AreEqual(Actualtitle, "News: Global Financial News [GLOFIN] AND (News Wires Sources AND Suggested Sources [SUGG] OR Global Press Sources AND Suggested Sources [SUGG] OR Web Sources AND Suggested Sources [SUGG])");
                app.wait();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                Logger.Error("Unable to Check News Monitor" + e.Message);
                Assert.Fail("Unable to Check News Monitor" + e.Message);
            }
        }


        [Test]
        [Category("CompanyOverviewApp")]
        [Category("CompanyOverviewApp")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void companyoverview_PageTitle()
        {

            CompanyOverviewAppWebApp app = new CompanyOverviewAppWebApp(eikonDriver);
            var group = new AssertGroup();
            try
            {
                Boolean errorresult = app.errorInLoad();
                if (errorresult)
                {
                    Logger.Error("an error has accurred we can't find the page you are looking for");
                    Assert.Fail("an error has accurred we can't find the page you are looking for");
                }
                else
                {
                    Console.Write("page is loaded");
                    Assert.IsTrue(errorresult);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            try
            {
                app.wait();

                String Actualtitle = app.CEMTitle();
                Console.Write("News Monitor:- " + Actualtitle);
                // Assert.AreEqual(Actualtitle, "News: Global Financial News [GLOFIN] AND (News Wires Sources AND Suggested Sources [SUGG] OR Global Press Sources AND Suggested Sources [SUGG] OR Web Sources AND Suggested Sources [SUGG])");
                app.wait();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                Logger.Error("Unable to Check News Monitor" + e.Message);
                Assert.Fail("Unable to Check News Monitor" + e.Message);
            }
        }


        [Test]
        [Category("ChartApp")]
        [Category("ChartApp")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void tr_chart_PageTitle()
        {

            ChartAppWebApp app = new ChartAppWebApp(eikonDriver);
            var group = new AssertGroup();
            try
            {
                app.wait();
                app.JSClick(app.Chartpopout);
                Thread.Sleep(5000);
                string RealtimeWindow = eikonDriver.FindGenericWindow("Chart", 5).Title;
                Assert.AreEqual(RealtimeWindow, "Chart");
                Console.WriteLine("Realtime pop out displayed -" + RealtimeWindow);

                /**Boolean errorresult = app.errorInLoad();
                if (errorresult)
                {
                    Logger.Error("an error has accurred we can't find the page you are looking for");
                    Assert.Fail("an error has accurred we can't find the page you are looking for");
                }
                else
                {
                    Console.Write("page is loaded");
                    Assert.IsTrue(errorresult);
                }*/
            }
            catch (Exception e)
            {
                //Logger.Error("Error in opening the pop out window");
                Assert.Fail(e.Message);
            }
            try
            {
                app.wait();

                String Actualtitle = app.CEMTitle();
                Console.Write("News Monitor:- " + Actualtitle);
                // Assert.AreEqual(Actualtitle, "News: Global Financial News [GLOFIN] AND (News Wires Sources AND Suggested Sources [SUGG] OR Global Press Sources AND Suggested Sources [SUGG] OR Web Sources AND Suggested Sources [SUGG])");
                app.wait();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                Logger.Error("Unable to Check News Monitor" + e.Message);
                Assert.Fail("Unable to Check News Monitor" + e.Message);
            }
        }


        [Test]
        [Category("interactive_mapApp")]
        [Category("interactive_mapApp")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void tr_Map_PageTitle()
        {

            MapAppWebApp app = new MapAppWebApp(eikonDriver);
            var group = new AssertGroup();
            try
            {
                app.wait();
                app.JSClick(app.Mappopout);
                Thread.Sleep(5000);
                string RealtimeWindow = eikonDriver.FindGenericWindow("Interactive Map", 15).Title;
                Assert.AreEqual(RealtimeWindow, "Interactive Map");
                Console.WriteLine("Realtime pop out displayed -" + RealtimeWindow);

              
                /*Boolean errorresult = app.errorInLoad();
                if (errorresult)
                {
                    
                    Assert.Fail("an error has accurred we can't find the page you are looking for");
                }
                else
                {
                    Console.Write("page is loaded");
                    Assert.IsTrue(errorresult);
                }*/
            }
            catch (Exception e)
            {
                //Logger.Error("Error in opening the pop out window");
                Assert.Fail(e.Message);
            }
            try
            {
                app.wait();

                String Actualtitle = app.CEMTitle();
                Console.Write("News Monitor:- " + Actualtitle);
                // Assert.AreEqual(Actualtitle, "News: Global Financial News [GLOFIN] AND (News Wires Sources AND Suggested Sources [SUGG] OR Global Press Sources AND Suggested Sources [SUGG] OR Web Sources AND Suggested Sources [SUGG])");
                app.wait();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                Logger.Error("Unable to Check News Monitor" + e.Message);
                Assert.Fail("Unable to Check News Monitor" + e.Message);
            }
        }


        [Test]
        [Category("World Clock")]
        [Category("World Clock")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void tr_Clock_PageTitle()
        {

            ClockAppWebApp app = new ClockAppWebApp(eikonDriver);
            var group = new AssertGroup();
            try
            {
                app.wait();
                app.JSClick(app.Clockpopout);
                Thread.Sleep(5000);
                string RealtimeWindow = eikonDriver.FindGenericWindow("World Clock", 15).Title;
                Assert.AreEqual(RealtimeWindow, "World Clock");
                Console.WriteLine("Realtime pop out displayed -" + RealtimeWindow);


                /*Boolean errorresult = app.errorInLoad();
                if (errorresult)
                {
                    
                    Assert.Fail("an error has accurred we can't find the page you are looking for");
                }
                else
                {
                    Console.Write("page is loaded");
                    Assert.IsTrue(errorresult);
                }*/
            }
            catch (Exception e)
            {
                //Logger.Error("Error in opening the pop out window");
                Assert.Fail(e.Message);
            }
            try
            {
                app.wait();

                String Actualtitle = app.CEMTitle();
                Console.Write("News Monitor:- " + Actualtitle);
                // Assert.AreEqual(Actualtitle, "News: Global Financial News [GLOFIN] AND (News Wires Sources AND Suggested Sources [SUGG] OR Global Press Sources AND Suggested Sources [SUGG] OR Web Sources AND Suggested Sources [SUGG])");
                app.wait();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                Logger.Error("Unable to Check News Monitor" + e.Message);
                Assert.Fail("Unable to Check News Monitor" + e.Message);
            }
        }
    }

}

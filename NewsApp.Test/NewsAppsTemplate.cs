using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EikonViewsAppUtility.TestStatusReporter.CustomAttribute;
using System.Threading;
using ThomsonReuters.Test.WhiteArk.Apps.NA;
using EikonViewsAppUtility.NUnitGroupAssert;
using System.Diagnostics;

namespace NewsApp.Test
{
    class NewsAppsTemplate : SmokeBase
    {

        [Test]
        [Category("mostpopularapps")]
        [Category("mostpopularapps")]
        [Description("Smoke test for News Monitor")]
        [Capability("apps on app server")]

        public void Newsmonitor_App_Tc1_PageTitle()
        {

            NewsAppWebApp app = new NewsAppWebApp(eikonDriver);
            var group = new AssertGroup();
            try
            {
                app.wait();
                app.NewsMonitorpopout();
                Thread.Sleep(9000);
                //app.wait();
                /*if (result)
                {
                    Console.Write("page is loaded");
                    Assert.IsTrue(result);
                    
                }
                else
                {
                    Assert.Fail("an error has accurred we can't find the page you are looking for");
                }*/

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

    }
}

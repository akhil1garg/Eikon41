using OpenQA.Selenium;
using System.Collections.Generic;

namespace ThomsonReuters.Test.WhiteArk.Apps.HomePage.Utils
{
    public static class WebDriverExtension
        {
 
            public static IReadOnlyCollection<IWebElement> FindElements(IWebDriver driver, By by)
            {
                IReadOnlyCollection<IWebElement> elements;

                By locator = by;
                elements = driver.FindElements(locator);
                if (elements.Count > 0)
                    return elements;
                else
                    throw new NoSuchElementException("Unable to find element, locator: \"" + locator.ToString() + "\".");
            }

            public static IReadOnlyCollection<IWebElement> FindElements(IWebElement element, By by)
            {
                IReadOnlyCollection<IWebElement> elements;

                By locator = by;
                elements = element.FindElements(locator);
                if (elements.Count > 0)
                    return elements;
                else
                    throw new NoSuchElementException("Unable to find element, locator: \"" + locator.ToString() + "\".");
            }
     
    
        }



    }


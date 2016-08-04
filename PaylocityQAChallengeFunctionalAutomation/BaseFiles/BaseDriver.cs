using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;

namespace PaylocityQAChallengeFunctionalAutomation.BaseFiles
{
    /// <summary>
    /// Class is used to extend to all test cases
    /// and takes care of creating all drivers
    /// </summary>
    public class BaseDriver
    {
        public static string BaseUrl;
        protected TimeSpan IMPLICIT_WAIT = TimeSpan.FromSeconds(30);
        public static IWebDriver driver;
        public static EventFiringWebDriver eventDriver;
        public static WebDriverWait waitWebDriver;
        /// <summary>
        /// starts a firefox isntance
        /// </summary>
        public void StartDriver()
        {
            driver = new FirefoxDriver();
            WebDriverEventFiring();
        }

        /// <summary>
        /// Wraps the driver in an event firing driver
        /// to allow event listeners to perform functions
        /// after an action has taken place and wraps the
        /// driver with a waitwebdriver 
        /// </summary>
        public void WebDriverEventFiring()
        {
            eventDriver = new EventFiringWebDriver(driver);
            EventSetup.StartEventDriver(eventDriver);
            waitWebDriver = new WebDriverWait(driver, IMPLICIT_WAIT);
        }
        /// <summary>
        /// Waits for page to load
        /// </summary>
        public void WaitForPageToLoad()
        {
            try
            {
                waitWebDriver.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            }
            catch (Exception)
            {

                Console.WriteLine("Caught exception");
            }

        }
        
    }

}


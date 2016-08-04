using System;
using System.Drawing.Imaging;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;

namespace PaylocityQAChallengeFunctionalAutomation.BaseFiles
{
    class EventSetup
    {
        /// <summary>
        /// Method to wrap the driver with the Event Driver
        /// and add Event Firing Listeners
        /// </summary>
        /// <param name="ed"> a event firing web driver </param>
        /// <returns></returns>
        public static void StartEventDriver(EventFiringWebDriver ed)
        {
            ed.ElementClicked += eventDriver_ElementClicked;
            ed.ElementClicking += eventDriver_ElementClicking;
            ed.FindElementCompleted += eventDriver_FindElementCompleted;
            ed.Navigated += eventDriver_Navigated;
            ed.ElementValueChanged += eventDriver_ElementValueChanged;
            ed.ExceptionThrown += eventDriver_TakeScreenShot;
            BaseDriver.driver = ed;
        }
        /// <summary>
        /// caputres screen shot when an exception is thrown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void eventDriver_TakeScreenShot(object sender, WebDriverExceptionEventArgs e)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            BaseDriver.driver.TakeScreenshot().SaveAsFile("Exception-" + timestamp + ".png", ImageFormat.Png);
        }

        /// <summary>
        /// unimplemented methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void eventDriver_ElementValueChanged(object sender, WebElementEventArgs e)
        {
            
        }

        private static void eventDriver_Navigated(object sender, WebDriverNavigationEventArgs e)
        {

        }

        private static void eventDriver_FindElementCompleted(object sender, FindElementEventArgs e)
        {

        }

        private static void eventDriver_ElementClicking(object sender, WebElementEventArgs e)
        {

        }

        private static void eventDriver_ElementClicked(object sender, WebElementEventArgs e)
        {

        }
    }
}

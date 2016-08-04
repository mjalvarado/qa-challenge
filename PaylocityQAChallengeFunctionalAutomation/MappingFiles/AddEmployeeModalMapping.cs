using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PaylocityQAChallengeFunctionalAutomation.BaseFiles;

namespace PaylocityQAChallengeFunctionalAutomation.MappingFiles
{
    class AddEmployeeModalMapping
    {
        /// <summary>
        /// Find Expression for page objects
        /// </summary>
        public struct Expressions
        {
            public static By firstNameInputTextBox = By.CssSelector("div.form-group:nth-child(1) > div:nth-child(2) > input:nth-child(1)");
            public static By lastNameInputTextBox = By.CssSelector("div.form-group:nth-child(2) > div:nth-child(2) > input:nth-child(1)");
            public static By dependentsInputTextBox = By.CssSelector(".col-xs-1 > input:nth-child(1)");
            public static By submitButton = By.CssSelector("button.btn:nth-child(1)");
            public static By closeButton = By.CssSelector("button.btn:nth-child(2)");
            public static By addEmployeeModal = By.Id("addEmployeeModal");
        }
        /// <summary>
        /// Waits for the Add Employee Modal to be visible
        /// </summary>
        public static void WaitForModal()
        {
            BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementIsVisible(AddEmployeeModalMapping.Expressions.addEmployeeModal));
        }
        /// <summary>
        /// Gets the first name text box
        /// </summary>
        /// <returns>IWebElement</returns>
        public static IWebElement GetFirstNameInputTextBox()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(AddEmployeeModalMapping.Expressions.firstNameInputTextBox));
        }
        /// <summary>
        /// Gets the last name text box
        /// </summary>
        /// <returns>IWebElement</returns>
        public static IWebElement GetLastNameInputTextBox()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(AddEmployeeModalMapping.Expressions.lastNameInputTextBox));
        }
        /// <summary>
        /// Gets the dependents text box
        /// </summary>
        /// <returns>IWebElement</returns>
        public static IWebElement GetDependentsInputTextBox()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(AddEmployeeModalMapping.Expressions.dependentsInputTextBox));
        }
        /// <summary>
        /// Gets the submit button
        /// </summary>
        /// <returns>IWebElement</returns>
        public static IWebElement GetSubmitButton()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(AddEmployeeModalMapping.Expressions.submitButton));
        }
        /// <summary>
        /// Gets the close button
        /// </summary>
        /// <returns>IWebElement</returns>
        public static IWebElement GetCloseButton()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(AddEmployeeModalMapping.Expressions.closeButton));
        }
    }
}

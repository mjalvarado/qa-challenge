using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PaylocityQAChallengeFunctionalAutomation.BaseFiles;

namespace PaylocityQAChallengeFunctionalAutomation.MappingFiles
{
    class LoginPageMapping
    {
        /// <summary>
        /// Find expression used to identify page objects
        /// </summary>
        public struct Expressions
        {
            public static By userNameInputTextBox = By.Name("form-username");
            public static By passwordInputTextBox = By.Name("form-password");
            public static By loginButton = By.Id("btnLogin");
        }
        /// <summary>
        /// Gets the user name text box
        /// </summary>
        /// <returns>an IWebElement</returns>
        public static IWebElement GetUserNameInputTextBox()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(Expressions.userNameInputTextBox));
        }
        /// <summary>
        /// Gets the user name text box
        /// </summary>
        /// <returns>an IWebElement</returns>
        public static IWebElement GetPasswordInputTextBox()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(Expressions.passwordInputTextBox));
        }
        /// <summary>
        /// Gets the login button
        /// </summary>
        /// <returns>an IWebElement</returns>
        public static IWebElement GetLoginButton()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(Expressions.loginButton));
        }
    }
}

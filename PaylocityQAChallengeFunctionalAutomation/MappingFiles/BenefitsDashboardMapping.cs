using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PaylocityQAChallengeFunctionalAutomation.BaseFiles;

namespace PaylocityQAChallengeFunctionalAutomation.MappingFiles
{
    class BenefitsDashboardMapping
    {
        /// <summary>
        /// find expression used to identify page objects
        /// </summary>
        public struct Expressions
        {
            public static By addEmployeeButton = By.Id("btnAddEmployee");
            public static By employeeTable = By.Id("employee-table");
        }
        /// <summary>
        /// Gets the Employee Button
        /// </summary>
        /// <returns>an IWebElement</returns>
        public static IWebElement GetAddEmployeeButton()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(BenefitsDashboardMapping.Expressions.addEmployeeButton));
        }
        /// <summary>
        /// Gets the Employee whole table
        /// </summary>
        /// <returns>an IWebElement</returns>
        public static IWebElement GetEmployeeTable()
        {
            return BaseDriver.waitWebDriver.Until<IWebElement>(ExpectedConditions.ElementExists(BenefitsDashboardMapping.Expressions.employeeTable));
        }
        /// <summary>
        /// Gets the row data from the table by index
        /// </summary>
        /// <param name="index">used to identify row base 0</param>
        /// <returns>IWebElement</returns>
        public static IWebElement GetTableRowData(int index)
        {
            IWebElement table = GetEmployeeTable();
            IList<IWebElement> tableRows = table.FindElements(By.TagName("tr"));
            return tableRows[index];
           
        }

    }
}


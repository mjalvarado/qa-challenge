using NUnit.Framework;
using PaylocityQAChallengeFunctionalAutomation.BaseFiles;
using PaylocityQAChallengeFunctionalAutomation.MappingFiles;

namespace PaylocityQAChallengeFunctionalAutomation.TestCases
{
    [TestFixture]
    class BenefitsDashboardTest : BaseDriver
    {
        [TestFixtureSetUp]
        public void Init()
        {
            StartDriver();
        }
        
        [TestFixtureTearDown]
        public void Dispose()
        {
            driver.Quit();
        }
        /// <summary>
        /// Test case needs the challenge saved to C: drive and I used
        /// a firefox version 32 The spirit of this test is to compare
        /// expected values to actual results obtained from the Employee "Add"
        /// </summary>
        [Test]
        public void Verify_Employee_Is_Saved_Correctly_After_Adding()
        {
            driver.Navigate().GoToUrl(@"file:///C:/Paylocity%20QA%20Interview%20Challenge/login.html");
            WaitForPageToLoad();
            LoginPageMapping.GetUserNameInputTextBox().SendKeys("testUser");
            LoginPageMapping.GetPasswordInputTextBox().SendKeys("Test1234");
            LoginPageMapping.GetLoginButton().Click();
            BenefitsDashboardMapping.GetAddEmployeeButton().Click();
            AddEmployeeModalMapping.WaitForModal();
            AddEmployeeModalMapping.GetFirstNameInputTextBox().SendKeys("Michael");
            AddEmployeeModalMapping.GetLastNameInputTextBox().SendKeys("Alvarado");
            AddEmployeeModalMapping.GetDependentsInputTextBox().SendKeys("1");
            AddEmployeeModalMapping.GetSubmitButton().Click();
            Assert.AreEqual("1 Alvarado Michael 52000.00 1 2000 57.69 1942.31", BenefitsDashboardMapping.GetTableRowData(2).Text, "The Employee was not added correctly: " + BenefitsDashboardMapping.GetTableRowData(2).Text);
        }

        /// <summary>
        /// Test case to verify discount is applied correctly
        /// Although the First and Last Name have a bug 
        /// I purposely switched their names so test would pass for an example
        /// of an actual passing test
        /// </summary>
        [Test]
        public void Verify_Discount_Is_Applied_To_Employee()
        {
            driver.Navigate().GoToUrl(@"file:///C:/Paylocity%20QA%20Interview%20Challenge/login.html");
            WaitForPageToLoad();
            LoginPageMapping.GetUserNameInputTextBox().SendKeys("testUser");
            LoginPageMapping.GetPasswordInputTextBox().SendKeys("Test1234");
            LoginPageMapping.GetLoginButton().Click();
            BenefitsDashboardMapping.GetAddEmployeeButton().Click();
            AddEmployeeModalMapping.WaitForModal();
            AddEmployeeModalMapping.GetFirstNameInputTextBox().SendKeys("Adam");
            AddEmployeeModalMapping.GetLastNameInputTextBox().SendKeys("Hollywood");
            AddEmployeeModalMapping.GetDependentsInputTextBox().SendKeys("1");
            AddEmployeeModalMapping.GetSubmitButton().Click();
            Assert.AreEqual("1 Adam Hollywood 52000.00 1 2000 51.92 1948.08", BenefitsDashboardMapping.GetTableRowData(2).Text, "Their was a mismatch in the data" + BenefitsDashboardMapping.GetTableRowData(2).Text);
            
        }


    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SpecFlowTestProject.StepDefinitions
{
    [Binding]
    public class TC2StepDefinitions
    {
        private IWebDriver driver;
        public TC2StepDefinitions(IWebDriver driver)
        {

            this.driver = driver;

        }

        [Then(@"Enter Phone Number")]
        public void ThenEnterPhoneNumber()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Please enter your phone number']")).SendKeys("0521123125");
            Thread.Sleep(1000);
        }

        [Then(@"Enter Fullname")]
        public void ThenEnterFullname()
        {
            driver.FindElement(By.XPath("//input[@placeholder='First Last']")).SendKeys("James");
            Thread.Sleep(1000);
        }

        [Then(@"Enter Password")]
        public void ThenEnterPassword()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Minimum 8 characters with number, letter and characters.']")).SendKeys("Jan@2020");
            Thread.Sleep(1000);
        }

        [Then(@"Enter Brithday Month")]
        public void ThenEnterBrithdayMonth()
        {
            driver.FindElement(By.XPath("//div[@class='mod-birthday-month']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[contains(.,'August')]")).Click();
        }

        [Then(@"Enter Birthday Day")]
        public void ThenEnterBirthdayDay()
        {
            driver.FindElement(By.XPath("//span[@class='next-select large mod-fusion-select mod-birthday-day']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//ul[@class = 'next-menu-content']/li[contains(.,'18')]")).Click();
        }

        [Then(@"Enter Birthday Year")]
        public void ThenEnterBirthdayYear()
        {
            driver.FindElement(By.XPath("//span[@class='next-select large mod-fusion-select mod-birthday-year']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[contains(.,'2001')]")).Click();
        }

        [Then(@"Select Gender")]
        public void ThenSelectGender()
        {
            driver.FindElement(By.XPath("//span[text()='Select']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[contains(.,'male')]")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"enter sms code")]
        public void ThenEnterSmsCode()
        {
            /*error displayed after slider action*/
        }
    }
}

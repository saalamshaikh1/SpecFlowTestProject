using OpenQA.Selenium;
using System;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject.StepDefinitions
{
    [Binding]
    public class TC1StepDefinitions
    {
        private IWebDriver driver;

        public TC1StepDefinitions(IWebDriver driver)
        {

            this.driver = driver;
            
        }

        [Given(@"Open URL")]
        public void GivenOpenURL()
        {
            driver.Url = "https://member.lazada.com.ph/user/register?spm=a2o4l.home.header.d6.239eca18BS6tch";
        }

        [Then(@"Find element bithday using xpath")]
        public void ThenFindElementBithdayUsingXpath()
        {
            driver.FindElement(By.XPath("//div[@class='mod-birthday-month']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[contains(.,'June')]")).Click();

            driver.FindElement(By.XPath("//span[@class='next-select large mod-fusion-select mod-birthday-day']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//ul[@class = 'next-menu-content']/li[contains(.,'12')]")).Click();

            driver.FindElement(By.XPath("//span[@class='next-select large mod-fusion-select mod-birthday-year']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[contains(.,'2023')]")).Click();
            Thread.Sleep(2000);
        }


        [Then(@"Find element bithday using CSS")]
        public void ThenFindElementBithdayUsingCSS()
        {
            driver.FindElement(By.CssSelector("div.mod-birthday-month")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("li[textContent='June']")).Click();

            driver.FindElement(By.CssSelector("span.next-select.large.mod-fusion-select.mod-birthday-day")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("ul.next-menu-content li:contains('12')")).Click();

            driver.FindElement(By.CssSelector("span.next-select.large.mod-fusion-select.mod-birthday-year")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("li:contains('2023')")).Click();
            Thread.Sleep(2000);
        }
    }
}

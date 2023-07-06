using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject.StepDefinitions
{
    [Binding]
    public class TC3StepDefinitions
    {
        private IWebDriver driver;

        public TC3StepDefinitions(IWebDriver driver)
        {

            this.driver = driver;
            
        }

        [Given(@"Open Application URL")]
        public void GivenOpenApplicationURL()
        {
            driver.Url = "https://member.lazada.com.ph/user/register?spm=a2o4l.home.header.d6.239eca18BS6tch";
        }


        [Then(@"Enter Phone Number (.*)")]
        public void ThenEnterPhoneNumberPhoneNumber(string p0)
        {
            driver.FindElement(By.XPath("//input[@placeholder='Please enter your phone number']")).SendKeys(p0);
            Thread.Sleep(1000);
            
        }

        [Then(@"Enter Fullname (.*)")]
        public void ThenEnterFullnameFullname(string p0)
        {
            driver.FindElement(By.XPath("//input[@placeholder='First Last']")).SendKeys(p0);
            Thread.Sleep(1000);
        }

        [Then(@"Enter Password (.*)")]
        public void ThenEnterPasswordPassword(string p0)
        {
            driver.FindElement(By.XPath("//input[@placeholder='Minimum 8 characters with number, letter and characters.']")).SendKeys(p0);
            Thread.Sleep(1000);
        }

        [Then(@"Enter Brithday Month (.*)")]
        public void ThenEnterBrithdayMonthBrithdayMonth(string p0)
        {
            driver.FindElement(By.XPath("//div[@class='mod-birthday-month']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[contains(.,'"+p0+"')]")).Click();

        }

        [Then(@"Enter Birthday Day (.*)")]
        public void ThenEnterBirthdayDayBirthdayDay(string p0)
        {
            driver.FindElement(By.XPath("//span[@class='next-select large mod-fusion-select mod-birthday-day']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//ul[@class = 'next-menu-content']/li[contains(.,'"+p0+"')]")).Click();
        }

        [Then(@"Enter Birthday Year (.*)")]
        public void ThenEnterBirthdayYearBirthdayYear(string p0)
        {
            driver.FindElement(By.XPath("//span[@class='next-select large mod-fusion-select mod-birthday-year']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[contains(.,'"+p0+"')]")).Click();
        }

        [Then(@"Select Gender (.*)")]
        public void ThenSelectGenderGender(string p0)
        {
            driver.FindElement(By.XPath("//span[text()='Select']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[contains(.,'" + p0 + "')]")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"Click on slide to get sms code")]
        public void ThenClickOnSlideToGetSmsCode()
        {
        

            IWebElement Slider = driver.FindElement(By.XPath("//span[@id = 'nc_2_n1z']"));
            Actions moveSlider = new Actions(driver);
            IAction action = moveSlider.DragAndDropToOffset(Slider, 340, 0).Build();
            action.Perform();
            Thread.Sleep(2000);
        }

        [Then(@"enter sms code (.*)")]
        public void ThenEnterSmsCodeSMSCode(string p0)
        {
           /*error displayed after slider action*/
        }

        [Then(@"Click on SIGNUP")]
        public void ThenClickOnSIGNUP()
        {
            driver.FindElement(By.XPath("//button[text()= 'SIGN UP']")).Click();
            Thread.Sleep(2000);
            
        }
    }
}

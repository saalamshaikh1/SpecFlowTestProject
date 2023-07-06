using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.ComponentModel;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {

            _container = container;
        }

        [BeforeScenario("@Firefox")]
        public void BeforeScenarioWithTag()
        {
            IWebDriver driver = new FirefoxDriver();
            _container.RegisterInstanceAs(driver);
            driver.Manage().Window.Maximize();
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {

            IWebDriver driver = new ChromeDriver();
            _container.RegisterInstanceAs(driver);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();

            }
        }
    }
}


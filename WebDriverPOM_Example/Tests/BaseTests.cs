using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverPOM_Example.Tests
{
    public class BaseTests
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void SetUp() 
        {
            // this.driver = new ChromeDriver();           
            this.driver = new FirefoxDriver();
        }

        [OneTimeTearDown]
        public void Browser_ShutDown() 
        {
            driver.Quit();
        }
    }
}

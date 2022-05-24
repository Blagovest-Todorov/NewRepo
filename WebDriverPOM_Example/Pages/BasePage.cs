using OpenQA.Selenium;
using System;

namespace WebDriverPOM_Example.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        public virtual string PageUrl { get; }

       // public readonly string HomePageRegisteredStudentsCount;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public IWebElement HomeLink => driver.FindElement(
            By.LinkText("Home"));
        public IWebElement ViewStudentsLink => driver.FindElement(
            By.LinkText("View Students"));
        public IWebElement AddStudentLink => driver.FindElement(
            By.LinkText("Add Student"));

        public IWebElement PageHeading => driver.FindElement(
            By.CssSelector("body > h1:nth-child(6)"));

        public IWebElement AddStudentLink_NameField => driver.FindElement(By.CssSelector("body > form > div:nth-child(1) > label"));
       

        public void Open() 
        {
          driver.Navigate().GoToUrl(this.PageUrl);
        }

        public bool IsOpen() 
        {
            return driver.Url == this.PageUrl;
        }

        public string GetPageUrl()  
        {
            return driver.Url;
        }

        public string GetPageHeading() 
        {
            return PageHeading.Text;
        }

        public string GetPageTitle() 
        {
            return driver.Title; 
        }
        
    }
}

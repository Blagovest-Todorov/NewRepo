using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverPOM_Example.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/";

        public IWebElement studentCount => driver.FindElement(
            By.CssSelector("body > p:nth-child(7) > b:nth-child(1)"));

        public IWebElement registeredStudentsString => driver.FindElement(
            By.CssSelector("body > p:nth-child(7) > b:nth-child(1)"));

        public int GetStudentCount() 
        {
            return int.Parse(studentCount.Text);
        }
    }
}

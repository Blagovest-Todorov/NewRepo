using OpenQA.Selenium;

namespace WebDriverPOM_Example.Pages
{
    public class ViewStudentsPage : BasePage
    {
        public ViewStudentsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/students";

        

      
    }
}

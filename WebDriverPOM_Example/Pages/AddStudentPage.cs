using OpenQA.Selenium;

namespace WebDriverPOM_Example.Pages
{
    public class AddStudentPage : BasePage
    {
        public AddStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/add-student";


        public string name { get; set; }

        public string email { get; set; }

        public int add_button { get; set; }


        public void RegisterStudent(string name, string email) 
        {
            //name.SendKeys(name);
            //email.Sendkeys(email);
            //add_button.Click();
        }
    }
}

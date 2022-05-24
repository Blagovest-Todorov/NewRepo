using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverPOM_Example.Pages;

namespace WebDriverPOM_Example.Tests
{
    public class HomePageTests : BaseTests
    {
       
        [Test]
        public void Test_HomePage_Url_Heading_Title()
        {
            var home_Page = new HomePage(driver);
            home_Page.Open();

            // Assert.AreEqual(home_Page.GetPageUrl(), driver.Url);
            Assert.That(driver.Url, Is.EqualTo(home_Page.GetPageUrl()));
            Assert.That(home_Page.GetPageHeading(), Is.EqualTo("Students Registry"));
            Assert.That(home_Page.GetPageTitle(), Is.EqualTo("MVC Example"));
        }

        [Test]
        public void Test_HomePage_HomeLink_RegiteredUsersText()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.HomeLink.Click();
            Assert.That(home_page.GetPageTitle(), Is.EqualTo("MVC Example"));
            Assert.That(driver.Url, Is.EqualTo(home_page.GetPageUrl()));
           // Assert.That(home_page.studentCount.Text, Is.EqualTo("9"));
            //Assert.That(home_page.registeredStudentsString.Text, Is.EqualTo("Registered students: 9"));


        }

        [Test]
        public void Test_HomePage_ViewStudentsLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.ViewStudentsLink.Click();
            var view_student = new ViewStudentsPage(driver);
            Assert.That(view_student.GetPageTitle, Is.EqualTo("Students"));
            Assert.That(driver.Url, Is.EqualTo(view_student.GetPageUrl()));      

        }

        [Test]
        public void Test_HomePage_AddStudentLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.AddStudentLink.Click();
            var add_student = new AddStudentPage(driver);
            Assert.That(add_student.GetPageTitle, Is.EqualTo("Add Student"));
            Assert.That(driver.Url, Is.EqualTo(add_student.GetPageUrl()));    
        }

        [Test]
        public void Test_HomePage_CheckRegisteredUsersCount()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.HomeLink.Click();
            //Assert.That(home_page.studentCount.Text, Is.EqualTo("9"));
            Assert.Greater(home_page.GetStudentCount(), 0);

        }

      
    }
}

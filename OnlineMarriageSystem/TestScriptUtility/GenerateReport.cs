using OnlineMarriageSystem.POM_repo;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlineMarriageSystem.TestScriptUtility
{
    class GenerateReport
    {
        [Test]
        public void getreport()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://49.249.28.218:8081/AppServer/Online_Couple_Marriage_Registration_System/admin/login.php");
            driver.Manage
                ().Window.Maximize
                ();
            SigninPage sgpage = new SigninPage(driver); 
            sgpage.Usernametextfield.SendKeys("admin");
            sgpage.Passwordtextfield.SendKeys("Test@123");
            sgpage.Signinbutton.Click();
            Thread.Sleep(2000);
            HomePage hmp = new HomePage(driver);
            hmp.Reportlink.Click();
            driver.FindElement(By.Id("fromdate")).SendKeys("05031998");

        }
    }
}

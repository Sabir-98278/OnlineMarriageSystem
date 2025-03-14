using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    class WelcomePage
    {
        public WelcomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.PartialLinkText, Using = "Admin")]
        private IWebElement adminlink;

        public IWebElement Adminlink { get => adminlink; set => adminlink = value; }
    }
}

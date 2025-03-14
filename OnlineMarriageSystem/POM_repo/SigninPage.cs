using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    class SigninPage
    {
        public SigninPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using="//input[@type='text']")]
        private IWebElement usernametextfield;

        [FindsBy(How = How.XPath, Using="//input[@type='password']")]
        private IWebElement passwordtextfield;

        [FindsBy(How = How.XPath, Using="//button[@type='submit']")]
        private IWebElement signinbutton;

        public IWebElement Usernametextfield { get => usernametextfield; }
        public IWebElement Passwordtextfield { get => passwordtextfield;  }
        public IWebElement Signinbutton { get => signinbutton; }
    }
}

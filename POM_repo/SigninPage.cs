using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarriageSystem.POM_repo
{
    class SigninPage
    {
      public SigninPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using="//input[@type='text']")]
        private IWebElement usernametextfieldAdmin;

        [FindsBy(How = How.XPath, Using="//input[@type='password']")]
        private IWebElement passwordtextfieldAdmin;

        [FindsBy(How = How.XPath, Using="//button[@type='submit']")]
        private IWebElement signinbuttonAdmin;

        [FindsBy(How=How.XPath,Using = "//a[@href='admin/login.php']")]
        private IWebElement adminLink;

        [FindsBy(How =How.XPath,Using = "//a[@href='user/login.php']")]
        private IWebElement userLink;

        [FindsBy(How =How.Name, Using = "mobno")]
        private IWebElement usernameTextFieldUser;

        [FindsBy(How=How.Name, Using = "password")]
        private IWebElement passwordtextfieldUser;

        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement userSubmitButton;

        public IWebElement UsernametextfieldAdmin { get => usernametextfieldAdmin; set => usernametextfieldAdmin = value; }
        public IWebElement PasswordtextfieldAdmin { get => passwordtextfieldAdmin; set => passwordtextfieldAdmin = value; }
        public IWebElement SigninbuttonAdmin { get => signinbuttonAdmin; set => signinbuttonAdmin = value; }
        public IWebElement UserLink { get => userLink; set => userLink = value; }
        public IWebElement UsernameTextFieldUser { get => usernameTextFieldUser; set => usernameTextFieldUser = value; }
        public IWebElement PasswordtextfieldUser { get => passwordtextfieldUser; set => passwordtextfieldUser = value; }
        public IWebElement UserSubmitButton { get => userSubmitButton; set => userSubmitButton = value; }
        public IWebElement AdminLink { get => adminLink; set => adminLink = value; }

        //Bussiness Utility

        public void LoginAsUser(string usernameU, string passwordU)
        {
            userLink.Click();
            UsernameTextFieldUser.SendKeys(usernameU);
            PasswordtextfieldUser.SendKeys(passwordU);
            UserSubmitButton.Click();

        }
        public void LoginASADmin(string usernameU, string passwordU) 
        {
            AdminLink.Click();
            UsernametextfieldAdmin.SendKeys(usernameU);
            PasswordtextfieldAdmin.SendKeys(passwordU);
            signinbuttonAdmin.Click();
        }


    }
}

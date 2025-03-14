using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    class SearchMarriageAppPage
    {
        public SearchMarriageAppPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Name, Using = "searchdata")]
        private IWebElement searchbyRegnotextfield;

        [FindsBy(How = How.Id, Using = "search")]
        private IWebElement submitbutton;

        public IWebElement SearchbyRegnotextfield { get => searchbyRegnotextfield; set => searchbyRegnotextfield = value; }
        public IWebElement Submitbutton { get => submitbutton; set => submitbutton = value; }
    }
}

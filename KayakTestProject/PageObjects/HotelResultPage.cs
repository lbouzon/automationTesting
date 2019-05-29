using OpenQA.Selenium;

namespace KayakTestProject.PageObjects
{
    public class HotelResultPage : HotelPage
    {
        private IWebDriver driver;

        public HotelResultPage(IWebDriver driver) :base (driver)
        {
            this.driver = driver;
        }


    }
}
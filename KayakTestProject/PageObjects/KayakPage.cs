using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayakTestProject.PageObjects
{
    public class KayakPage
    {

        private IWebDriver driver;

        public KayakPage(IWebDriver driver)
        {
            this.driver = driver;
        }
         

        private IWebElement flights => driver.FindElement(By.Name(""));

        private IWebElement hotels => driver.FindElement(By.Name(""));

        //[FindsBy(How = How.ClassName, Using = "_qC _e _qM")]
        //private IWebElement searchIcon;

        public void goToPage(string _url)
        {
            driver.Navigate().GoToUrl(_url);
        }



        public FlightPage goToFlightPagePage()
        {
            flights.Click();
            return new FlightPage(driver);
        }


        public HotelPage goToHotelPagePage()
        {
            hotels.Click();
            return new HotelPage(driver);
        }
    }
}
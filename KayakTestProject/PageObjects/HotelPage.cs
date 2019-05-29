using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayakTestProject.PageObjects
{
    public class HotelPage : KayakPage
    {
        private IWebDriver driver;

        public HotelPage(IWebDriver driver) : base (driver)
        {
            this.driver = driver;
        }

        private IWebElement destiny => driver.FindElement(By.CssSelector("[id$=location-display"));

        private IWebElement fromDate => driver.FindElement(By.CssSelector("[id$=dateRangeInput-display-start]"));

        private IWebElement toDate => driver.FindElement(By.CssSelector("[id$=dateRangeInput-display-end]"));

        private IWebElement searchButton => driver.FindElement(By.ClassName("searchButton"));



        public HotelResultPage SearchHotels()
        {
            searchButton.Click();
            return new HotelResultPage(driver);
        }

    }
}

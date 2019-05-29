using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayakTestProject.PageObjects
{
    public class FlightPage : KayakPage
    {
        private IWebDriver driver;

        public FlightPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private IWebElement originAirport => driver.FindElement(By.CssSelector("[id$=origin-airport]"));
        // document.querySelector("[id$='origin-airport-display']")

        private IWebElement destinyAirport => driver.FindElement(By.CssSelector("[id$=destination-airport]"));

        private IWebElement fromDate => driver.FindElement(By.CssSelector("[id$=depart-input]"));

        private IWebElement fromDateClick => driver.FindElement(By.CssSelector("[id$=dateRangeInput-display-start-inner]"));
     

        private IWebElement toDate => driver.FindElement(By.CssSelector("[id$=return-input]"));

        private IWebElement searchButton => driver.FindElement(By.CssSelector("._qC"));

        public void SelectFromDate(string initDate)
        {
            fromDateClick.Click();
            fromDate.SendKeys(initDate);
          
        }

        public void SelectToDate(string endDate)
        {
            toDate.Click();
            toDate.SendKeys(endDate);

        }


        public void SelectFromCity(string fromCty)
        {
            originAirport.SendKeys(fromCty);

        }

        public void SelectToCity(string toCty)
        {
            destinyAirport.SendKeys(toCty);

        }

        public FlightlResultPage SearchFlights()
        {
            searchButton.Click();
            return new FlightlResultPage(driver);
        }

    }
}

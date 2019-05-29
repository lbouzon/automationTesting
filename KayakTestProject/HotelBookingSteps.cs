using KayakTestProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace KayakTestProject
{
    [Binding]
    public class HotelBookingSteps
    {
        ScenarioContext scenarioContext;
      

        public HotelBookingSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
      
        }


        [Given(@"I have entered Ubatuba into the hotel destiny")]
        [Obsolete]
        public void GivenIHaveEnteredUbatunaIntoTheHotelDestiny()
        {
            IWebDriver driver = new FirefoxDriver();
            HotelPage hotelPage = new HotelPage(driver);
            hotelPage.goToPage("https://www.kayak.com.ar/hotels");
            hotelPage.SearchHotels();
        }
        
        [Given(@"I have salected date (.*)/(.*) into the start date")]
        [Obsolete]
        public void GivenIHaveSalectedDateIntoTheStartDate(string p0, int p1)
        {
            Console.WriteLine("This is a test");
        }
        
        [Given(@"I have salected date (.*)/(.*) into the end date")]
        [Obsolete]
        public void GivenIHaveSalectedDateIntoTheEndDate(string p0, int p1)
        {
            Console.WriteLine("This is a test");
        }
        
        [When(@"I press the search icon")]
        [Obsolete]
        public void WhenIPressTheSearchIcon()
        {
            Console.WriteLine("This is a test");
        }
        
        [Then(@"the result should be a list of hotels")]
        [Obsolete]
        public void ThenTheResultShouldBeAListOfHotels()
        {
            Console.WriteLine("This is a test");
        }
    }
}

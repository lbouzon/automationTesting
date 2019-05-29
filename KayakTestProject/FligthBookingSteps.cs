using System;
using TechTalk.SpecFlow;
using KayakTestProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace KayakTestProject
{
    [Binding]
    public class FligthBookingSteps2
    {
       ScenarioContext scenarioContext;
       static IWebDriver driverTest = new FirefoxDriver();
       FlightPage searchFlightPage = new FlightPage(driverTest);

        FlightlResultPage result ;
       


        [Given(@"I am in the Kayak Flight Page")]
        public void GivenIAmInTheKayakFlightPage()
        {
            searchFlightPage.goToPage("https://www.kayak.com.ar/flights");
            
        }
        
        [Given(@"I have entered current date in IDA")]
        public void GivenIHaveEnteredDateInIDA()
        {
            string today = DateTime.Now.ToString("dd/MM/yyyy"); // case sensitive
            searchFlightPage.SelectFromDate(today);
        }
        
        [Given(@"I have entered ""(.*)"" plus days from current date in VUELTA")]
        public void GivenIHaveEnteredDateInVUELTA(string p1)
        {
            Int32.TryParse(p1, out int tripLength); 

            string tripLengthString = DateTime.Now.AddDays(tripLength).ToString("dd/MM/yyyy"); // case sensitive
            searchFlightPage.SelectToDate(tripLengthString);
        }

        [Given(@"I have entered ""(.*)"" city in ORIGEN")]
        public void GivenIHaveEnteredCityInOrignen(string orig)
        {
            searchFlightPage.SelectFromCity(orig);
        }
        
        [Given(@"I have entered ""(.*)"" city as DESTINO")]
        public void GivenIHaveEnteredCityAsDESTINO(string dest)
        {
            searchFlightPage.SelectToCity(dest);
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the Search Icon")]
        public void WhenIClickOnSeachIcon()
        {
            result = searchFlightPage.SearchFlights();
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be a list of flights for those date")]
        public void ThenTheResultShouldBeAListOfFlightsForThoseDate()
        {
            Console.WriteLine(result.GetType());
        }
    }
}

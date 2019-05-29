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
    public class FlightlResultPage : FlightPage
    {
        private IWebDriver driver;

        public FlightlResultPage(IWebDriver driver): base(driver)
            {
            this.driver = driver;
        }


        private List<IWebElement> listaResultadoVuelo => driver.FindElements(By.Name("")).ToList<IWebElement>();

       private IWebElement moreResults => driver.FindElement(By.Name(""));


    }



}
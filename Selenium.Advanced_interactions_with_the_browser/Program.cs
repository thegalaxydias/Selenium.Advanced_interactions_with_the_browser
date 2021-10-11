using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;


namespace Selenium.Advanced_interactions_with_the_browser
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://uitestpractice.com/");

            IWebElement drag = driver.FindElement(By.Id("draggable"));
            IWebElement drop = driver.FindElement(By.Id("droppable"));

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(drag));
           
            Actions builder = new Actions(driver);

            builder.DragAndDrop(element, drop).Build().Perform();

            
        }
    }
}

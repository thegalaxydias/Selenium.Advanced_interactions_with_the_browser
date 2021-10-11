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
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();

            IWebElement drag = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/img"));
            IWebElement drop = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(drag));
           
            Actions builder = new Actions(driver);

            builder.DragAndDrop(element, drop).Build().Perform();

            
        }
    }


}

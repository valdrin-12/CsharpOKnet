using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CsharpSelenium2022
{
    public class Tests : DriverHelper
    {
    
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();

           
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
         //   Driver.FindElement(By.CssSelector("")).Click();

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo","Almond"); 
            

            
            Console.WriteLine("testtttt2");
            Assert.Pass();
        }
    }
}
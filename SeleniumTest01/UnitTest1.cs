using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest01
{
    public class Tests : DriverHelper
    {
        
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This is set Up");            
            driver = new ChromeDriver(@"D:\Selenium Related\chromedriver_win32\");
            driver.Manage().Window.Maximize();    
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("To");
            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            Console.WriteLine("Test 1");
            Assert.Pass();
        }
    }
}
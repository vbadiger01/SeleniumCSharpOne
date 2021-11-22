using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest01
{
    public class CustomControl : DriverHelper
    {


        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboBox = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboBox.Clear();
            comboBox.SendKeys("Almond");
            driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();

        }


    }
}

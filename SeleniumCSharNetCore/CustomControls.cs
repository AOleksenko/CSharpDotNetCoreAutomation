using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharNetCore
{
    class CustomControls : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboBox = Driver.FindElement(By.Id($"{controlName}-awed"));
            comboBox.Clear();
            comboBox.SendKeys(value);
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();

        }
    }
}

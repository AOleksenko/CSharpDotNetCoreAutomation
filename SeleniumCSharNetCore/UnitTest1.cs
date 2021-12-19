using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharNetCore
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            //ChromeOptions chromeOptions = new ChromeOptions();


            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            //$x("//input[@id='ContentPlaceHolder1_Meal']") - find quantities of elements on the page
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("text");

           // CustomControls controls= new CustomControls();
            CustomControls.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Assert.Pass();
        }
    }
}
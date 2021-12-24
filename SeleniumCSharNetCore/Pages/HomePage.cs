using OpenQA.Selenium;
using System;


namespace SeleniumCSharNetCore.Pages
{
	class HomePage : DriverHelper
	{
		IWebElement LnkLogin => Driver.FindElement(By.LinkText("Login"));

		IWebElement LnkLogoff => Driver.FindElement(By.LinkText("Log off"));

		public void ClickLogin() => LnkLogin.Click();

		public bool IsLogoffExit() => LnkLogoff.Displayed;
	}
}

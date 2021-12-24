using OpenQA.Selenium;
using System;

namespace SeleniumCSharNetCore.Pages
{
	public class LoginPage : DriverHelper
	{
		IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
		IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
		IWebElement BtnLogin => Driver.FindElement(By.ClassName("btn-default"));


		public void EnterUserNameAndPassword (string Username, string Password)
        {
			txtUserName.SendKeys(Username);
			txtPassword.SendKeys(Password);
        }

		public void ClickLogin ()
        {
			BtnLogin.Click();
        }

	}
}
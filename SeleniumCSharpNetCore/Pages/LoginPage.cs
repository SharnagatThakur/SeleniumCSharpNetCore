using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage : DriverHelper
    {

        IWebElement userNameInput => Driver.FindElement(By.Id("UserName"));
        IWebElement passwordInput => Driver.FindElement(By.Id("Password"));
        IWebElement loginBtn => Driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input"));

        public void EnterUsernameAndPassword(string userName, string password)
        {
            userNameInput.SendKeys(userName);
            passwordInput.SendKeys(password);
        }

        public void ClickLoginBtn()
        {
            loginBtn.Click();
        }

    }
}

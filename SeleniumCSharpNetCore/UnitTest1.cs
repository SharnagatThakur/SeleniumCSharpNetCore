using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;
using WebDriverManager;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    { 

        [SetUp]
        public void Setup()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            option.AddArguments("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());
            Console.WriteLine("Setup");
            Driver = new ChromeDriver(option);
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            //CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            Assert.Pass();
        }

        //[Test]
        //public void LoginTest()
        //{
        //    Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

        //    HomePage homePage = new HomePage();
        //    LoginPage loginPage = new LoginPage();

        //    homePage.ClickLogin();
        //    loginPage.EnterUsernameAndPassword("admin", "password");
        //    loginPage.ClickLoginBtn();
        //    Assert.That(homePage.IsLogOffExist(), Is.True, "Log Off button did not displayed");

        //}


    }
}
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace _01.Summator_App_Testing
{
    public class Base_Class
    {       
        private const string AppiumServer = "http://127.0.0.1:4723/wd/hub";
        private WindowsDriver<WindowsElement> driver;
        private AppiumOptions options;     

        public WindowsElement FirstField => driver.FindElementByAccessibilityId("textBoxFirstNum");

        public WindowsElement SecondField => driver.FindElementByAccessibilityId("textBoxSecondNum");

        public WindowsElement CalculateButton => driver.FindElementByAccessibilityId("buttonCalc");

        public WindowsElement ResultField => driver.FindElementByAccessibilityId("textBoxSum");

        [OneTimeSetUp]
        public void Setup()
        {
            options = new AppiumOptions() { PlatformName = "Windows" };            
            options.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\PC\Desktop\APP\SummatorDesktopApp.exe");
            driver = new WindowsDriver<WindowsElement>(new Uri(AppiumServer), options);            
        }

        [OneTimeTearDown]
        public void Shut_Down()
        {           
            driver.Quit();
        }

        public string Sum_Numbers(string number1,string number2)
        {
            FirstField.Click();
            FirstField.SendKeys(number1);
            SecondField.Click();
            SecondField.SendKeys(number2);
            CalculateButton.Click();
            return ResultField.Text;
        }

        public void Clear_Fields()
        {
            FirstField.Clear();
            SecondField.Clear();
        }

    }
}
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Manager;

namespace TestProject1.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            const string CalculatorAppId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
            AppiumOptions appCapabilities = new AppiumOptions();
            appCapabilities.AddAdditionalCapability("app", CalculatorAppId);
            appCapabilities.AddAdditionalCapability("deviceName", "WindowsPC"); // 19-21 - заполнение конфига для запуска драйвера 

            DriverManager.StartDriver(appCapabilities);
        }

        [TearDown]
        public void TearDown()
        {
            DriverManager.StopDriver();
        }
    }
}

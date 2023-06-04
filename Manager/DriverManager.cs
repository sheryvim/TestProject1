using Microsoft.VisualStudio.TestPlatform.TestHost;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject1.Manager
{
    class DriverManager
    {
        public static WindowsDriver<WindowsElement> driver;
        const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private static Process _process;
        const string driverPuff = "F:\\Windows Application Driver\\WinAppDriver.exe";

        /// <summary>
        /// Запускает драйвер
        /// </summary>
        /// <param name="appCapabilities">Настройки драйвера</param> 
        public static void StartDriver(string url, AppiumOptions appCapabilities)
        {
            _process = Process.Start(driverPuff);
            driver = new WindowsDriver<WindowsElement>(new Uri(url), appCapabilities);
            Assert.IsNotNull(driver, "драйвер не запустился");
        }

        /// <summary>
        /// Запускает драйвер
        /// </summary>
        /// <param name="appCapabilities">Настройки драйвера</param> 
        public static void StartDriver(AppiumOptions appCapabilities)
        {
            _process = Process.Start(driverPuff);
            driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
            Assert.IsNotNull(driver, "драйвер не запустился");
        }

        /// <summary>
        /// Останавливает драйвер
        /// </summary>
       public static void StopDriver()
        {
            driver.Close();
            _process.Kill();
        }

        /// <summary>
        /// получение экземпляра драйвера
        /// </summary>
        /// <returns>объект драйвера</returns>
        public static WindowsDriver<WindowsElement> GetDriver() 
        { 
            return driver; 
        }

        
    }
}

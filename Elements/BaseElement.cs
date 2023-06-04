using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Elements
{
    class BaseElement
    {
        protected WindowsElement element;

        public BaseElement(WindowsElement element)
        {
            this.element = element;
        }

        /// <summary>
        /// срабатывание нажатия кнопки мыши
        /// </summary>
        public void Click()
        {
            element.Click();
        }

        /// <summary>
        /// получение текста
        /// </summary>
        /// <returns>присвоение текста</returns>
        public string GetText()
        {
            return element.Text;
        }

        /// <summary>
        /// Проверка на видимость
        /// </summary>
        /// <returns></returns>
        public bool IsVisible()
        {
            return element.Displayed;
        }


    }
}

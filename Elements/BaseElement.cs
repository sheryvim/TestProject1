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
        /// Срабатывание нажатия кнопки мыши
        /// </summary>
        public void Click()
        {
            element.Click();
        }

        /// <summary>
        /// Получение текста
        /// </summary>
        /// <returns>Текст из элемента</returns>
        public string GetText()
        {
            return element.Text;
        }
    }
}

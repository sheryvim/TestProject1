using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Elements
{
    class TextField : BaseElement
    {

        /// <summary>
        /// для описания доп функций
        /// </summary>
        /// <param name="element">для хранения </param>
        public TextField(WindowsElement element) : base(element)
        {
        }

        /// <summary>
        /// устанавливаем полученный текст
        /// </summary>
        /// <param name="text">Текст для установки</param>
        public void SetText(string text)
        {
            this.Click();
            element.SendKeys(text);

        }
    }
}

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
        public TextField(WindowsElement element) : base(element)
        {
        }

        public void SetText(string text)
        {
            this.Click();
            element.SendKeys(text);

        }
    }
}

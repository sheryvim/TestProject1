using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Elements;
using TestProject1.Manager;

namespace TestProject1.Forms
{
    class CalculatorForm : BaseForm
    {
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;  
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonEqual;

        private Button buttonComma;
        private Button buttonNegate;

        private TextField ResutlField;

       /// <summary>
       /// Получение элемента из экземпляра драйвера для поиска нужной кнопки
       /// </summary>
       /// <returns>запись значения</returns>
        public CalculatorForm InitForm()
        {
            button0 = new Button(DriverManager.GetDriver().FindElementByName("Нуль"));
            button1 = new Button(DriverManager.GetDriver().FindElementByName("Один"));
            button2 = new Button(DriverManager.GetDriver().FindElementByName("Два"));
            button3 = new Button(DriverManager.GetDriver().FindElementByName("Три"));
            button4 = new Button(DriverManager.GetDriver().FindElementByName("Четыре"));
            button5 = new Button(DriverManager.GetDriver().FindElementByName("Пять"));
            button6 = new Button(DriverManager.GetDriver().FindElementByName("Шесть"));
            button7 = new Button(DriverManager.GetDriver().FindElementByName("Семь"));
            button8 = new Button(DriverManager.GetDriver().FindElementByName("Восемь"));
            button9 = new Button(DriverManager.GetDriver().FindElementByName("Девять"));

            buttonPlus = new Button(DriverManager.GetDriver().FindElementByName("Плюс"));
            buttonMinus = new Button(DriverManager.GetDriver().FindElementByName("Минус"));
            buttonMultiply = new Button(DriverManager.GetDriver().FindElementByName("Умножить на"));
            buttonDivide = new Button(DriverManager.GetDriver().FindElementByName("Разделить на"));
            buttonEqual = new Button(DriverManager.GetDriver().FindElementByName("Равно"));

            buttonComma = new Button(DriverManager.GetDriver().FindElementByName("Десятичный разделитель"));
            buttonNegate = new Button(DriverManager.GetDriver().FindElementByName("Положительное отрицательное"));

            ResutlField = new TextField(DriverManager.GetDriver().FindElementByAccessibilityId("CalculatorResults"));
            return this;
        }

        /// <summary>
        /// Вызов клика нужного числового значения
        /// </summary>
        /// <param name="buttonText">текст для значения</param>
        /// <returns>Запись в поле</returns>
        public CalculatorForm ClickNumButtom(string buttonText)
        {
            char[] chars = buttonText.ToCharArray();
            foreach(char c in chars)
            {
                    switch (c)
                {
                    case '0':
                        button0.Click(); 
                        break;
                    case '1': 
                        button1.Click();
                        break;
                    case '2':
                        button2.Click();
                        break;
                    case '3':
                        button3.Click();
                        break;
                    case '4':
                        button4.Click();
                        break;
                    case '5':
                        button5.Click();
                        break;
                    case '6':
                        button6.Click();
                        break;
                    case '7':
                        button7.Click();
                        break;
                    case '8':
                        button8.Click();
                        break;
                    case '9':
                        button9.Click();
                        break;
                    case '.':
                    case ',':
                        buttonComma.Click();
                        break;
                }
            }
            if (buttonText.Contains("-"))
                buttonNegate.Click();
            return this;
        }

        /// <summary>
        /// вызов нужного клика на арифметические знаки
        /// </summary>
        /// <param name="operandText">Текст для арифметического знака</param>
        /// <returns>возвращение нужного знака</returns>
        public CalculatorForm ClickOperandButton(string operandText)
        {
            switch (operandText)
            {
                case "+":
                    buttonPlus.Click();
                    break;
                case "-":
                    buttonMinus.Click();
                    break;
                case "*":
                    buttonMultiply.Click(); 
                    break;
                case "/":
                    buttonDivide.Click(); 
                    break;
                case "=":
                    buttonEqual.Click();
                    break;
            }
            return this;
        }

        /// <summary>
        /// Получение текста из окна результата
        /// </summary>
        /// <returns>Присвоение значения</returns>
        public string GetResult()
        {
            return ResutlField.GetText();
        }
    }
}

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using TestProject1.Forms;
using TestProject1.Manager;

namespace TestProject1.Tests
{
    [TestFixture("2", "+", "2", "5")]
    [TestFixture("2", "+", "2", "4")]
    [TestFixture("2", "+", "2,1", "4,1")]
    [TestFixture("-2", "*", "5", "-10")]
    [TestFixture("10", "/", "5", "2")]
   
    public class CalcTest : BaseTest
    {
        string firstNum;
        string operand;
        string secondNum;
        string expectedResult;
        
        CalculatorForm calcForm = new CalculatorForm();

        public CalcTest(string firstNum, string operand, string secondNum, string result)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            this.operand = operand;
            this.expectedResult = result;
        }

        [Test]
        public void Test1()
        {
            calcForm.InitForm();
            calcForm.ClickNumButtom(firstNum)
                .ClickOperandButton(operand)
                .ClickNumButtom(secondNum)
                .ClickOperandButton("=");
            string result = calcForm.GetResult();
            Assert.AreEqual("Отображать как " + expectedResult, result, "Ошибка");
                
        }
    }
}
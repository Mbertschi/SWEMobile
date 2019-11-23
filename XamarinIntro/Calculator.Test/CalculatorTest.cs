using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XamarinIntro.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void GetSumary_AddOperand_ThenAddOperatorAddition_ThenOperant_ReturnsExpectedResult()
        {
            //Arrange
            string excpectedResult = "4";

            Calculator calculator = new Calculator();
            calculator.AddNumber(2);
            calculator.AddOperator(Operator.Addition);
            calculator.AddNumber(2);
            //Act,
            var result = calculator.getSumary();

            //Assert
            Assert.AreEqual(excpectedResult, result);

        }

        [TestMethod]
        public void GetSumary_AddOperand_ThenAddOperator_Subtraction_ThenOperant_ReturnsExpectedResult()
        {
            //Arrange
            string excpectedResult = "48";

            Calculator calculator = new Calculator();
            calculator.AddNumber(50);
            calculator.AddOperator(Operator.Subtraction);
            calculator.AddNumber(2);
            //Act,
            var result = calculator.getSumary();

            //Assert
            Assert.AreEqual(excpectedResult, result);

        }

        [TestMethod]
        public void GetSumary_AddOperand_ThenAddOperatorDivision_ThenOperant_ReturnsExpectedResult()
        {
            //Arrange
            string excpectedResult = "24";

            Calculator calculator = new Calculator();
            calculator.AddNumber(48);
            calculator.AddOperator(Operator.Division);
            calculator.AddNumber(2);
            //Act,
            var result = calculator.getSumary();

            //Assert
            Assert.AreEqual(excpectedResult, result);

        }

        [TestMethod]
        public void GetSumary_AddOperand_ThenAddOperatorMultipication_ThenOperant_ReturnsExpectedResult()
        {
            //Arrange
            string excpectedResult = "25";

            Calculator calculator = new Calculator();
            calculator.AddNumber(5);
            calculator.AddOperator(Operator.Multipication);
            calculator.AddNumber(5);
            //Act,
            var result = calculator.getSumary();

            //Assert
            Assert.AreEqual(excpectedResult, result);

        }

        [TestMethod]
        public void GetSumary_AddOperand_ThenAddOperatorMultipication_ThenOperant_ThenResetResultReturnsExpectedResult()
        {
            //Arrange
            string excpectedResult = "0";

            Calculator calculator = new Calculator();
            calculator.AddNumber(5);
            calculator.AddOperator(Operator.Multipication);
            calculator.AddNumber(5);
            var result = calculator.getSumary();
            //Act,
            calculator.resetValues();
            result = calculator.getSumary();

            //Assert
            Assert.AreEqual(excpectedResult, result);

        }
    }
}

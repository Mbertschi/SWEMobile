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
            calculator.AddNumber(Operant.Two);
            calculator.AddOperator(Operator.Addition);
            calculator.AddNumber(Operant.Two);
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
            calculator.AddNumber(Operant.Five);
            calculator.AddNumber(Operant.Zero);
            calculator.AddOperator(Operator.Subtraction);
            calculator.AddNumber(Operant.Two);
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
            calculator.AddNumber(Operant.Four);
            calculator.AddNumber(Operant.Eight);
            calculator.AddOperator(Operator.Division);
            calculator.AddNumber(Operant.Two);
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
            calculator.AddNumber(Operant.Five);
            calculator.AddOperator(Operator.Multipication);
            calculator.AddNumber(Operant.Five);
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
            calculator.AddNumber(Operant.Five);
            calculator.AddOperator(Operator.Multipication);
            calculator.AddNumber(Operant.Five);
            var result = calculator.getSumary();
            //Act,
            calculator.resetValues();
            result = calculator.getSumary();


            //Assert
            Assert.AreEqual(excpectedResult, result);

        }

        [TestMethod]
        public void GetSumary_AddOperand_ThenAddOperatorAddition_ThenOperant_ThenAddOperatorAddition_ThenAddOperant_ThenReturnsExpectedResult()
        {
            //Arrange
            string excpectedResult = "15";

            Calculator calculator = new Calculator();
            calculator.AddNumber(Operant.Five);
            calculator.AddOperator(Operator.Addition);
            calculator.AddNumber(Operant.Five);
            calculator.AddOperator(Operator.Addition);
            calculator.AddNumber(Operant.Five);

            //Act,

            var result = calculator.getSumary();

            //Assert
            Assert.AreEqual(excpectedResult, result);

        }

        [TestMethod]
        public void GetSumary_AddOperand_ThenAddOperatorAddition_ThenOperant_ThenAddOperatorAddition_ThenAddOperant_ThenAddOperatorSubtraciton_ThenAddOperant_ThenReturnsExpectedResult()
        {
            //Arrange
            string excpectedResult = "12";

            Calculator calculator = new Calculator();
            calculator.AddNumber(Operant.Five);
            calculator.AddOperator(Operator.Addition);
            calculator.AddNumber(Operant.Five);
            calculator.AddOperator(Operator.Addition);
            calculator.AddNumber(Operant.Five);
            calculator.AddOperator(Operator.Subtraction);
            calculator.AddNumber(Operant.Three);
           
            //Act,
            var result = calculator.getSumary();


            //Assert
            Assert.AreEqual(excpectedResult, result);

        }



        [TestMethod]
        public void AddComaWithoutaNumber()
        {
            //Arrange
            string excpectedResult = "0.";
            Calculator calculator = new Calculator();
            //Assert
            Assert.AreEqual(excpectedResult, calculator.AddComa());

        }

        [TestMethod]
        public void GetSumary_AddOperand_ThenAddComa_ThenAddOperant_ThenAddComa_ThenAddOperand_ThenAddOperator_ThenAddOperant_ThenGetSumary()
        {
            //Arrange
            string excpectedResult = "4,55";

            Calculator calculator = new Calculator();
            calculator.AddNumber(Operant.Five);
            calculator.AddComa();
            calculator.AddNumber(Operant.Five);
            calculator.AddComa();
            calculator.AddNumber(Operant.Five);
            calculator.AddOperator(Operator.Subtraction);
            calculator.AddNumber(Operant.One);
            
            //Act,
            
            var result = calculator.getSumary();


            //Assert
            Assert.AreEqual(excpectedResult, result);

        }

        [TestMethod]
        public void GetNewVAlue_AddNumber_ThenChangeSingn_ThenExpectTheNegativResult()
        {
            //Arrange
            string excpectedResult = "-9";

            Calculator calculator = new Calculator();
            calculator.AddNumber(Operant.Nine);


            //Assert
            Assert.AreEqual(excpectedResult, calculator.ChangeSign());

        }


        [TestMethod]
        public void GetNewVAlue_AddNumber_ThenChangeSingn_ThenExpectThePositivResult()
        {
            //Arrange
            string excpectedResult = "4";

            Calculator calculator = new Calculator();
            calculator.AddNumber(Operant.One);
            calculator.AddOperator(Operator.Subtraction);
            calculator.AddNumber(Operant.Five);
            
            //Act,
            
            var result = calculator.getSumary();

            //Assert
            Assert.AreEqual(excpectedResult, calculator.ChangeSign());

        }


       


    }
}

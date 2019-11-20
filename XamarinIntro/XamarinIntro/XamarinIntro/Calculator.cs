using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinIntro


{
    public enum Operator
    {
        Addition = 1,
        Subtraction = 2,
        Multipication = 3,
        Division = 4
    }

    interface ICalculator
    {
         void AddNumber(int inNumber);

         void AddOperator(Operator inOpterator);

        String getSumary();
        void resetValues();


    }
    class Calculator : ICalculator

    {

        private Operator calct;
        private int addedNumber1 = 0;
        private int addedNumber2 = 0;
        private int sumary;



        public void AddNumber(int inNumber) {


            addedNumber1 = addedNumber1*10+inNumber; 

        }

        public void AddOperator(Operator inOperator)
        {
            calct = inOperator;
            if(addedNumber2 == 0)
            {
                addedNumber2 = addedNumber1;
                addedNumber1 = 0;
            }
            
        }

        public void resetValues()
        {
            addedNumber1 = 0;
            addedNumber2 = 0;
        }

        private void calculate( int number1 , int numberTwo, Operator inoperator)
        {
            int i = (int)inoperator;
             switch (i)
            {
                case 1:
                   
                    sumary = number1 + numberTwo;
                    break;
                case 2:
                    sumary = number1 - numberTwo;
                    break;
                case 3:
                    sumary = number1 * numberTwo;
                    break;
                case 4:
                    if (numberTwo == 0)
                    {
                        break;
                    }
                    else
                    {
                        sumary = number1 / numberTwo;
                    }
                    break;
                default:
                    break;
            }

        }

        public String getSumary(){
          calculate(addedNumber2, addedNumber1, calct);
            addedNumber2 = sumary;
            addedNumber1 = 0;
     
            return sumary.ToString();
        }



        }
    }


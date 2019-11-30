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
        Division = 4,
        
    }

    public enum Operant
    {
        One =1,
        Two =2 ,
        Three  = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven =7,
        Eight = 8,
        Nine = 9,
        Zero = 0
    }

    public interface ICalculator
    {
        void AddNumber(Operant inNumber);

        void AddOperator(Operator inOpterator);

        string getSumary();

        void resetValues();

        String ChangeSign();

        String AddComa();

        String DivideBy100();


    }
    public class Calculator : ICalculator

    {

        private Operator calct;
        private string addedNumber1 = null;
        private string addedNumber2 = null;
        private double sumary;


        public void AddNumber(Operant inNumber)
        {
           
            
                addedNumber1 += (int)inNumber;
        
         }

        public void AddOperator(Operator inOperator)
        {
            
            if (addedNumber2 == null)
            {
                addedNumber2 = addedNumber1;
                calct = inOperator;
                addedNumber1 = null;
            }
            else if(addedNumber1 != null)
            {
                addedNumber2 = getSumary();
                calct = inOperator;
            }
           


        }
        public String AddComa()
        {
            String coma;
            if (addedNumber1 != null && !addedNumber1.Contains(".") )
            {
                addedNumber1 += ".";
                 coma = ".";
            }
            else if (addedNumber1 == null)
            {
                addedNumber1 = "0.";
                coma  = "0.";
            }
            else
            {
                coma = "";
            }
          

            return coma;   
            
        }

        public void resetValues()
        {
            addedNumber1 = null;
            addedNumber2 = null;
          
        }

        private void calculate(String numberone, String numberTwo, Operator inoperator)
        {
            int i = (int)inoperator;

            double value1 =0;
            if(addedNumber2 != null)
            {
                value1 = double.Parse(numberone, System.Globalization.CultureInfo.InvariantCulture);
            }
            

            double value2 = 0;

            if(addedNumber1 != null)
            {
                 value2 = double.Parse(numberTwo, System.Globalization.CultureInfo.InvariantCulture);
            }
            
            switch (i)
            {
                case 1:

                    sumary = value1 + value2;
                    break;
                case 2:
                    sumary = value1 - value2;
                    break;
                case 3:
                    sumary = value1 * value2;
                    break;
                case 4:
                    if ( value2 != 0 )
                    {
                        sumary = value1 / value2;
                    }

                    break;
                default:
                    break;
            }

        }

        public String getSumary()
        {
            calculate(addedNumber2, addedNumber1, calct);
            addedNumber2 = sumary.ToString();
            addedNumber1 = null;

            return sumary.ToString();
        }

        public String ChangeSign()
        {
            if (addedNumber1 != null)
            {
                sumary = double.Parse(addedNumber1, System.Globalization.CultureInfo.InvariantCulture) * (-1);
                addedNumber1 = sumary.ToString();
            }
            else
            {
                sumary = double.Parse(addedNumber2, System.Globalization.CultureInfo.InvariantCulture) * (-1);
                addedNumber2 = sumary.ToString();
            }
            return sumary.ToString();
        }

        public String DivideBy100()
        {
            if(addedNumber1 != null )
            {
                
                sumary = double.Parse(addedNumber1, System.Globalization.CultureInfo.InvariantCulture) / 100;
                addedNumber1 = sumary.ToString();
            }
            else if ( addedNumber1 == null && addedNumber2 != null)
            {
                sumary = double.Parse(addedNumber2, System.Globalization.CultureInfo.InvariantCulture) / 100;
                addedNumber2 = sumary.ToString();

            }else
            {
                sumary = 0;
            }
            
            return sumary.ToString();
        }

    
    }
}


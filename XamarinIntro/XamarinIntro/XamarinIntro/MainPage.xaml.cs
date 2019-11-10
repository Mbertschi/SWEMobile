using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinIntro
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ICalculator icalucate = new Calculator();

        public MainPage()
        {
            InitializeComponent();
         
        }

        
        

        private void Button_Gleich_Clicked(object sender, EventArgs e)
        {
            
            Sumary.Text = icalucate.getSumary();
        }

        private void Button_Plus_Clicked(object sender, EventArgs e)
        {
            icalucate.AddOperator(Operator.Addition);
            Sumary.Text += "+";
            
        }

        private void Button_0_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(0);
            Sumary.Text += 0.ToString();
        }

        private void Button_1_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(1);
            Sumary.Text += 1.ToString();
        }

        private void Label_4_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(4);
            Sumary.Text += 4.ToString();
        }

        private void Label_3_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(3);
            Sumary.Text += 3.ToString();
        }

        private void Label_5_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(5);
            Sumary.Text += 5.ToString();
        }

        private void Label_6_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(6);
            Sumary.Text += 6.ToString();
        }

        private void Label_7_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(7);
            Sumary.Text += 7.ToString();
        }

        private void Label_8_Clicked(object sender, EventArgs e)
        {

            icalucate.AddNumber(8);
           
            Sumary.Text += 8.ToString();
        }

        private void Label_9_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(9);
            Sumary.Text += 9.ToString();
        }

        private void Label_Coma_Clicked(object sender, EventArgs e)
        {
            
            Sumary.Text += ",";
        }

        private void Label_Mal_Clicked(object sender, EventArgs e)
        {
            icalucate.AddOperator(Operator.Multipication);
            Sumary.Text += "*";
        }

        private void Button_Durch_Clicked(object sender, EventArgs e)
        {
            icalucate.AddOperator(Operator.Division);
            Sumary.Text += "/";
        }

        private void Button_AC_Clicked(object sender, EventArgs e)
        {
            Sumary.Text = "";
            icalucate.resetValues();
        }

        private void Button_Prozent_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_PlusMinus_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Label_2_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(2);
            Sumary.Text += 2.ToString();
        }

        private void Button_Minus_Clicked(object sender, EventArgs e)
        {
            icalucate.AddOperator(Operator.Subtraction);
            Sumary.Text += "-";
        }
    }
}

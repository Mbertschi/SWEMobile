﻿using System;
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
        private ICalculator icalucate;

        public MainPage(ICalculator inncalculator)
        {
            this.icalucate = inncalculator;
            InitializeComponent();
         
        }

        
        

        private void Button_Gleich_Clicked(object sender, EventArgs e)
        {
            
            Sumary.Text = icalucate.getSumary().ToString();
        }

        private void Button_Plus_Clicked(object sender, EventArgs e)
        {
            icalucate.AddOperator(Operator.Addition);
            Sumary.Text += "+";
            
        }

        private void Button_0_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(Operant.Zero);
            Sumary.Text += 0.ToString();
        }

        private void Button_1_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(Operant.One);
            Sumary.Text += 1.ToString();
        }

        private void Button_4_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(Operant.Four);
            Sumary.Text += 4.ToString();
        }

        private void Button_3_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(Operant.Three);
            Sumary.Text += 3.ToString();
        }

        private void Button_5_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(Operant.Five);
            Sumary.Text += 5.ToString();
        }

        private void Button_6_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(Operant.Six);
            Sumary.Text += 6.ToString();
        }

        private void Button_7_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(Operant.Seven);
            Sumary.Text += 7.ToString();
        }

        private void Button_8_Clicked(object sender, EventArgs e)
        {

            icalucate.AddNumber(Operant.Eight);
           
            Sumary.Text += 8.ToString();
        }

        private void Button_9_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(Operant.Nine);
            Sumary.Text += 9.ToString();
        }

        private void Button_Coma_Clicked(object sender, EventArgs e)
        {
            
            Sumary.Text += icalucate.AddComa(); ;
        }

        private void Button_Mal_Clicked(object sender, EventArgs e)
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
            Sumary.Text = icalucate.DivideBy100();
        }

        private void Button_PlusMinus_Clicked(object sender, EventArgs e)
        {   
           Sumary.Text = icalucate.ChangeSign();   
        }

        private void Button_2_Clicked(object sender, EventArgs e)
        {
            icalucate.AddNumber(Operant.Two);
            Sumary.Text += 2.ToString();
        }

        private void Button_Minus_Clicked(object sender, EventArgs e)
        {
            icalucate.AddOperator(Operator.Subtraction);
            Sumary.Text += "-";
        }
    }
}

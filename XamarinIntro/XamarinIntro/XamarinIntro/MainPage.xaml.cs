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
        private int number1 ;
        private int number2 ;
        private int sumary ;
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void Button_Gleich_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Button_Plus_Clicked(object sender, EventArgs e)
        {

            Sumary.Text = Sumary.Text + "+";
        }

        private void Button_0_Clicked(object sender, EventArgs e)
        {
            Sumary.Text = Sumary.Text + 0.ToString();
        }

        private void Button_1_Clicked(object sender, EventArgs e)
        {
            Sumary.Text = Sumary.Text + 1.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwsomeApp;
using Xamarin.Forms;

namespace Lesson4LabA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string input = "";

        public void BtnSpace_Clicked(Object sender, System.EventArgs e)
        {
            LblMorse.Text += " ";
            char newLetter = Morse.MorseCoder(input);
            LblOutput.Text += newLetter;
            input = "";
        }

        public void BtnDot_Clicked(Object sender, System.EventArgs e)
        {
            input += ".";
            LblMorse.Text += ".";
        }

        public void BtnDash_Clicked(Object sender, System.EventArgs e)
        {
            input += "-";
            LblMorse.Text += "-";
        }

        public void BtnClear_Clicked(Object sender, System.EventArgs e)
        {
            input = "";
            LblMorse.Text = "";
            LblOutput.Text = "";
        }
    }
}

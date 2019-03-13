using System;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MainPage : ContentPage
    {
        private int counter = 0;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            this.counter++;
            this.MyButton.Text = $"Clicked {this.counter}";
        }
    }
}

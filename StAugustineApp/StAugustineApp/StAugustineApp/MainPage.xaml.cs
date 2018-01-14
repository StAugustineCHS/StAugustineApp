using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StAugustineApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HandleClicked(object sender, EventArgs e)
        {
            this.DisplayAlert("A Title", "You clicked ME!! :D", "Cool");
        }
    }
}

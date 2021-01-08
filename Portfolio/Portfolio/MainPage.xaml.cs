using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Portfolio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Main_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void Project_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyProjects());
        }
        private async void CV_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CV());
        }
        private async void Contact_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Contact());
        }
    }
}

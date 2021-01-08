using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact : ContentPage
    {
        public Contact()
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
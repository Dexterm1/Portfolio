using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyProjects : ContentPage
    {
        ObservableCollection<Binding> gallery = new ObservableCollection<Binding>();
        public ObservableCollection<Binding> Gallery { get { return gallery; } }

        public MyProjects()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            GalleryView.ItemsSource = gallery;

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes
            gallery.Add(new Binding { Name = "Portfolio", Description = "Creating my own portfolio in Xamarin", Images = "Xamarin.png" });
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
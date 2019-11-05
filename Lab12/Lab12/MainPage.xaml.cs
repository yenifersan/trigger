using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Lab12.Data());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Lab12.Event());
            };

            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Lab12.Property());

            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Lab12.Style());

            };

            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Lab12.MultiTrigger());

            };

        }
    }
}


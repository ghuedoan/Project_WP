using KeepItFit___Project_WinUI.Model;
using KeepItFit___Project_WinUI.ViewModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.StartScreen;
using System.Diagnostics;
using System.Collections.ObjectModel;


namespace KeepItFit___Project_WinUI
{
    public sealed partial class FoodPage : Page
    {
        public FoodPageViewModel viewModel { get; set; }

        public FoodPage()
        {
            this.InitializeComponent();
            viewModel = new FoodPageViewModel();
            viewModel.init();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is string mealName && !string.IsNullOrEmpty(mealName))
            {
                mealList.PlaceholderText = mealName;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Cancel button
            this.Frame.Navigate(typeof(FoodDiary));
           
        }

        private void AddJournal_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FoodDiary),viewModel.nutritions);
        }
    }
}

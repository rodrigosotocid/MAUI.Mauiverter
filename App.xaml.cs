﻿using MAUI.Mauiverter.MVVM.Views;

namespace MAUI.Mauiverter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuView());

            //MainPage = new ConverterView();
        }
    }
}

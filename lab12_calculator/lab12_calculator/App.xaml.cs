﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab12_calculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new lab12_calculator.View.CalculatorView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

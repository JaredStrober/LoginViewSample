﻿using LoginViewSample.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginViewSample.Core.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    BindingContext = ViewModel;
		}

	    public MainViewModel ViewModel { get; } = new MainViewModel(App.NavigationService);
	}
}

using DatePickerDemo.ViewModels;

namespace DatePickerDemo;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainPageViewModel mainPageViewModel)
	{
		InitializeComponent();
		BindingContext=mainPageViewModel;
	}

	
}


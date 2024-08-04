using TASKER_APP.MVVM.ViewModels;

namespace TASKER_APP.MVVM.Views;

public partial class MainView : ContentPage
{	
	private MainViewModel mainViewModel = new MainViewModel();

	public MainView()
	{
		InitializeComponent();
		BindingContext = mainViewModel;
	}

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		mainViewModel.UpdateData();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		var taskview = new NewTaskView
		{
			BindingContext = new NewTaskViewModel
			{
				Tasks = mainViewModel.Tasks,
				Categories = mainViewModel.Categories,
			}
		};

		Navigation.PushAsync(taskview);
    }
}
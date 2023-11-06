using DalluiMAUI.MVVM.Views;

namespace DalluiMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DashboardView();
	}
}

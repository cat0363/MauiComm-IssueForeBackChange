namespace MauiComm_IssueForeBackChange;
using CommunityToolkit.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void btnShowF_Clicked(object sender, EventArgs e)
	{
		var popup = new Popup1();
		Shell.Current.CurrentPage.ShowPopup(popup);
    }

	void btnShowB_Clicked(object sender, EventArgs e)
	{
		IDispatcherTimer timer;

		timer = Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromMilliseconds(5000);
		timer.Tick += (s, e) =>
		{
			var popup = new Popup1();
			Shell.Current.CurrentPage.ShowPopup(popup);
			timer.Stop();
		};
		timer.Start();
	}
}


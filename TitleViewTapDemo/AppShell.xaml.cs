namespace TitleViewTapDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(NewPage), typeof(NewPage));
    }
}


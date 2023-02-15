using UmlautLib;

namespace MauiUmlautCrash;

public partial class App : Application
{
	private readonly Tür _tor;

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

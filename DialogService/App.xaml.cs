using DialogService.Defines.Interfaces;
using DialogService.ViewModels;
using DialogService.Views.Windows;
using GalaSoft.MvvmLight.Ioc;
using System.Windows;

namespace DialogService
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public App()
		{
			Bootstrapper.Init();
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
			dialog.Register<MainWindow>();
			dialog.Register<Dialog>();
			dialog.Register<Dialog2>();

			dialog.Set<MainViewModel, MainWindow>(new MainViewModel());
		}
	}
}

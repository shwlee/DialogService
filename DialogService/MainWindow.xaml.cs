using DialogService.Defines.Interfaces;
using GalaSoft.MvvmLight;
using System.Windows;

namespace DialogService
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, IDialog
	{
		public MainWindow()
		{
			InitializeComponent();
		}
	}

	public class AppViewModel : ViewModelBase, IDialogContext
	{
		private IContext _context;

		public IContext Context
		{
			get => _context;
			set => this.Set(ref this._context, value);
		}
	}
}

using DialogService.Defines.Interfaces;
using GalaSoft.MvvmLight;
using System.Windows;

namespace DialogService.Views.Windows
{
	/// <summary>
	/// Interaction logic for Dialog.xaml
	/// </summary>
	public partial class Dialog : Window, IDialog
	{
		public Dialog()
		{
			InitializeComponent();
		}
	}

	public class DialogViewModel : ViewModelBase, IDialogContext
	{
		private IContext _context;

		public IContext Context
		{
			get => _context;
			set => this.Set(ref this._context, value);
		}
	}
}

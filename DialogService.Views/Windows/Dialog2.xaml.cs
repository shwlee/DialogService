using DialogService.Defines.Interfaces;
using GalaSoft.MvvmLight;
using System.Windows;

namespace DialogService.Views.Windows
{
	/// <summary>
	/// Interaction logic for Dialog2.xaml
	/// </summary>
	public partial class Dialog2 : Window, IDialog2
	{
		public Dialog2()
		{
			InitializeComponent();
		}
	}

	public class DialogViewModel2 : ViewModelBase, IDialogContext
	{
		private IContext _context;

		public IContext Context
		{
			get => _context;
			set => this.Set(ref this._context, value);
		}
	}
}

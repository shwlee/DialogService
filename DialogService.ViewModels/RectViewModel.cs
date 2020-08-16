using DialogService.Defines.Interfaces;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System.Windows.Input;

namespace DialogService.ViewModels
{
	public class RectViewModel : IContext
	{
		public RelayCommand _outCommand;

		public ICommand OutCommand => this._outCommand ?? (this._outCommand = new RelayCommand(this.Out));

		private void Out()
		{
			var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
			dialog.Out(this);
		}
	}
}

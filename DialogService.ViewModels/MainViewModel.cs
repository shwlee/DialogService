using DialogService.Defines.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System.Windows.Input;

namespace DialogService.ViewModels
{
	public class MainViewModel : ViewModelBase, IContext
	{
		private RelayCommand _goRectCommand;

		public ICommand GoRectCommand => this._goRectCommand ?? (this._goRectCommand = new RelayCommand(this.GoRect));

		private RelayCommand _goEllipseCommand;

		public ICommand GoEllipseCommand => this._goEllipseCommand ?? (this._goEllipseCommand = new RelayCommand(this.GoEllipse));

		private RelayCommand _goEllipseModalCommand;

		public ICommand GoEllipseModalCommand => this._goEllipseModalCommand ?? (this._goEllipseModalCommand = new RelayCommand(this.GoEllipseModal));

		private RelayCommand _closeCommand;

		public ICommand CloseCommand => this._closeCommand ?? (this._closeCommand = new RelayCommand(this.Close));

		private void Close()
		{
			var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
			dialog.Out(this);
		}

		private void GoEllipseModal()
		{
			var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
			dialog.SetAwait(new EllipseViewModel()); //  TODO : EllipseViewModel 역시 캐시하거나 DI 넣고 쓰자.
		}

		private void GoEllipse()
		{
			var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
			dialog.Set(new EllipseViewModel()); //  TODO : EllipseViewModel 역시 캐시하거나 DI 넣고 쓰자.
		}

		private void GoRect()
		{
			var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
			dialog.Set(new RectViewModel()); //  TODO : RectViewModel 역시 캐시하거나 DI 넣고 쓰자.
		}
	}
}

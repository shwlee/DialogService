using DialogService.Defines.Interfaces;
using GalaSoft.MvvmLight.Ioc;

namespace DialogService
{
	public static class Bootstrapper
	{
		public static void Init()
		{
			SimpleIoc.Default.Register<IDialogService, Services.DialogService>();
		}
	}
}

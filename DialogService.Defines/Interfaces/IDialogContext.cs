namespace DialogService.Defines.Interfaces
{
	public interface IDialogContext // Window 가 사용할 ViewModel
	{
		IContext Context { get; set; }
	}
}

using System;

namespace DialogService.Defines.Interfaces
{
	public interface IDialogService : IDisposable
	{
		void Register<TDialog>()
			where TDialog : class, IDialog;

		void Set<TContext>(TContext context) // Show
			where TContext : IContext;

		void Set<TContext, TDialog>(TContext context)
			where TContext : IContext
			where TDialog : IDialog;

		bool? SetAwait<TContext>(TContext context) // ShowDialog
			where TContext : IContext;

		bool? SetAwait<TContext, TDialog>(TContext context)
			where TContext : IContext
			where TDialog : IDialog;

		void Out<TContext>(TContext context) // Close
			where TContext : IContext;

		void Out<TContext, TDialog>(TContext context)
			where TContext : IContext
			where TDialog : IDialog;

		void Clear();
		// 나머지 기능이 더 필요할 경우(ex, minimize, maximize ..etc) 추가로 멤버를 작성한다.
	}
}

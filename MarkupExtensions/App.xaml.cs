using Prism.Unity;
using MarkupExtensions.Views;
using System.Diagnostics;

namespace MarkupExtensions
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync(nameof(MainPage));
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<MainPage>();
		}

		protected override void OnSleep()
		{
			base.OnSleep();
			Debug.WriteLine($"{this.GetType().Name}.{nameof(OnSleep)}");
		}

		protected override void OnStart()
		{
			base.OnStart();
			Debug.WriteLine($"{this.GetType().Name}.{nameof(OnStart)}");
		}

		protected override void OnResume()
		{
			base.OnResume();
			Debug.WriteLine($"{this.GetType().Name}.{nameof(OnResume)}");
		}
	}
}


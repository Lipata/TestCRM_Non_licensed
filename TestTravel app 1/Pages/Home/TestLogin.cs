using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app_1.Pages.Home;

namespace TestTravel_app_1
{
	public class TestLogin
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbCheckboxModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Login>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
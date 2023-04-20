using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app_1.Pages.Home;

namespace TestTravel_app_1
{
	public class TestSet_new_password
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Set_new_password>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
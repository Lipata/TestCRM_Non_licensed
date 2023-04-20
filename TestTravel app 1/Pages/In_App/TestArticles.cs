using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app_1.Pages.In_App;
using Travel_app_1.TravelApp;

namespace TestTravel_app_1
{
	public class TestArticles
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule));
			ctx.Services.AddScoped<ITravelAppService>(sp => new MockTravelAppService());
			var componentUnderTest = ctx.RenderComponent<Articles>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
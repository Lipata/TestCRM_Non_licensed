using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app_1.Pages.In_App;
using Travel_app_1.TravelApp;
using Travel_app_1.Northwind;

namespace TestTravel_app_1
{
	public class TestDashboard
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<ITravelAppService>(sp => new MockTravelAppService());
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Dashboard>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
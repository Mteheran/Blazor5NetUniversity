using System;
using Xunit;
using blazor5dotnet;
using Bunit;
using blazor5dotnet.Pages.Counter;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using blazor5dotnet.ViewModels;
using Blazored.Toast.Services;

namespace Client.Tests
{
    public class CounterTest
    {
        [Fact]
        public void CounterIncrese()
        {
            using var ctx = new TestContext();
            ctx.Services.AddSingleton<ILogger<Counter>, Logger<Counter>>();
            ctx.Services.AddSingleton(new CounterViewModel());
            ctx.Services.AddSingleton<IToastService, ToastService>();

            var component = ctx.RenderComponent<Counter>();

            var parElement = component.Find("p");

            component.Find("button").Click();

            var elementResult = parElement.TextContent;

            parElement.MarkupMatches("<p>Current count: 1</p>");

        }
    }
}

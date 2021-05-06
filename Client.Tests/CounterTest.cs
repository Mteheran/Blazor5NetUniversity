using System;
using Xunit;
using blazor5dotnet;

namespace Client.Tests
{
    public class CounterTest
    {
        [Fact]
        public void CounterIncrese()
        {
            using var ctx = new TestContext();
            var component = ctx.RederComponent<Counter>();

            var parElement = component.Find("p");

            component.Find("button").Click();

            var elementResult = parElement.TextContent;

            parElement.MarkupMatches("Current count: 1");


        }
    }
}

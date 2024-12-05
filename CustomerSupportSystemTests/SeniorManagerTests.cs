using System.IO;
using Xunit;
using CustomerSupportSystem.Handlers;
using CustomerSupportSystem.Models;
using System;
using CustomerSupportSystem;

namespace CustomerSupportSystemTests
{
    public class SeniorManagerTests
    {

        [Fact]
        public void HandleRequest_ShouldHandleAdvancedQuery()
        {
            // Arrange
            var seniorManager = new SeniorManager();
            var query = new Query(Query.ComplexityLevel.Advanced, "System outage");
            var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            seniorManager.HandleRequest(query);

        }
    }
}

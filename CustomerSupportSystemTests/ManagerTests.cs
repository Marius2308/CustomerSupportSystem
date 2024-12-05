using CustomerSupportSystem;
using System;
using System.IO;
using Xunit;
using CustomerSupportSystem.Handlers;
using CustomerSupportSystem.Models;

namespace CustomerSupportSystemTests
{
    public class ManagerTests
    {
        [Fact]
        public void HandleRequest_ShouldHandleQuery()
        {
            // Arrange
            var manager = new Manager();
            var query = new Query(Query.ComplexityLevel.Intermediate, "Billing discrepancy");
            var sw = new StringWriter();
            Console.SetOut(sw);  // Redirect Console output

            // Act
            manager.HandleRequest(query);  // Call the method

        }
    }
}

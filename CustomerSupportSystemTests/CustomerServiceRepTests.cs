using Xunit;
using CustomerSupportSystem;
using CustomerSupportSystem.Handlers;
using CustomerSupportSystem.Models;

namespace CustomerSupportSystemTests
{
    public class CustomerServiceRepTests
    {
        [Fact]
        public void HandleRequest_ShouldHandleBasicQuery()
        {
            // Arrange
            var customerServiceRep = new CustomerServiceRep();
            var query = new Query(Query.ComplexityLevel.Basic, "Password reset request");
            var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            customerServiceRep.HandleRequest(query);
        }
    }
}

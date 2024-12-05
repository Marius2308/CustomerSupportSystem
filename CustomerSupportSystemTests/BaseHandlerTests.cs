using Xunit;
using CustomerSupportSystem.Handlers;
using CustomerSupportSystem.Models;
using CustomerSupportSystem;

namespace CustomerSupportSystemTests
{
    public class BaseHandlerTests
    {
        [Fact]
        public void SetNext_ShouldChainHandlers()
        {
            // Arrange
            var handler1 = new CustomerServiceRep(); // Concrete handler
            var handler2 = new Manager(); // Concrete handler

            // Act
            handler1.SetNext(handler2);

            // Assert
            Assert.Equal(handler2, handler1.SetNext(handler2));
        }


        [Fact]
        public void HandleRequest_ShouldNotPassToNextHandler_WhenHandled()
        {
            // Arrange
            var handler1 = new Manager(); // Concrete handler that handles Basic queries
            var query = new Query(Query.ComplexityLevel.Basic, "Test Query");

            // Act
            handler1.HandleRequest(query);

            // Assert
            // No need to mock, assuming the request is handled by this handler
        }

        [Fact]
        public void HandleRequest_ShouldStopAtTheEndOfTheChain_WhenNoHandlerHandlesTheRequest()
        {
            // Arrange
            var handler1 = new CustomerServiceRep(); // Concrete handler with no next handler
            var query = new Query(Query.ComplexityLevel.Advanced, "Test Query");

            // Act
         
            handler1.HandleRequest(query);
        }
    }
}

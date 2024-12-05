using CustomerSupportSystem.Models;
using Xunit;

namespace CustomerSupportSystemTests
{
    public class QueryTests
    {
        [Fact]
        public void ToString_ShouldReturnFormattedString()
        {
            var query = new Query(Query.ComplexityLevel.Intermediate, "Billing issue");
            var result = query.ToString();
            Assert.Contains("Billing issue (Complexity: Intermediate)", result);
        }
    }
}
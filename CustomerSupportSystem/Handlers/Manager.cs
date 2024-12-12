using CustomerSupportSystem.Models;  // Add this to resolve Query
using CustomerSupportSystem.Handlers; // Add this to resolve BaseHandler

namespace CustomerSupportSystem
{
    public class Manager : BaseHandler
    {
        public override void HandleRequest(Query query)
        {
            if (query.Complexity == Query.ComplexityLevel.Intermediate)
            {
                Console.WriteLine($"Manager handled the query: {query}");
            }
            else
            {
                base.HandleRequest(query); // Pass to the next handler
            }
        }
    }
}

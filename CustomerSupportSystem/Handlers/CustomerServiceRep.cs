using CustomerSupportSystem.Models;
using CustomerSupportSystem.Handlers;

namespace CustomerSupportSystem
{
    public class CustomerServiceRep : BaseHandler
    {
        public override void HandleRequest(Query query)
        {
            if (query.Complexity == Query.ComplexityLevel.Basic)
            {
                Console.WriteLine($"Customer Service Rep handled the query: {query}");
            }
            else
            {
                base.HandleRequest(query); // Pass to the next handler
            }
        }
    }
}

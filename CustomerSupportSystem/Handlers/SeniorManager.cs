using CustomerSupportSystem.Models;  // Add this to resolve Query

namespace CustomerSupportSystem.Handlers
{
    public class SeniorManager : BaseHandler
    {
        public override void HandleRequest(Query query)
        {
            if (query.Complexity == Query.ComplexityLevel.Advanced)
            {
                Console.WriteLine($"Senior Manager handled the query: {query}");
            }
        }
    }

}

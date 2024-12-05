using CustomerSupportSystem.Handlers;  // For handler classes
using CustomerSupportSystem.Models;    // For the Query class

namespace CustomerSupportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerRep = new CustomerServiceRep();
            var manager = new Manager();
            var seniorManager = new SeniorManager();

            customerRep.SetNext(manager).SetNext(seniorManager);

            var queries = new[]
            {
                new Query(Query.ComplexityLevel.Basic, "Password reset request"),
                new Query(Query.ComplexityLevel.Intermediate, "Billing discrepancy"),
                new Query(Query.ComplexityLevel.Advanced, "System outage"),
            };

            Console.WriteLine("Handling Queries:");
            foreach (var query in queries)
            {
                customerRep.HandleRequest(query);
            }
                Console.WriteLine();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}

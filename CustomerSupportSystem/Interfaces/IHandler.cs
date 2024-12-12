using CustomerSupportSystem.Models;  // For Query class

namespace CustomerSupportSystem
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void HandleRequest(Query query);
    }
}

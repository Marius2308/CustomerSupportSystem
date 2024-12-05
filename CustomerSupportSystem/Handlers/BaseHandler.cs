using CustomerSupportSystem.Models;
using System;

namespace CustomerSupportSystem.Handlers
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void HandleRequest(Query query)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(query); // Passing the query to the next handler
            }
        }
    }
}

// The default chaining behavior can be implemented inside a base handler
// class.
namespace ChainOfCommandBank
{

    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            // Returning a handler from here will let us link handlers in a
            // convenient way like this:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object withdrawal)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(withdrawal);
            }
            else
            {
                return null;
            }
        }
    }
}
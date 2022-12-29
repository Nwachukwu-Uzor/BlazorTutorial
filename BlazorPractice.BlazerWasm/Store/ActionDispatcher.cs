using BlazorPractice.BlazerWasm.Store.Contracts;

namespace BlazorPractice.BlazerWasm.Store
{
 
    public class ActionDispatcher : IActionDispatcher
    {
        public Action<IAction> _registeredActionHandlers;

        public void Subscribe(Action<IAction> actionHandler)
        {
            _registeredActionHandlers += actionHandler;
        }
        public void Unsubscribe(Action<IAction> actionHandler)
        {
            _registeredActionHandlers -= actionHandler;
        }

        public void Dispatch(IAction action)
        {
            _registeredActionHandlers?.Invoke(action);
        }
    }
}

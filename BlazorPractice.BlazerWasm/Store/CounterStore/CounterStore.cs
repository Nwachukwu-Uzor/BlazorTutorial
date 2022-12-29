using BlazorPractice.BlazerWasm.Store.Contracts;

namespace BlazorPractice.BlazerWasm.Store.CounterStore
{
    public class CounterStore
    {
        private CounterState _state;
        private readonly IActionDispatcher _actionDispatcher;

        public CounterStore(IActionDispatcher actionDispatcher)
        {
            _state = new CounterState(0);
            _actionDispatcher = actionDispatcher;
            _actionDispatcher.Subscribe(ActionHandler);
        }
        public CounterState GetState() => _state;

        private void Increment()
        {
            var count = _state.Count;
            count++;
            _state = new CounterState(count);
            BroadcastChanges();
        }

        private void Decrement()
        {
            var count = _state.Count;
            count--;
            _state = new CounterState(count);
            BroadcastChanges();
        }

        private void ActionHandler(IAction action)
        {
            switch(action.Name)
            {
                case IncrementAction.INCREMENT:
                    Increment();
                    break;
                case DecrementAction.DECREMENT:
                    Decrement();
                    break;
                default:
                    break;

            }
        }

        #region observer patter
        private Action _listeners;
        public void AddStateChangeListener(Action listener)
        {
            _listeners += listener;
        } 
        public void RemoveStateChangeListener(Action listener)
        {
            _listeners -= listener;
        }

        private void BroadcastChanges()
        {
            _listeners.Invoke();
        }
        #endregion
    }
}

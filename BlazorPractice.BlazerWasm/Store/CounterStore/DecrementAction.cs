using BlazorPractice.BlazerWasm.Store.Contracts;

namespace BlazorPractice.BlazerWasm.Store.CounterStore
{
    public class DecrementAction : IAction
    {
        public const string DECREMENT = "DECREMENT";
        public string Name => DECREMENT;
    }
}

using BlazorPractice.BlazerWasm.Store.Contracts;

namespace BlazorPractice.BlazerWasm.Store.CounterStore
{
    public class IncrementAction : IAction
    {
        public const string INCREMENT = "INCREMENT";
        public string Name => INCREMENT;
    }
}

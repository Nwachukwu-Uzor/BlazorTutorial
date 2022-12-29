namespace BlazorPractice.BlazerWasm.Store.CounterStore
{
    public class CounterState
    {
        public int Count { get; private set; }
        public CounterState(int count)
        {
            Count = count;
        }
    }
}

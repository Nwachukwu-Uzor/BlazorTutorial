using Microsoft.AspNetCore.Components;

namespace BlazorPractice.BlazerWasm.BaseComponents
{
    public class DateTimeBaseComponent : ComponentBase
    {
        public DateTime CurrentDateTime { get; set; }
        public DateTimeBaseComponent()
        {
            CurrentDateTime = DateTime.Now;
        }
    }
}

using BlazorPractice.BlazerWasm;
using BlazorPractice.BlazerWasm.Contracts;
using BlazorPractice.BlazerWasm.Services;
using BlazorPractice.BlazerWasm.Store.Contracts;
using BlazorPractice.BlazerWasm.Store;
using BlazorPractice.BlazerWasm.Store.CounterStore;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<CounterStore>();
builder.Services.AddScoped<IActionDispatcher, ActionDispatcher>();

await builder.Build().RunAsync();

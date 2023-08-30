# SimpleWasmConsole
A simple wrapper around the browser based `console` api.

## How to Install
- Add via [nuget](https://www.nuget.org/packages/SimpleWasmConsole)
- Add `@using SimpleWasmConsole` to the `_Imports.razor` file in your `Client` project
- Call `builder.Services.AddSimpleConsole();` within your `Program.cs` in your `Client` project

## How to Use
- `Inject` the service at the top of your component or page: `@inject ISimpleWasmConsole _console`
- Invoke the needed console command: `await _console.LogAsync("Logging", object)`
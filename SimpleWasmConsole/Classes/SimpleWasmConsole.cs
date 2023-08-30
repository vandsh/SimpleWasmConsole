using Microsoft.JSInterop;
using SimpleWasmConsole.Interfaces;

namespace SimpleWasmConsole.Classes
{
    public class SimpleWasmConsole : ISimpleWasmConsole
    {
        private IJSRuntime _js { get; set; }

        public SimpleWasmConsole(IJSRuntime js)
        {
            _js = js;
        }

        /// <summary>
        /// Calls "console.log" on the client passing the args along with it.
        /// </summary>
        /// <example>
        /// LogAsync("data") //same as console.log('data')
        /// </example>
        /// <example>
        /// LogAsync("data", myData) //same as console.log('data', myData)
        /// </example>
        /// <param name="js"></param>
        /// <param name="args"></param>
        public async Task LogAsync(params object?[]? args)
        {
            await _js.InvokeVoidAsync("console.log", args);
        }

        /// <summary>
        /// Calls "console.warn" on the client passing the args along with it.
        /// </summary>
        /// <example>
        /// LogAsync("data") //same as console.warn('data')
        /// </example>
        /// <example>
        /// LogAsync("data", myData) //same as console.warn('data', myData)
        /// </example>
        /// <param name="js"></param>
        /// <param name="args"></param>
        public async Task WarnAsync(params object?[]? args)
        {
            await _js.InvokeVoidAsync("console.warn", args);
        }

        /// <summary>
        /// Calls "console.debug" on the client passing the args along with it.
        /// </summary>
        /// <example>
        /// LogAsync("data") //same as console.debug('data')
        /// </example>
        /// <example>
        /// LogAsync("data", myData) //same as console.debug('data', myData)
        /// </example>
        /// <param name="js"></param>
        /// <param name="args"></param>
        public async Task DebugAsync(params object?[]? args)
        {
            await _js.InvokeVoidAsync("console.debug", args);
        }

        /// <summary>
        /// Calls "console.dir" on the client passing the args along with it.
        /// </summary>
        /// <example>
        /// LogAsync("data") //same as console.dir('data')
        /// </example>
        /// <example>
        /// LogAsync("data", myData) //same as console.dir('data', myData)
        /// </example>
        /// <param name="js"></param>
        /// <param name="args"></param>
        public async Task DirAsync(object obj)
        {
            await _js.InvokeVoidAsync("console.dir", obj);
        }

        /// <summary>
        /// Calls "console.error" on the client passing the args along with it.
        /// </summary>
        /// <example>
        /// LogAsync("data") //same as console.error('data')
        /// </example>
        /// <example>
        /// LogAsync("data", myData) //same as console.error('data', myData)
        /// </example>
        /// <param name="js"></param>
        /// <param name="args"></param>
        public async Task ErrorAsync(params object?[]? args)
        {
            await _js.InvokeVoidAsync("console.error", args);
        }

        /// <summary>
        /// Calls "console.info" on the client passing the args along with it.
        /// </summary>
        /// <example>
        /// LogAsync("data") //same as console.info('data')
        /// </example>
        /// <example>
        /// LogAsync("data", myData) //same as console.info('data', myData)
        /// </example>
        /// <param name="js"></param>
        /// <param name="args"></param>
        public async Task InfoAsync(params object?[]? args)
        {
            await _js.InvokeVoidAsync("console.info", args);
        }

        /// <summary>
        /// Calls "console.clear" on the client
        /// </summary>
        /// <returns></returns>
        public async Task ClearAsync()
        {
            await _js.InvokeVoidAsync("console.clear");
        }

        /// <summary>
        /// Calls "console.time" on the client
        /// </summary>
        /// <returns></returns>
        public async Task TimeAsync()
        {
            await _js.InvokeVoidAsync("console.time");
        }

        /// <summary>
        /// Calls "console.timeLog" on the client
        /// </summary>
        /// <returns></returns>
        public async Task TimeLogAsync()
        {
            await _js.InvokeVoidAsync("console.timeLog");
        }

        /// <summary>
        /// Calls "console.trace" on the client
        /// </summary>
        /// <returns></returns>
        public async Task TraceAsync()
        {
            await _js.InvokeVoidAsync("console.trace");
        }

        /// <summary>
        /// Calls "console.timeEnd" on the client
        /// </summary>
        /// <returns></returns>
        public async Task TimeEndAsync()
        {
            await _js.InvokeVoidAsync("console.timeEnd");
        }

        /// <summary>
        /// Calls "console.count" on the client
        /// </summary>
        /// <returns></returns>
        public async Task CountAsync()
        {
            await _js.InvokeVoidAsync("console.count");
        }

        /// <summary>
        /// Calls "console.table" on the client passing the args along with it.
        /// </summary>
        /// <example>
        /// TableAsync(myData) //same as console.table(data)
        /// </example>
        /// <example>
        /// TableAsync(myData, new []{"firstName", "lastName"}) //same as console.table(myData, ["firstName", "lastName"])
        /// </example>
        /// <param name="js"></param>
        /// <param name="o"></param>
        /// <param name="fields"></param>
        public async Task TableAsync(object? o, string[]? fields = null)
        {
            await _js.InvokeVoidAsync("console.table", o, fields);
        }
    }
}


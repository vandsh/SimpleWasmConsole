namespace SimpleWasmConsole.Interfaces
{
    public interface ISimpleWasmConsole
    {
        /// <summary>
        /// Calls "console.clear" on the client to clear the console log output
        /// </summary>
        /// <returns></returns>
        Task ClearAsync();

        /// <summary>
        /// Calls "console.count" on the client
        /// </summary>
        /// <returns></returns>
        Task CountAsync();

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
        Task DebugAsync(params object?[]? args);

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
        Task DirAsync(object obj);

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
        Task ErrorAsync(params object?[]? args);

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
        Task InfoAsync(params object?[]? args);

        /// <summary>
        /// Calls "console.timeLog" on the client
        /// </summary>
        /// <returns></returns>
        Task LogAsync(params object?[]? args);

        /// <summary>
        /// Calls "console.table" on the client passing the args along with it. Make sure to use lowerCamelCasing when supplying the fields
        /// </summary>
        /// <example>
        /// TableAsync(data) //same as console.table(data)
        /// </example>
        /// <example>
        /// TableAsync(data, new []{"firstColumn", "secondColumn"}) //same as console.table(myData, ["firstColumn", "secondColumn"])
        /// </example>
        /// <param name="js"></param>
        /// <param name="o"></param>
        /// <param name="fields"></param>
        Task TableAsync(object? o, string[]? fields = null);

        /// <summary>
        /// Calls "console.time" on the client, starting a timer. Call TimerEnd to stop timer and TimeLog to output.
        /// </summary>
        /// <returns></returns>
        Task TimeAsync();

        /// <summary>
        /// Calls "console.timeEnd" on the client
        /// </summary>
        /// <returns></returns>
        Task TimeEndAsync();

        /// <summary>
        /// Calls "console.timeLog" on the client, printing out the time since the timer start
        /// </summary>
        /// <returns></returns>
        Task TimeLogAsync();

        /// <summary>
        /// Calls "console.trace" on the client
        /// </summary>
        /// <returns></returns>
        Task TraceAsync();

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
        Task WarnAsync(params object?[]? args);
    }
}
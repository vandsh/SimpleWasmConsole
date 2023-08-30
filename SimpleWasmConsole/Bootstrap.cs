using System;
using Microsoft.Extensions.DependencyInjection;
using SimpleWasmConsole.Interfaces;
using swc = SimpleWasmConsole.Classes.SimpleWasmConsole;

namespace SimpleConsole
{
	public static class Bootstrap
	{
		public static IServiceCollection AddSimpleConsole(this IServiceCollection serviceCollection) {
            serviceCollection.AddSingleton(typeof(ISimpleWasmConsole), typeof(swc));
			return serviceCollection;
		}
	}
}


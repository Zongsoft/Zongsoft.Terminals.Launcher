using System;
using System.Collections.Generic;

namespace Zongsoft.Terminals.Launcher
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Zongsoft.Plugins.Application.Start(Zongsoft.Plugins.Terminals.ApplicationContext.Current, args);
		}
	}
}

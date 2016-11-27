using System;
using System.Collections.Generic;

namespace Zongsoft.Terminals.Launcher
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Zongsoft.Plugins.Application.Started += Application_Started;
			Zongsoft.Plugins.Application.Start(Zongsoft.Terminals.Plugins.ApplicationContext.Current, args);
		}

		static void Application_Started(object sender, Zongsoft.Plugins.ApplicationEventArgs e)
		{
			System.Threading.Tasks.Parallel.For(0, 10, i =>
			{
				Zongsoft.Diagnostics.Logger.Error(i.ToString());
			});

			try
			{
				Zongsoft.Diagnostics.Logger.Trace("这是一条 Trace 的消息文本。");
				Zongsoft.Diagnostics.Logger.Debug("这是一条 Debug 的消息文本。", new Dictionary<string, object>()
				{
					{ "Key1", "Value 1" },
					{ "Key2", DateTime.Now },
					{ "Key3", Zongsoft.Common.RandomGenerator.GenerateInt64() },
					{ "Key4", Guid.NewGuid() },
					{ "Key5", Zongsoft.Common.RandomGenerator.Generate(128) },
				});

				Zongsoft.Diagnostics.Logger.Info("这是一条 Info 的消息文本。", Zongsoft.Common.RandomGenerator.Generate(128));
				Zongsoft.Diagnostics.Logger.Warn("这是一条 Warn 的消息文本。", Zongsoft.Common.RandomGenerator.Generate(128));

				Test1();
			}
			catch(Exception ex)
			{
				Zongsoft.Diagnostics.Logger.Error(ex, System.Threading.Thread.CurrentPrincipal);
			}
		}

		static void Test1()
		{
			Test2();
		}

		static void Test2()
		{
			Test3();
		}

		static void Test3()
		{
			throw new InvalidOperationException("故意抛出的异常！");
		}
	}
}

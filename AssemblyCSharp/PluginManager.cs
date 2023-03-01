using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AssemblyCSharp
{
	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	public class PluginManager
	{
		// Token: 0x0600151D RID: 5405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x2CB55A0", Offset = "0x2CB45A0", VA = "0x182CB55A0")]
		public PluginManager()
		{
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000310")]
		public Plugin[] Plugins
		{
			[Token(Token = "0x600151E")]
			[Address(RVA = "0x2CB5700", Offset = "0x2CB4700", VA = "0x182CB5700")]
			get
			{
				return null;
			}
		}

		// Token: 0x040015B2 RID: 5554
		[Token(Token = "0x40015B2")]
		private const string _dir = "Plugins";

		// Token: 0x040015B3 RID: 5555
		[Token(Token = "0x40015B3")]
		[FieldOffset(Offset = "0x10")]
		private Stack<Plugin> _plugins;
	}
}

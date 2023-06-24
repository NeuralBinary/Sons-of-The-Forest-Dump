using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AssemblyCSharp
{
	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000352")]
	public class PluginManager
	{
		// Token: 0x06001548 RID: 5448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001548")]
		[Address(RVA = "0x326E500", Offset = "0x326CB00", VA = "0x18326E500")]
		public PluginManager()
		{
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000318")]
		public Plugin[] Plugins
		{
			[Token(Token = "0x6001549")]
			[Address(RVA = "0x326E6E0", Offset = "0x326CCE0", VA = "0x18326E6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040015D0 RID: 5584
		[Token(Token = "0x40015D0")]
		private const string _dir = "Plugins";

		// Token: 0x040015D1 RID: 5585
		[Token(Token = "0x40015D1")]
		[FieldOffset(Offset = "0x10")]
		private Stack<Plugin> _plugins;
	}
}

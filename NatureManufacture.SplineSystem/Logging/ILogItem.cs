using System;
using Il2CppDummyDll;

namespace TriangleNet.Logging
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public interface ILogItem
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002E6 RID: 742
		[Token(Token = "0x17000082")]
		DateTime Time { [Token(Token = "0x60002E6")] get; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002E7 RID: 743
		[Token(Token = "0x17000083")]
		LogLevel Level { [Token(Token = "0x60002E7")] get; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002E8 RID: 744
		[Token(Token = "0x17000084")]
		string Message { [Token(Token = "0x60002E8")] get; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002E9 RID: 745
		[Token(Token = "0x17000085")]
		string Info { [Token(Token = "0x60002E9")] get; }
	}
}

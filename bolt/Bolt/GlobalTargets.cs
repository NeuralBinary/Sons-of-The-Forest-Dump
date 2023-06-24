using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	[Documentation]
	public enum GlobalTargets : byte
	{
		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		Everyone = 2,
		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		Others = 4,
		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		AllClients = 8,
		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		OnlyServer = 6,
		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		OnlySelf = 12
	}
}

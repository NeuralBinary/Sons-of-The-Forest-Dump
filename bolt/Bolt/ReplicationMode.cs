using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	internal enum ReplicationMode
	{
		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		EveryoneExceptController,
		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		Everyone,
		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		OnlyOwnerAndController,
		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		LocalForEachPlayer
	}
}

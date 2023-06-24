using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[Documentation]
	public enum EntityTargets : byte
	{
		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		Everyone = 1,
		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		EveryoneExceptController = 5,
		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		EveryoneExceptOwner = 3,
		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		EveryoneExceptOwnerAndController = 13,
		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		OnlyController = 7,
		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		OnlyOwner = 9,
		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		OnlySelf = 11
	}
}

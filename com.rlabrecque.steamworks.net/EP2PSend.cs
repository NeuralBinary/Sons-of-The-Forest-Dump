using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	public enum EP2PSend
	{
		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		k_EP2PSendUnreliable,
		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		k_EP2PSendUnreliableNoDelay,
		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		k_EP2PSendReliable,
		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		k_EP2PSendReliableWithBuffering
	}
}

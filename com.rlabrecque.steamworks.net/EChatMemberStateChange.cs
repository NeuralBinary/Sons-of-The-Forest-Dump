using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	[Flags]
	public enum EChatMemberStateChange
	{
		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		k_EChatMemberStateChangeEntered = 1,
		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		k_EChatMemberStateChangeLeft = 2,
		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		k_EChatMemberStateChangeDisconnected = 4,
		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		k_EChatMemberStateChangeKicked = 8,
		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		k_EChatMemberStateChangeBanned = 16
	}
}

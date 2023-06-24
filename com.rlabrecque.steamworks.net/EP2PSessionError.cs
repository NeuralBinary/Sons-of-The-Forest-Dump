using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	public enum EP2PSessionError
	{
		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		k_EP2PSessionErrorNone,
		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		k_EP2PSessionErrorNoRightsToApp = 2,
		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		k_EP2PSessionErrorTimeout = 4,
		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		k_EP2PSessionErrorNotRunningApp_DELETED = 1,
		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		k_EP2PSessionErrorDestinationNotLoggedIn_DELETED = 3,
		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		k_EP2PSessionErrorMax = 5
	}
}

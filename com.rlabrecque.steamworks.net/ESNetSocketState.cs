using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	public enum ESNetSocketState
	{
		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		k_ESNetSocketStateInvalid,
		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		k_ESNetSocketStateConnected,
		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		k_ESNetSocketStateInitiated = 10,
		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		k_ESNetSocketStateLocalCandidatesFound,
		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		k_ESNetSocketStateReceivedRemoteCandidates,
		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		k_ESNetSocketStateChallengeHandshake = 15,
		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		k_ESNetSocketStateDisconnecting = 21,
		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		k_ESNetSocketStateLocalDisconnect,
		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		k_ESNetSocketStateTimeoutDuringConnect,
		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		k_ESNetSocketStateRemoteEndDisconnected,
		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		k_ESNetSocketStateConnectionBroken
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001CE RID: 462
	[Token(Token = "0x20001CE")]
	[Serializable]
	public struct ISteamNetworkingSignalingRecvContext
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x000093A4 File Offset: 0x000075A4
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x955A70", Offset = "0x954070", VA = "0x180955A70")]
		public IntPtr OnConnectRequest(HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort)
		{
			return 0;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x955BD0", Offset = "0x9541D0", VA = "0x180955BD0")]
		public void SendRejectionSignal(ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg)
		{
		}
	}
}

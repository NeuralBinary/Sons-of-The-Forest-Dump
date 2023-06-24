using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	[Serializable]
	public struct ISteamNetworkingConnectionSignaling
	{
		// Token: 0x06000AA5 RID: 2725 RVA: 0x0000938C File Offset: 0x0000758C
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x955840", Offset = "0x953E40", VA = "0x180955840")]
		public bool SendSignal(HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg)
		{
			return default(bool);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x9559F0", Offset = "0x953FF0", VA = "0x1809559F0")]
		public void Release()
		{
		}
	}
}

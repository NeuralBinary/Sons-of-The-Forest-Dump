using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	[CallbackIdentity(1252)]
	public struct SteamNetworkingMessagesSessionFailed_t
	{
		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		public const int k_iCallback = 1252;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x0")]
		public SteamNetConnectionInfo_t m_info;
	}
}

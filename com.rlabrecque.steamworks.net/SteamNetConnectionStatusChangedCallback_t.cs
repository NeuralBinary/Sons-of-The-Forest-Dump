using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	[CallbackIdentity(1221)]
	public struct SteamNetConnectionStatusChangedCallback_t
	{
		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		public const int k_iCallback = 1221;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x0")]
		public HSteamNetConnection m_hConn;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x8")]
		public SteamNetConnectionInfo_t m_info;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x70")]
		public ESteamNetworkingConnectionState m_eOldState;
	}
}

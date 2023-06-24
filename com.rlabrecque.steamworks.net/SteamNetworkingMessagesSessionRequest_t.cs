using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[CallbackIdentity(1251)]
	public struct SteamNetworkingMessagesSessionRequest_t
	{
		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		public const int k_iCallback = 1251;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x0")]
		public SteamNetworkingIdentity m_identityRemote;
	}
}

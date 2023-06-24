using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[CallbackIdentity(503)]
	public struct LobbyInvite_t
	{
		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		public const int k_iCallback = 503;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDUser;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ulGameID;
	}
}

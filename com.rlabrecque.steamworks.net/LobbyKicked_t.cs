using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	[CallbackIdentity(512)]
	public struct LobbyKicked_t
	{
		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		public const int k_iCallback = 512;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDAdmin;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x10")]
		public byte m_bKickedDueToDisconnect;
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	public struct FriendGameInfo_t
	{
		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x0")]
		public CGameID m_gameID;

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		[FieldOffset(Offset = "0x8")]
		public uint m_unGameIP;

		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		[FieldOffset(Offset = "0xC")]
		public ushort m_usGamePort;

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0xE")]
		public ushort m_usQueryPort;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID m_steamIDLobby;
	}
}

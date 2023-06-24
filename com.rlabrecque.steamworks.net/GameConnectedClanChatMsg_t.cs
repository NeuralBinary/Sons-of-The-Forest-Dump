using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[CallbackIdentity(338)]
	public struct GameConnectedClanChatMsg_t
	{
		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		public const int k_iCallback = 338;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x10")]
		public int m_iMessageID;
	}
}

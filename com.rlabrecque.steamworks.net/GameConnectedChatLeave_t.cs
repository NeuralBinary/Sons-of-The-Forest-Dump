using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[CallbackIdentity(340)]
	public struct GameConnectedChatLeave_t
	{
		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		public const int k_iCallback = 340;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bKicked;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x11")]
		public bool m_bDropped;
	}
}

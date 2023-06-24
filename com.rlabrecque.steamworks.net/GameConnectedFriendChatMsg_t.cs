using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[CallbackIdentity(343)]
	public struct GameConnectedFriendChatMsg_t
	{
		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		public const int k_iCallback = 343;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x8")]
		public int m_iMessageID;
	}
}

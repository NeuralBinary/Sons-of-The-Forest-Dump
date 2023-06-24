using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[CallbackIdentity(339)]
	public struct GameConnectedChatJoin_t
	{
		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		public const int k_iCallback = 339;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;
	}
}

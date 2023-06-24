using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[CallbackIdentity(333)]
	public struct GameLobbyJoinRequested_t
	{
		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		public const int k_iCallback = 333;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDLobby;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDFriend;
	}
}

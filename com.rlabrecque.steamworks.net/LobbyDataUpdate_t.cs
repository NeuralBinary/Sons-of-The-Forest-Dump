using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	[CallbackIdentity(505)]
	public struct LobbyDataUpdate_t
	{
		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		public const int k_iCallback = 505;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDMember;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x10")]
		public byte m_bSuccess;
	}
}

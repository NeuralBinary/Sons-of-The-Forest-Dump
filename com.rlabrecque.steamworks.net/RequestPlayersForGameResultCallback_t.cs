using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	[CallbackIdentity(5212)]
	public struct RequestPlayersForGameResultCallback_t
	{
		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		public const int k_iCallback = 5212;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ullSearchID;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDPlayerFound;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x18")]
		public CSteamID m_SteamIDLobby;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAcceptState_t m_ePlayerAcceptState;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x24")]
		public int m_nPlayerIndex;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x28")]
		public int m_nTotalPlayersFound;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x2C")]
		public int m_nTotalPlayersAcceptedGame;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x30")]
		public int m_nSuggestedTeamIndex;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x38")]
		public ulong m_ullUniqueGameID;
	}
}

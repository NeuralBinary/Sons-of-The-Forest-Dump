using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[CallbackIdentity(5202)]
	public struct SearchForGameResultCallback_t
	{
		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		public const int k_iCallback = 5202;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ullSearchID;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0xC")]
		public int m_nCountPlayersInGame;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x10")]
		public int m_nCountAcceptedGame;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x14")]
		public CSteamID m_steamIDHost;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x1C")]
		public bool m_bFinalCallback;
	}
}

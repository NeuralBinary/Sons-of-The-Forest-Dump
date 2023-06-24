using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public struct LeaderboardEntry_t
	{
		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x8")]
		public int m_nGlobalRank;

		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		[FieldOffset(Offset = "0xC")]
		public int m_nScore;

		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x40009BE")]
		[FieldOffset(Offset = "0x10")]
		public int m_cDetails;

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		[FieldOffset(Offset = "0x18")]
		public UGCHandle_t m_hUGC;
	}
}

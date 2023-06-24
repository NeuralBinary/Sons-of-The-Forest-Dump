using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	[CallbackIdentity(1106)]
	public struct LeaderboardScoreUploaded_t
	{
		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		public const int k_iCallback = 1106;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x10")]
		public int m_nScore;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x14")]
		public byte m_bScoreChanged;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x18")]
		public int m_nGlobalRankNew;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x1C")]
		public int m_nGlobalRankPrevious;
	}
}

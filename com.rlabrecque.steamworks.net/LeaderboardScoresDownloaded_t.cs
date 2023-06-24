using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	[CallbackIdentity(1105)]
	public struct LeaderboardScoresDownloaded_t
	{
		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		public const int k_iCallback = 1105;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x8")]
		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x10")]
		public int m_cEntryCount;
	}
}

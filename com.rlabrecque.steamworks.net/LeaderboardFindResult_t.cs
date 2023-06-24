using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	[CallbackIdentity(1104)]
	public struct LeaderboardFindResult_t
	{
		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		public const int k_iCallback = 1104;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x8")]
		public byte m_bLeaderboardFound;
	}
}

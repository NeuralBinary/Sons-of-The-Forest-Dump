using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	[CallbackIdentity(1111)]
	public struct LeaderboardUGCSet_t
	{
		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		public const int k_iCallback = 1111;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
}

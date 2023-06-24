using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	[CallbackIdentity(5201)]
	public struct SearchForGameProgressCallback_t
	{
		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		public const int k_iCallback = 5201;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ullSearchID;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xC")]
		public CSteamID m_lobbyID;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x14")]
		public CSteamID m_steamIDEndedSearch;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x1C")]
		public int m_nSecondsRemainingEstimate;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x20")]
		public int m_cPlayersSearching;
	}
}

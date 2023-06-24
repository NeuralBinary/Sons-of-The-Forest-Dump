using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[CallbackIdentity(211)]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		public const int k_iCallback = 211;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x4")]
		public int m_cPlayersThatDontLikeCandidate;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x8")]
		public int m_cPlayersThatCandidateDoesntLike;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0xC")]
		public int m_cClanPlayersThatDontLikeCandidate;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDCandidate;
	}
}

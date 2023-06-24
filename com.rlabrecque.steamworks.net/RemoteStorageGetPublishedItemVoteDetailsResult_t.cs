using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	[CallbackIdentity(1320)]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		public const int k_iCallback = 1320;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_unPublishedFileId;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x10")]
		public int m_nVotesFor;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x14")]
		public int m_nVotesAgainst;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x18")]
		public int m_nReports;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x1C")]
		public float m_fScore;
	}
}

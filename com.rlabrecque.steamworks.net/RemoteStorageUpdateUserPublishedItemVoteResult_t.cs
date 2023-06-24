using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	[CallbackIdentity(1324)]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		public const int k_iCallback = 1324;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}

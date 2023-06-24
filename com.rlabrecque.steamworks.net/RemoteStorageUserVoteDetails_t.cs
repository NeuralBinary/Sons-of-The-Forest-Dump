using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[CallbackIdentity(1325)]
	public struct RemoteStorageUserVoteDetails_t
	{
		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		public const int k_iCallback = 1325;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x10")]
		public EWorkshopVote m_eVote;
	}
}

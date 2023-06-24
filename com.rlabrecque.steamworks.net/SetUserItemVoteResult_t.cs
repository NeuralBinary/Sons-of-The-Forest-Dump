using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[CallbackIdentity(3408)]
	public struct SetUserItemVoteResult_t
	{
		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		public const int k_iCallback = 3408;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bVoteUp;
	}
}

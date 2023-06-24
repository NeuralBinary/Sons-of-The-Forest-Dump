using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	[CallbackIdentity(3409)]
	public struct GetUserItemVoteResult_t
	{
		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		public const int k_iCallback = 3409;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bVotedUp;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0xD")]
		public bool m_bVotedDown;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0xE")]
		public bool m_bVoteSkipped;
	}
}

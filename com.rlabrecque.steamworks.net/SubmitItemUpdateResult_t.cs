using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	[CallbackIdentity(3404)]
	public struct SubmitItemUpdateResult_t
	{
		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		public const int k_iCallback = 3404;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x4")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	[CallbackIdentity(3403)]
	public struct CreateItemResult_t
	{
		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		public const int k_iCallback = 3403;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}

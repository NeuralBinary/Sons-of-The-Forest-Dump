using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	[CallbackIdentity(1316)]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		public const int k_iCallback = 1316;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}

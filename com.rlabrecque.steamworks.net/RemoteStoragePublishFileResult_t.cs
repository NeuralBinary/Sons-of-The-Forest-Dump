using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	[CallbackIdentity(1309)]
	public struct RemoteStoragePublishFileResult_t
	{
		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		public const int k_iCallback = 1309;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	[CallbackIdentity(1313)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		public const int k_iCallback = 1313;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}

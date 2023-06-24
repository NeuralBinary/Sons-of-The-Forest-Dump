using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[CallbackIdentity(1311)]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		public const int k_iCallback = 1311;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}

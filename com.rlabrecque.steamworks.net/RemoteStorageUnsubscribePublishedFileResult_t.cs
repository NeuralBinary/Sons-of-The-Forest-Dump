using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	[CallbackIdentity(1315)]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		public const int k_iCallback = 1315;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}

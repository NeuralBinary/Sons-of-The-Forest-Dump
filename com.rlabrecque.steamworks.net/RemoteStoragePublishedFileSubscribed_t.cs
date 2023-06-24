using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	[CallbackIdentity(1321)]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		public const int k_iCallback = 1321;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
}

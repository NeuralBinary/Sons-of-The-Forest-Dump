using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	[CallbackIdentity(1322)]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		public const int k_iCallback = 1322;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
}

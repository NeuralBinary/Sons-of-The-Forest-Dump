using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	[CallbackIdentity(1323)]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		public const int k_iCallback = 1323;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	[CallbackIdentity(3406)]
	public struct DownloadItemResult_t
	{
		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		public const int k_iCallback = 3406;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x10")]
		public EResult m_eResult;
	}
}

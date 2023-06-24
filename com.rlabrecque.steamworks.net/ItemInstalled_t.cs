using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	[CallbackIdentity(3405)]
	public struct ItemInstalled_t
	{
		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		public const int k_iCallback = 3405;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	[CallbackIdentity(1314)]
	public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
	{
		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		public const int k_iCallback = 1314;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x18")]
		public uint[] m_rgRTimeSubscribed;
	}
}

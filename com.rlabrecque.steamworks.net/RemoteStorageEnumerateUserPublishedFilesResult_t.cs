using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	[CallbackIdentity(1312)]
	public struct RemoteStorageEnumerateUserPublishedFilesResult_t
	{
		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		public const int k_iCallback = 1312;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
}

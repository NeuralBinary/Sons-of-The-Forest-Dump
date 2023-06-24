using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[CallbackIdentity(1326)]
	public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		public const int k_iCallback = 1326;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
}

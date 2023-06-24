using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	[CallbackIdentity(1328)]
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
	{
		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		public const int k_iCallback = 1328;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x4")]
		public EWorkshopFileAction m_eAction;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x8")]
		public int m_nResultsReturned;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0xC")]
		public int m_nTotalResultCount;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x18")]
		public uint[] m_rgRTimeUpdated;
	}
}

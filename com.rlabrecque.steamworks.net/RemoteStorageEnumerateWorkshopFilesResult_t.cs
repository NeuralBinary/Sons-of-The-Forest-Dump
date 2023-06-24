using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	[CallbackIdentity(1319)]
	public struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		public const int k_iCallback = 1319;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x18")]
		public float[] m_rgScore;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x20")]
		public AppId_t m_nAppId;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x24")]
		public uint m_unStartIndex;
	}
}

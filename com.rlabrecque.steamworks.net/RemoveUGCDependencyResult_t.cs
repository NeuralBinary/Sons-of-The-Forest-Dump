using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[CallbackIdentity(3413)]
	public struct RemoveUGCDependencyResult_t
	{
		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		public const int k_iCallback = 3413;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}

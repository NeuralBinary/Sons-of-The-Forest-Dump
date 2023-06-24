using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[CallbackIdentity(3415)]
	public struct RemoveAppDependencyResult_t
	{
		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		public const int k_iCallback = 3415;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[CallbackIdentity(3414)]
	public struct AddAppDependencyResult_t
	{
		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		public const int k_iCallback = 3414;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;
	}
}

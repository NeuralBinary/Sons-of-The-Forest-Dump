using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	[CallbackIdentity(3417)]
	public struct DeleteItemResult_t
	{
		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		public const int k_iCallback = 3417;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}

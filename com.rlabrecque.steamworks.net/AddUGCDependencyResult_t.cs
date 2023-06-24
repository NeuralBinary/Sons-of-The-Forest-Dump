using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	[CallbackIdentity(3412)]
	public struct AddUGCDependencyResult_t
	{
		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		public const int k_iCallback = 3412;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}

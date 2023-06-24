using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	[CallbackIdentity(1327)]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		public const int k_iCallback = 1327;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x10")]
		public EWorkshopFileAction m_eAction;
	}
}

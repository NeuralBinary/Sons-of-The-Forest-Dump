using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	[CallbackIdentity(3407)]
	public struct UserFavoriteItemsListChanged_t
	{
		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		public const int k_iCallback = 3407;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bWasAddRequest;
	}
}

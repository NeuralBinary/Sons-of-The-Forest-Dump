using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[CallbackIdentity(1330)]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		public const int k_iCallback = 1330;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ulUnused;
	}
}

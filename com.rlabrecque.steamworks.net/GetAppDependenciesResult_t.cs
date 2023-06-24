using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[CallbackIdentity(3416)]
	public struct GetAppDependenciesResult_t
	{
		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		public const int k_iCallback = 3416;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t[] m_rgAppIDs;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x18")]
		public uint m_nNumAppDependencies;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x1C")]
		public uint m_nTotalNumAppDependencies;
	}
}

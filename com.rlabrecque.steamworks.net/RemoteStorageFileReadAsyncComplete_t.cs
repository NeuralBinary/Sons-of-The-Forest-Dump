using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	[CallbackIdentity(1332)]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		public const int k_iCallback = 1332;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hFileReadAsync;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0xC")]
		public uint m_nOffset;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x10")]
		public uint m_cubRead;
	}
}

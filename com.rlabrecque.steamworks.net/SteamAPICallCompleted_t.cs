using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	[CallbackIdentity(703)]
	public struct SteamAPICallCompleted_t
	{
		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		public const int k_iCallback = 703;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hAsyncCall;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x8")]
		public int m_iCallback;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0xC")]
		public uint m_cubParam;
	}
}

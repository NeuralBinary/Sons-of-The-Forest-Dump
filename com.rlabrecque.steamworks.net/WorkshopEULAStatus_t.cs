using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[CallbackIdentity(3420)]
	public struct WorkshopEULAStatus_t
	{
		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		public const int k_iCallback = 3420;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x4")]
		public AppId_t m_nAppID;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x8")]
		public uint m_unVersion;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0xC")]
		public RTime32 m_rtAction;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bAccepted;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x11")]
		public bool m_bNeedsAction;
	}
}

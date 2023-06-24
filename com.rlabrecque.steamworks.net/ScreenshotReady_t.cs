using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	[CallbackIdentity(2301)]
	public struct ScreenshotReady_t
	{
		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		public const int k_iCallback = 2301;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x0")]
		public ScreenshotHandle m_hLocal;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
}

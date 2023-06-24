using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[CallbackIdentity(4525)]
	public struct HTML_UpdateToolTip_t
	{
		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		public const int k_iCallback = 4525;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
}

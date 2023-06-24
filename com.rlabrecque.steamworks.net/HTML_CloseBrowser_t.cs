using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[CallbackIdentity(4504)]
	public struct HTML_CloseBrowser_t
	{
		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		public const int k_iCallback = 4504;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[CallbackIdentity(4527)]
	public struct HTML_BrowserRestarted_t
	{
		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		public const int k_iCallback = 4527;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x4")]
		public HHTMLBrowser unOldBrowserHandle;
	}
}

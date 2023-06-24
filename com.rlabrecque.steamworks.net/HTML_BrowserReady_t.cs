using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[CallbackIdentity(4501)]
	public struct HTML_BrowserReady_t
	{
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		public const int k_iCallback = 4501;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
}

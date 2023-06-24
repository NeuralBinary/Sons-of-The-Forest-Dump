using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[CallbackIdentity(4515)]
	public struct HTML_JSConfirm_t
	{
		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		public const int k_iCallback = 4515;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x8")]
		public string pchMessage;
	}
}

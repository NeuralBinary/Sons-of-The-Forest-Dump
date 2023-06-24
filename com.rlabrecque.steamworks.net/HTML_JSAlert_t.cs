using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[CallbackIdentity(4514)]
	public struct HTML_JSAlert_t
	{
		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		public const int k_iCallback = 4514;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x8")]
		public string pchMessage;
	}
}

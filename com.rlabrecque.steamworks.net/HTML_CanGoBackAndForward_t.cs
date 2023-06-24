using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[CallbackIdentity(4510)]
	public struct HTML_CanGoBackAndForward_t
	{
		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		public const int k_iCallback = 4510;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x4")]
		public bool bCanGoBack;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x5")]
		public bool bCanGoForward;
	}
}

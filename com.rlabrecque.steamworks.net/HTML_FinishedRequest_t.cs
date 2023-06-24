using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[CallbackIdentity(4506)]
	public struct HTML_FinishedRequest_t
	{
		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		public const int k_iCallback = 4506;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x8")]
		public string pchURL;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x10")]
		public string pchPageTitle;
	}
}

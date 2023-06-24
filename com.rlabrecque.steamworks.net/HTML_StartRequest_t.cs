using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[CallbackIdentity(4503)]
	public struct HTML_StartRequest_t
	{
		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		public const int k_iCallback = 4503;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x8")]
		public string pchURL;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x10")]
		public string pchTarget;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x18")]
		public string pchPostData;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x20")]
		public bool bIsRedirect;
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[CallbackIdentity(4523)]
	public struct HTML_StatusText_t
	{
		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		public const int k_iCallback = 4523;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
}

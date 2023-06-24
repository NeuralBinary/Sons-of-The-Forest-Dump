using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[CallbackIdentity(4524)]
	public struct HTML_ShowToolTip_t
	{
		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		public const int k_iCallback = 4524;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
}

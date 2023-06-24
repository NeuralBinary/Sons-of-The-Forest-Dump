using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[CallbackIdentity(4508)]
	public struct HTML_ChangedTitle_t
	{
		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		public const int k_iCallback = 4508;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x8")]
		public string pchTitle;
	}
}

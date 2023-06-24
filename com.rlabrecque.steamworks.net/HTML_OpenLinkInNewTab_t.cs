using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[CallbackIdentity(4507)]
	public struct HTML_OpenLinkInNewTab_t
	{
		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		public const int k_iCallback = 4507;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x8")]
		public string pchURL;
	}
}

using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[CallbackIdentity(4526)]
	public struct HTML_HideToolTip_t
	{
		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		public const int k_iCallback = 4526;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
}

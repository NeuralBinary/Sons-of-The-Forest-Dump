using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[CallbackIdentity(4516)]
	public struct HTML_FileOpenDialog_t
	{
		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		public const int k_iCallback = 4516;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x8")]
		public string pchTitle;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x10")]
		public string pchInitialFile;
	}
}

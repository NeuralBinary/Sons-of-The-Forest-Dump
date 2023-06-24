using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[CallbackIdentity(4521)]
	public struct HTML_NewWindow_t
	{
		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		public const int k_iCallback = 4521;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x8")]
		public string pchURL;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x10")]
		public uint unX;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x14")]
		public uint unY;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x18")]
		public uint unWide;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x1C")]
		public uint unTall;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x20")]
		public HHTMLBrowser unNewWindow_BrowserHandle_IGNORE;
	}
}

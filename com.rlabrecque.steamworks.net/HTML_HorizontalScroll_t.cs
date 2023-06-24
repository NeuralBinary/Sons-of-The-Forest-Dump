using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[CallbackIdentity(4511)]
	public struct HTML_HorizontalScroll_t
	{
		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		public const int k_iCallback = 4511;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0xC")]
		public float flPageScale;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x10")]
		public bool bVisible;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
}

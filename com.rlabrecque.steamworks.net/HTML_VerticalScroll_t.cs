using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[CallbackIdentity(4512)]
	public struct HTML_VerticalScroll_t
	{
		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		public const int k_iCallback = 4512;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0xC")]
		public float flPageScale;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x10")]
		public bool bVisible;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
}

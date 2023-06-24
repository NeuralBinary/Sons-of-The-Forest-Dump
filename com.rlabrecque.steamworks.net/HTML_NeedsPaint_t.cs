using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[CallbackIdentity(4502)]
	public struct HTML_NeedsPaint_t
	{
		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		public const int k_iCallback = 4502;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr pBGRA;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x10")]
		public uint unWide;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x14")]
		public uint unTall;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x18")]
		public uint unUpdateX;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x1C")]
		public uint unUpdateY;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x20")]
		public uint unUpdateWide;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x24")]
		public uint unUpdateTall;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x28")]
		public uint unScrollX;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x2C")]
		public uint unScrollY;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x30")]
		public float flPageScale;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x34")]
		public uint unPageSerial;
	}
}

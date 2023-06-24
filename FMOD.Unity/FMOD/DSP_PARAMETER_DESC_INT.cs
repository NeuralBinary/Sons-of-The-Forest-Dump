using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public struct DSP_PARAMETER_DESC_INT
	{
		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x0")]
		public int min;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x4")]
		public int max;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x8")]
		public int defaultval;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0xC")]
		public bool goestoinf;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x10")]
		public IntPtr valuenames;
	}
}

using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x0")]
		public float min;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x4")]
		public float max;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x8")]
		public float defaultval;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x10")]
		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
}

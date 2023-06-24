using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x0")]
		public int numlisteners;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x8")]
		public ATTRIBUTES_3D[] relative;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x10")]
		public float[] weight;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x18")]
		public ATTRIBUTES_3D absolute;
	}
}

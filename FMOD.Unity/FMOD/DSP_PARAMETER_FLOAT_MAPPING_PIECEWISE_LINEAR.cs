using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x0")]
		public int numpoints;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr pointparamvalues;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x10")]
		public IntPtr pointpositions;
	}
}

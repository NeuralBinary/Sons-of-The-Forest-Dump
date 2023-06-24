using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public struct ComplexEndpoint2d
	{
		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x0")]
		public Vector2d v;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x10")]
		public bool isStart;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x18")]
		public PlanarComplex.SmoothCurveElement element;
	}
}

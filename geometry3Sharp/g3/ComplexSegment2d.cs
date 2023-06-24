using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	public struct ComplexSegment2d
	{
		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x0")]
		public Segment2d seg;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x28")]
		public bool isClosed;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x30")]
		public PlanarComplex.Element element;
	}
}

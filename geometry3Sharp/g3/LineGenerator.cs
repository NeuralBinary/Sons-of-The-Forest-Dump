using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	public class LineGenerator : CurveGenerator
	{
		// Token: 0x06000580 RID: 1408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1F98D20", Offset = "0x1F97320", VA = "0x181F98D20", Slot = "4")]
		public override void Generate()
		{
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1F99130", Offset = "0x1F97730", VA = "0x181F99130")]
		public LineGenerator()
		{
		}

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x20")]
		public Vector3d Start;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x38")]
		public Vector3d End;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x50")]
		public int Subdivisions;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x58")]
		public double StepSize;
	}
}

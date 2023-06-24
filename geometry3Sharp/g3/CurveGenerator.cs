using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	public abstract class CurveGenerator
	{
		// Token: 0x0600057D RID: 1405
		[Token(Token = "0x600057D")]
		public abstract void Generate();

		// Token: 0x0600057E RID: 1406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1F98B40", Offset = "0x1F97140", VA = "0x181F98B40")]
		public void Make(DCurve3 c)
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected CurveGenerator()
		{
		}

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x10")]
		public VectorArray3d vertices;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x18")]
		public bool closed;
	}
}

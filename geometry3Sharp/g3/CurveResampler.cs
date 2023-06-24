using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	public class CurveResampler
	{
		// Token: 0x06000582 RID: 1410 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1F991C0", Offset = "0x1F977C0", VA = "0x181F991C0")]
		public List<Vector3d> SplitResample(ISampledCurve3d curve, double fMaxEdgeLen)
		{
			return null;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1F999A0", Offset = "0x1F97FA0", VA = "0x181F999A0")]
		public List<Vector3d> SplitCollapseResample(ISampledCurve3d curve, double fMaxEdgeLen, double fMinEdgeLen)
		{
			return null;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CurveResampler()
		{
		}

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x10")]
		private double[] lengths;
	}
}

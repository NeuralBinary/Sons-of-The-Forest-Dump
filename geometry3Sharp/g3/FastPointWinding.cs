using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	public static class FastPointWinding
	{
		// Token: 0x06000D97 RID: 3479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x203E120", Offset = "0x203C720", VA = "0x18203E120")]
		public static void ComputeCoeffs(IPointSet pointSet, IEnumerable<int> points, double[] pointAreas, ref Vector3d p, ref double r, ref Vector3d order1, ref Matrix3d order2)
		{
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00009C74 File Offset: 0x00007E74
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x203ED40", Offset = "0x203D340", VA = "0x18203ED40")]
		public static double EvaluateOrder1Approx(ref Vector3d center, ref Vector3d order1Coeff, ref Vector3d q)
		{
			return 0.0;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00009C8C File Offset: 0x00007E8C
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x203EEC0", Offset = "0x203D4C0", VA = "0x18203EEC0")]
		public static double EvaluateOrder2Approx(ref Vector3d center, ref Vector3d order1Coeff, ref Matrix3d order2Coeff, ref Vector3d q)
		{
			return 0.0;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00009CA4 File Offset: 0x00007EA4
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x203F160", Offset = "0x203D760", VA = "0x18203F160")]
		public static double ExactEval(ref Vector3d x, ref Vector3d xn, double xA, ref Vector3d q)
		{
			return 0.0;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00009CBC File Offset: 0x00007EBC
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x203F300", Offset = "0x203D900", VA = "0x18203F300")]
		public static double Order1Approx(ref Vector3d x, ref Vector3d p, ref Vector3d xn, double xA, ref Vector3d q)
		{
			return 0.0;
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00009CD4 File Offset: 0x00007ED4
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x203F490", Offset = "0x203DA90", VA = "0x18203F490")]
		public static double Order2Approx(ref Vector3d x, ref Vector3d p, ref Vector3d xn, double xA, ref Vector3d q)
		{
			return 0.0;
		}
	}
}

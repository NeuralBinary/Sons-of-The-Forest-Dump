using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation.Utility
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public static class CubicBezierUtility
	{
		// Token: 0x06000074 RID: 116 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2830D30", Offset = "0x282F330", VA = "0x182830D30")]
		public static Vector3 EvaluateCurve(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2830EF0", Offset = "0x282F4F0", VA = "0x182830EF0")]
		public static Vector3 EvaluateCurve(Vector3 a1, Vector3 c1, Vector3 c2, Vector3 a2, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2831080", Offset = "0x282F680", VA = "0x182831080")]
		public static Vector3 EvaluateCurveDerivative(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2831280", Offset = "0x282F880", VA = "0x182831280")]
		public static Vector3 EvaluateCurveDerivative(Vector3 a1, Vector3 c1, Vector3 c2, Vector3 a2, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2831420", Offset = "0x282FA20", VA = "0x182831420")]
		public static Vector3 EvaluateCurveSecondDerivative(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x639D50", Offset = "0x638350", VA = "0x180639D50")]
		public static Vector3 EvaluateCurveSecondDerivative(Vector3 a1, Vector3 c1, Vector3 c2, Vector3 a2, float t)
		{
			return default(Vector3);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2831500", Offset = "0x282FB00", VA = "0x182831500")]
		public static Vector3 Normal(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x28315E0", Offset = "0x282FBE0", VA = "0x1828315E0")]
		public static Vector3 Normal(Vector3 a1, Vector3 c1, Vector3 c2, Vector3 a2, float t)
		{
			return default(Vector3);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2831970", Offset = "0x282FF70", VA = "0x182831970")]
		public static Bounds CalculateSegmentBounds(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Bounds);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x28320B0", Offset = "0x28306B0", VA = "0x1828320B0")]
		public static Vector3[][] SplitCurve(Vector3[] points, float t)
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x28325D0", Offset = "0x2830BD0", VA = "0x1828325D0")]
		public static float EstimateCurveLength(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return 0f;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x28327A0", Offset = "0x2830DA0", VA = "0x1828327A0")]
		public static List<float> ExtremePointTimes(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2832B00", Offset = "0x2831100", VA = "0x182832B00")]
		private static IEnumerable<float> StationaryPointTimes(float a, float b, float c)
		{
			return null;
		}
	}
}

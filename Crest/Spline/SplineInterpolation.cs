using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest.Spline
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public static class SplineInterpolation
	{
		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0xA25D30", Offset = "0xA24330", VA = "0x180A25D30")]
		public static void InterpolateLinearPosition(Vector3[] points, float t, out Vector3 position)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0xA25E60", Offset = "0xA24460", VA = "0x180A25E60")]
		public static void InterpolateCubicPosition(float splinePointCount, Vector3[] splinePointsAndTangents, float t, out Vector3 position)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA26080", Offset = "0xA24680", VA = "0x180A26080")]
		public static bool GenerateCubicSplineHull(SplinePoint[] splinePoints, Vector3[] splinePointsAndTangents, bool closed)
		{
			return default(bool);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xA270C0", Offset = "0xA256C0", VA = "0x180A270C0")]
		private static Vector3 TangentAfter(SplinePoint[] splinePoints, int idx, bool closed)
		{
			return default(Vector3);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x6000310")]
		[Address(RVA = "0xA270C0", Offset = "0xA256C0", VA = "0x180A270C0")]
		private static Vector3 TangentBefore(SplinePoint[] splinePoints, int idx, bool closed)
		{
			return default(Vector3);
		}
	}
}

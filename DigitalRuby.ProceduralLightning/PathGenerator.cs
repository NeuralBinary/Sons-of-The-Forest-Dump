using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public static class PathGenerator
	{
		// Token: 0x06000174 RID: 372 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x6000174")]
		[Address(RVA = "0xA4BE90", Offset = "0xA4A490", VA = "0x180A4BE90")]
		public static float SquareRoot(float x)
		{
			return 0f;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x6000175")]
		[Address(RVA = "0xA4BF10", Offset = "0xA4A510", VA = "0x180A4BF10")]
		private static float Distance2D(ref Vector3 point1, ref Vector3 point2)
		{
			return 0f;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000176")]
		[Address(RVA = "0xA4BF40", Offset = "0xA4A540", VA = "0x180A4BF40")]
		private static float Distance3D(ref Vector3 point1, ref Vector3 point2)
		{
			return 0f;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000177")]
		[Address(RVA = "0xA4BF80", Offset = "0xA4A580", VA = "0x180A4BF80")]
		private static void GetCurvePoint2D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA4C0D0", Offset = "0xA4A6D0", VA = "0x180A4C0D0")]
		private static void GetCurvePoint3D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA4C290", Offset = "0xA4A890", VA = "0x180A4C290")]
		private static void CalculateNonuniformCatmullRom(float p1, float p2, float p3, float p4, float distance1, float distance2, float distance3, out Vector4 point)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA4C3C0", Offset = "0xA4A9C0", VA = "0x180A4C3C0")]
		private static float CalculatePolynomial(ref Vector4 point, float t)
		{
			return 0f;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA4C3F0", Offset = "0xA4A9F0", VA = "0x180A4C3F0")]
		private static void ClampSplineDistances(ref float distance1, ref float distance2, ref float distance3)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA4C420", Offset = "0xA4AA20", VA = "0x180A4C420")]
		private static void GetSplinePoint2D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA4C640", Offset = "0xA4AC40", VA = "0x180A4C640")]
		private static void GetSplinePoint3D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA4C900", Offset = "0xA4AF00", VA = "0x180A4C900")]
		public static float CreateCurve(ICollection<Vector3> path, Vector3 start, Vector3 end, Vector3 ctr1, Vector3 ctr2, int numberOfSegments, float startT)
		{
			return 0f;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA4CD40", Offset = "0xA4B340", VA = "0x180A4CD40")]
		public static bool CreateSpline(ICollection<Vector3> path, IList<Vector3> points, int numberOfSegments, bool closePath)
		{
			return default(bool);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA4D0F0", Offset = "0xA4B6F0", VA = "0x180A4D0F0")]
		public static bool CreateSplineWithSegmentDistance(ICollection<Vector3> path, IList<Vector3> points, float distancePerSegment, bool closePath)
		{
			return default(bool);
		}

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		public const int MinPointsForSpline = 4;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x0")]
		public static bool Is2D;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		private const float curveMultiplier = 3f;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		private const float splineMultiplier1 = -3f;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		private const float splineMultiplier2 = 3f;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		private const float splineMultiplier3 = 2f;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		private const float splineDistanceClamp = 1f;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		private const float splineEpsilon = 0.0001f;
	}
}

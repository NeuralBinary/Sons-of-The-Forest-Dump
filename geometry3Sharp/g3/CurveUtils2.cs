using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	public static class CurveUtils2
	{
		// Token: 0x0600059F RID: 1439 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1F9D840", Offset = "0x1F9BE40", VA = "0x181F9D840")]
		public static IParametricCurve2d Convert(Polygon2d poly)
		{
			return null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1F9DBD0", Offset = "0x1F9C1D0", VA = "0x181F9DBD0")]
		public static double SampledDistance(IParametricCurve2d c, Vector2d point, int N = 100)
		{
			return 0.0;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1F9DE00", Offset = "0x1F9C400", VA = "0x181F9DE00")]
		public static IEnumerable<IParametricCurve2d> LeafCurvesIteration(IParametricCurve2d c)
		{
			return null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1F9DEA0", Offset = "0x1F9C4A0", VA = "0x181F9DEA0")]
		public static List<IParametricCurve2d> Flatten(List<IParametricCurve2d> curves)
		{
			return null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1F9E180", Offset = "0x1F9C780", VA = "0x181F9E180")]
		public static List<IParametricCurve2d> Flatten(IParametricCurve2d curve)
		{
			return null;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00004D6C File Offset: 0x00002F6C
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1F9E200", Offset = "0x1F9C800", VA = "0x181F9E200")]
		public static Vector2d GetMaxOriginDistances(IEnumerable<Vector2d> vertices)
		{
			return default(Vector2d);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1F9E490", Offset = "0x1F9CA90", VA = "0x181F9E490")]
		public static int FindNearestVertex(Vector2d pt, IEnumerable<Vector2d> vertices)
		{
			return 0;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1F9E6C0", Offset = "0x1F9CCC0", VA = "0x181F9E6C0")]
		public static Vector2d CentroidVtx(IEnumerable<Vector2d> vertices)
		{
			return default(Vector2d);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1F9E970", Offset = "0x1F9CF70", VA = "0x181F9E970")]
		public static void LaplacianSmooth(IList<Vector2d> vertices, double alpha, int iterations, bool is_loop, bool in_place = false)
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1F9EE20", Offset = "0x1F9D420", VA = "0x181F9EE20")]
		public static void LaplacianSmoothConstrained(Polygon2d poly, double alpha, int iterations, double max_dist, bool bAllowShrink, bool bAllowGrow, bool bPerVertexDistances = true)
		{
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1F9F380", Offset = "0x1F9D980", VA = "0x181F9F380")]
		public static void LaplacianSmoothConstrained(GeneralPolygon2d solid, double alpha, int iterations, double max_dist, bool bAllowShrink, bool bAllowGrow)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005AA")]
		public static List<T> Filter<T>(List<T> objects, Func<T, bool> keepF)
		{
			return null;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AB")]
		public static void Split<T>(List<T> objects, out List<T> set1, out List<T> set2, Func<T, bool> splitF)
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1F9F600", Offset = "0x1F9DC00", VA = "0x181F9F600")]
		public static Polygon2d SplitToTargetLength(Polygon2d poly, double length)
		{
			return null;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1F9FA90", Offset = "0x1F9E090", VA = "0x181F9FA90")]
		public static List<GeneralPolygon2d> FilterDegenerate(List<GeneralPolygon2d> polygons, double minArea)
		{
			return null;
		}
	}
}

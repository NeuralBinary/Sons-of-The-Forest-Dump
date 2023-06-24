using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public class CurveUtils
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1F9B7C0", Offset = "0x1F99DC0", VA = "0x181F9B7C0")]
		public static Vector3d GetTangent(List<Vector3d> vertices, int i, bool bLoop = false)
		{
			return default(Vector3d);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1F9BC00", Offset = "0x1F9A200", VA = "0x181F9BC00")]
		public static double ArcLength(List<Vector3d> vertices, bool bLoop = false)
		{
			return 0.0;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1F9BEE0", Offset = "0x1F9A4E0", VA = "0x181F9BEE0")]
		public static double ArcLength(Vector3d[] vertices, bool bLoop = false)
		{
			return 0.0;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1F9C120", Offset = "0x1F9A720", VA = "0x181F9C120")]
		public static double ArcLength(IEnumerable<Vector3d> vertices)
		{
			return 0.0;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1F9C440", Offset = "0x1F9AA40", VA = "0x181F9C440")]
		public static int FindNearestIndex(ISampledCurve3d c, Vector3d v)
		{
			return 0;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1F9C670", Offset = "0x1F9AC70", VA = "0x181F9C670")]
		public static bool FindClosestRayIntersection(ISampledCurve3d c, double segRadius, Ray3d ray, out double minRayT)
		{
			return default(bool);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1F9C9A0", Offset = "0x1F9AFA0", VA = "0x181F9C9A0")]
		public static void InPlaceSmooth(IList<Vector3d> vertices, double alpha, int nIterations, bool bClosed)
		{
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1F9CA30", Offset = "0x1F9B030", VA = "0x181F9CA30")]
		public static void InPlaceSmooth(IList<Vector3d> vertices, int iStart, int iEnd, double alpha, int nIterations, bool bClosed)
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1F9CED0", Offset = "0x1F9B4D0", VA = "0x181F9CED0")]
		public static void IterativeSmooth(IList<Vector3d> vertices, double alpha, int nIterations, bool bClosed)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1F9CF70", Offset = "0x1F9B570", VA = "0x181F9CF70")]
		public static void IterativeSmooth(IList<Vector3d> vertices, int iStart, int iEnd, double alpha, int nIterations, bool bClosed, [Optional] Vector3d[] buffer)
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CurveUtils()
		{
		}
	}
}

using System;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public static class P2T
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x28A3340", Offset = "0x28A1940", VA = "0x1828A3340")]
		public static void Triangulate(PolygonSet ps)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x28A3620", Offset = "0x28A1C20", VA = "0x1828A3620")]
		public static void Triangulate(Polygon p)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x28A3680", Offset = "0x28A1C80", VA = "0x1828A3680")]
		public static void Triangulate(ConstrainedPointSet cps)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x28A36E0", Offset = "0x28A1CE0", VA = "0x1828A36E0")]
		public static void Triangulate(PointSet ps)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x28A3740", Offset = "0x28A1D40", VA = "0x1828A3740")]
		public static TriangulationContext CreateContext(TriangulationAlgorithm algorithm)
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x28A3910", Offset = "0x28A1F10", VA = "0x1828A3910")]
		public static void Triangulate(TriangulationAlgorithm algorithm, Triangulatable t)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x28A39A0", Offset = "0x28A1FA0", VA = "0x1828A39A0")]
		public static void Triangulate(TriangulationContext tcx)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void Warmup()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static TriangulationAlgorithm _defaultAlgorithm;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	public static class MeshQueries
	{
		// Token: 0x06001AA1 RID: 6817 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x1F2D0E0", Offset = "0x1F2B6E0", VA = "0x181F2D0E0")]
		public static DistPoint3Triangle3 TriangleDistance(DMesh3 mesh, int ti, Vector3d point)
		{
			return null;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00013334 File Offset: 0x00011534
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x1F2D230", Offset = "0x1F2B830", VA = "0x181F2D230")]
		public static Frame3f NearestPointFrame(DMesh3 mesh, ISpatial spatial, Vector3d queryPoint, bool bForceFaceNormal = false)
		{
			return default(Frame3f);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0001334C File Offset: 0x0001154C
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x1F2D3F0", Offset = "0x1F2B9F0", VA = "0x181F2D3F0")]
		public static double NearestPointDistance(DMesh3 mesh, ISpatial spatial, Vector3d queryPoint, double maxDist = 1.7976931348623157E+308)
		{
			return 0.0;
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x1F2D570", Offset = "0x1F2BB70", VA = "0x181F2D570")]
		public static DistTriangle3Triangle3 TriangleTriangleDistance(DMesh3 mesh1, int ti, DMesh3 mesh2, int tj, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return null;
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x1F2D810", Offset = "0x1F2BE10", VA = "0x181F2D810")]
		public static IntrRay3Triangle3 TriangleIntersection(DMesh3 mesh, int ti, Ray3d ray)
		{
			return null;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x1F2D940", Offset = "0x1F2BF40", VA = "0x181F2D940")]
		public static IntrTriangle3Triangle3 TrianglesIntersection(DMesh3 mesh1, int ti, DMesh3 mesh2, int tj, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return null;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x1F2DBD0", Offset = "0x1F2C1D0", VA = "0x181F2DBD0")]
		public static DistTriangle3Triangle3 TrianglesDistance(DMesh3 mesh1, int ti, DMesh3 mesh2, int tj, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return null;
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00013364 File Offset: 0x00011564
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x1F2DE70", Offset = "0x1F2C470", VA = "0x181F2DE70")]
		public static bool RayHitPointFrame(DMesh3 mesh, ISpatial spatial, Ray3d ray, out Frame3f hitPosFrame, bool bForceFaceNormal = false)
		{
			return default(bool);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0001337C File Offset: 0x0001157C
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x1F2E080", Offset = "0x1F2C680", VA = "0x181F2E080")]
		public static Frame3f SurfaceFrame(DMesh3 mesh, int tID, Vector3d point, bool bForceFaceNormal = false)
		{
			return default(Frame3f);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00013394 File Offset: 0x00011594
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x1F2E390", Offset = "0x1F2C990", VA = "0x181F2E390")]
		public static Vector3d BaryCoords(DMesh3 mesh, int tID, Vector3d point)
		{
			return default(Vector3d);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000133AC File Offset: 0x000115AC
		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x1F2E510", Offset = "0x1F2CB10", VA = "0x181F2E510")]
		public static double TriDistanceSqr(DMesh3 mesh, int ti, Vector3d point)
		{
			return 0.0;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x000133C4 File Offset: 0x000115C4
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x1F2EAC0", Offset = "0x1F2D0C0", VA = "0x181F2EAC0")]
		public static int FindNearestVertex_LinearSearch(DMesh3 mesh, Vector3d p)
		{
			return 0;
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000133DC File Offset: 0x000115DC
		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x1F2ED30", Offset = "0x1F2D330", VA = "0x181F2ED30")]
		public static int FindNearestTriangle_LinearSearch(DMesh3 mesh, Vector3d p)
		{
			return 0;
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000133F4 File Offset: 0x000115F4
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x1F2EF60", Offset = "0x1F2D560", VA = "0x181F2EF60")]
		public static int FindHitTriangle_LinearSearch(DMesh3 mesh, Ray3d ray)
		{
			return 0;
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0001340C File Offset: 0x0001160C
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x1F2F260", Offset = "0x1F2D860", VA = "0x181F2F260")]
		public static Index2i FindIntersectingTriangles_LinearSearch(DMesh3 mesh1, DMesh3 mesh2)
		{
			return default(Index2i);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00013424 File Offset: 0x00011624
		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0x1F2F770", Offset = "0x1F2DD70", VA = "0x181F2F770")]
		public static Index2i FindNearestTriangles_LinearSearch(DMesh3 mesh1, DMesh3 mesh2, out double fNearestSqr)
		{
			return default(Index2i);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AB1")]
		[Address(RVA = "0x1F2FD70", Offset = "0x1F2E370", VA = "0x181F2FD70")]
		public static void EdgeLengthStats(DMesh3 mesh, out double minEdgeLen, out double maxEdgeLen, out double avgEdgeLen, int samples = 0)
		{
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AB2")]
		[Address(RVA = "0x1F300E0", Offset = "0x1F2E6E0", VA = "0x181F300E0")]
		public static void EdgeLengthStatsFromEdges(DMesh3 mesh, IEnumerable<int> EdgeItr, out double minEdgeLen, out double maxEdgeLen, out double avgEdgeLen, int samples = 0)
		{
		}
	}
}

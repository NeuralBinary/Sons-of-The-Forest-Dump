using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002DB RID: 731
	[Token(Token = "0x20002DB")]
	public class MeshInsertUVPolyCurve
	{
		// Token: 0x06001933 RID: 6451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x1EFCE10", Offset = "0x1EFB410", VA = "0x181EFCE10")]
		public MeshInsertUVPolyCurve(DMesh3 mesh, PolyLine2d curve, bool isLoop = false)
		{
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x1EFD040", Offset = "0x1EFB640", VA = "0x181EFD040")]
		public MeshInsertUVPolyCurve(DMesh3 mesh, Polygon2d loop)
		{
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x1EFD2C0", Offset = "0x1EFB8C0", VA = "0x181EFD2C0")]
		public MeshInsertUVPolyCurve(DMesh3 mesh, PolyLine2d path)
		{
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00012764 File Offset: 0x00010964
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x1EFD540", Offset = "0x1EFBB40", VA = "0x181EFD540", Slot = "4")]
		public virtual ValidationStatus Validate(double fDegenerateTol = 9.999999974752427E-07)
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001937")]
		[Address(RVA = "0x1EFD980", Offset = "0x1EFBF80", VA = "0x181EFD980")]
		private void spatial_add_triangle(int tid)
		{
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001938")]
		[Address(RVA = "0x1EFDAA0", Offset = "0x1EFC0A0", VA = "0x181EFDAA0")]
		private void spatial_add_triangles(int t0, int t1)
		{
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x1EFDAE0", Offset = "0x1EFC0E0", VA = "0x181EFDAE0")]
		private void spatial_remove_triangle(int tid)
		{
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x1EFDC00", Offset = "0x1EFC200", VA = "0x181EFDC00")]
		private void spatial_remove_triangles(int t0, int t1)
		{
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600193B")]
		[Address(RVA = "0x1EFDC40", Offset = "0x1EFC240", VA = "0x181EFDC40")]
		private void insert_corners(HashSet<int> MeshVertsOnCurve)
		{
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0001277C File Offset: 0x0001097C
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x1EFEBC0", Offset = "0x1EFD1C0", VA = "0x181EFEBC0")]
		private int insert_corner_from_bary(int iCorner, int tid, Vector3d bary_coords, double bary_tol, double spatial_tol, out bool is_existing_v)
		{
			return 0;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00012794 File Offset: 0x00010994
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x1EFF2F0", Offset = "0x1EFD8F0", VA = "0x181EFF2F0", Slot = "5")]
		public virtual bool Apply()
		{
			return default(bool);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x1F00B00", Offset = "0x1EFF100", VA = "0x181F00B00")]
		private void add_cut_edge(int eid)
		{
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x1F00B70", Offset = "0x1EFF170", VA = "0x181F00B70")]
		public void Simplify()
		{
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001940")]
		[Address(RVA = "0x1F00C60", Offset = "0x1EFF260", VA = "0x181F00C60")]
		private EdgeLoop simplify(EdgeLoop loop)
		{
			return null;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x1F013D0", Offset = "0x1EFF9D0", VA = "0x181F013D0")]
		private void find_cut_paths(HashSet<int> CutEdges)
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x1F01850", Offset = "0x1EFFE50", VA = "0x181F01850")]
		private static List<int> walk_edge_span_forward(DMesh3 mesh, int start_edge, int start_pivot_v, HashSet<int> EdgeSet, out bool bClosedLoop)
		{
			return null;
		}

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x18")]
		public PolyLine2d Curve;

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x20")]
		public bool IsLoop;

		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x28")]
		public Func<int, Vector2d> PointF;

		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0x30")]
		public Action<int, Vector2d> SetPointF;

		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		[FieldOffset(Offset = "0x38")]
		public bool EnableCutSpansAndLoops;

		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		[FieldOffset(Offset = "0x39")]
		public bool UseTriSpatial;

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		[FieldOffset(Offset = "0x40")]
		public double SpatialEpsilon;

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x48")]
		public int[] CurveVertices;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x50")]
		public HashSet<int> OnCutEdges;

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x58")]
		public List<EdgeSpan> Spans;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x60")]
		public List<EdgeLoop> Loops;

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x68")]
		private TriangleBinsGrid2d triSpatial;
	}
}

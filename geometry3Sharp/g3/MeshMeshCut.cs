using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002ED RID: 749
	[Token(Token = "0x20002ED")]
	public class MeshMeshCut
	{
		// Token: 0x06001984 RID: 6532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x1F09790", Offset = "0x1F07D90", VA = "0x181F09790")]
		public void Compute()
		{
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x1F09DF0", Offset = "0x1F083F0", VA = "0x181F09DF0")]
		public void RemoveContained()
		{
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001986")]
		[Address(RVA = "0x1F0A400", Offset = "0x1F08A00", VA = "0x181F0A400")]
		public void AppendSegments(double r)
		{
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001987")]
		[Address(RVA = "0x1F0A720", Offset = "0x1F08D20", VA = "0x181F0A720")]
		public void ColorFaces()
		{
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001988")]
		[Address(RVA = "0x1F0AD00", Offset = "0x1F09300", VA = "0x181F0AD00")]
		private void initialize()
		{
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001989")]
		[Address(RVA = "0x1F0B480", Offset = "0x1F09A80", VA = "0x181F0B480")]
		private void find_segments()
		{
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600198A")]
		[Address(RVA = "0x1F0BCE0", Offset = "0x1F0A2E0", VA = "0x181F0BCE0")]
		private void insert_face_vertices()
		{
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600198B")]
		[Address(RVA = "0x1F0C200", Offset = "0x1F0A800", VA = "0x181F0C200")]
		private void update_from_poke(MeshMeshCut.SegmentVtx sv, Index3i pokeEdges, Index3i pokeTris)
		{
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x1F0C500", Offset = "0x1F0AB00", VA = "0x181F0C500")]
		private void insert_edge_vertices()
		{
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600198D")]
		[Address(RVA = "0x1F0C980", Offset = "0x1F0AF80", VA = "0x181F0C980")]
		private void update_from_split(MeshMeshCut.SegmentVtx sv, Index2i splitEdges)
		{
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x1F0CB10", Offset = "0x1F0B110", VA = "0x181F0CB10")]
		private void connect_edges()
		{
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x1F0CC50", Offset = "0x1F0B250", VA = "0x181F0CC50")]
		private void insert_segment(MeshMeshCut.IntersectSegment seg)
		{
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x1F0D410", Offset = "0x1F0BA10", VA = "0x181F0D410")]
		private void add_edge_vtx(int eid, MeshMeshCut.SegmentVtx vtx)
		{
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x1F0D590", Offset = "0x1F0BB90", VA = "0x181F0D590")]
		private void add_face_vtx(int tid, MeshMeshCut.SegmentVtx vtx)
		{
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x1F0D710", Offset = "0x1F0BD10", VA = "0x181F0D710")]
		private void add_poke_subfaces(int tid, ref DMesh3.PokeTriangleInfo pokeInfo)
		{
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001993")]
		[Address(RVA = "0x1F0D7C0", Offset = "0x1F0BDC0", VA = "0x181F0D7C0")]
		private void add_split_subfaces(Index2i origTris, ref DMesh3.EdgeSplitInfo splitInfo)
		{
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001994")]
		[Address(RVA = "0x1F0D8B0", Offset = "0x1F0BEB0", VA = "0x181F0D8B0")]
		private void add_regionop_subfaces(int parent, RegionOperator op)
		{
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x000129BC File Offset: 0x00010BBC
		[Token(Token = "0x6001995")]
		[Address(RVA = "0x1F0D950", Offset = "0x1F0BF50", VA = "0x181F0D950")]
		private int get_parent(int tid)
		{
			return 0;
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001996")]
		[Address(RVA = "0x1F0D9E0", Offset = "0x1F0BFE0", VA = "0x181F0D9E0")]
		private HashSet<int> get_subfaces(int parent)
		{
			return null;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001997")]
		[Address(RVA = "0x1F0DAD0", Offset = "0x1F0C0D0", VA = "0x181F0DAD0")]
		private void add_subface(HashSet<int> subfaces, int parent, int tid)
		{
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001998")]
		[Address(RVA = "0x1F0DB90", Offset = "0x1F0C190", VA = "0x181F0DB90")]
		private List<int> get_all_baseface_tris(int base_tid)
		{
			return null;
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000129D4 File Offset: 0x00010BD4
		[Token(Token = "0x6001999")]
		[Address(RVA = "0x1F0DC90", Offset = "0x1F0C290", VA = "0x181F0DC90")]
		private bool is_inserted_free_edge(int eid)
		{
			return default(bool);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000129EC File Offset: 0x00010BEC
		[Token(Token = "0x600199A")]
		[Address(RVA = "0x1F0DD40", Offset = "0x1F0C340", VA = "0x181F0DD40")]
		protected int on_edge(ref Triangle3d tri, ref Vector3d v)
		{
			return 0;
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00012A04 File Offset: 0x00010C04
		[Token(Token = "0x600199B")]
		[Address(RVA = "0x1F0E150", Offset = "0x1F0C750", VA = "0x181F0E150")]
		protected int on_edge_eid(int tid, Vector3d v)
		{
			return 0;
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00012A1C File Offset: 0x00010C1C
		[Token(Token = "0x600199C")]
		[Address(RVA = "0x1F0E2A0", Offset = "0x1F0C8A0", VA = "0x181F0E2A0")]
		protected bool is_on_edge(int eid, Vector3d v)
		{
			return default(bool);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00012A34 File Offset: 0x00010C34
		[Token(Token = "0x600199D")]
		[Address(RVA = "0x1F0E490", Offset = "0x1F0CA90", VA = "0x181F0E490")]
		protected bool is_in_triangle(int tid, Vector3d v)
		{
			return default(bool);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00012A4C File Offset: 0x00010C4C
		[Token(Token = "0x600199E")]
		[Address(RVA = "0x1F0E580", Offset = "0x1F0CB80", VA = "0x181F0E580")]
		protected int find_existing_vertex(Vector3d pt)
		{
			return 0;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00012A64 File Offset: 0x00010C64
		[Token(Token = "0x600199F")]
		[Address(RVA = "0x1F0E5C0", Offset = "0x1F0CBC0", VA = "0x181F0E5C0")]
		protected int find_nearest_vertex(Vector3d pt, double searchRadius, int ignore_vid = -1)
		{
			return 0;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0x1F0E810", Offset = "0x1F0CE10", VA = "0x181F0E810")]
		public MeshMeshCut()
		{
		}

		// Token: 0x04000D46 RID: 3398
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Target;

		// Token: 0x04000D47 RID: 3399
		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x18")]
		public DMesh3 CutMesh;

		// Token: 0x04000D48 RID: 3400
		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x20")]
		private PointHashGrid3d<int> PointHash;

		// Token: 0x04000D49 RID: 3401
		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x28")]
		public double VertexSnapTol;

		// Token: 0x04000D4A RID: 3402
		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x30")]
		public List<int> CutVertices;

		// Token: 0x04000D4B RID: 3403
		[Token(Token = "0x4000D4B")]
		[FieldOffset(Offset = "0x38")]
		private List<MeshMeshCut.SegmentVtx> SegVertices;

		// Token: 0x04000D4C RID: 3404
		[Token(Token = "0x4000D4C")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, MeshMeshCut.SegmentVtx> VIDToSegVtxMap;

		// Token: 0x04000D4D RID: 3405
		[Token(Token = "0x4000D4D")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, List<MeshMeshCut.SegmentVtx>> FaceVertices;

		// Token: 0x04000D4E RID: 3406
		[Token(Token = "0x4000D4E")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, List<MeshMeshCut.SegmentVtx>> EdgeVertices;

		// Token: 0x04000D4F RID: 3407
		[Token(Token = "0x4000D4F")]
		[FieldOffset(Offset = "0x58")]
		private MeshMeshCut.IntersectSegment[] Segments;

		// Token: 0x04000D50 RID: 3408
		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x60")]
		private Vector3d[] BaseFaceCentroids;

		// Token: 0x04000D51 RID: 3409
		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x68")]
		private Vector3d[] BaseFaceNormals;

		// Token: 0x04000D52 RID: 3410
		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<int, HashSet<int>> SubFaces;

		// Token: 0x04000D53 RID: 3411
		[Token(Token = "0x4000D53")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<int, int> ParentFaces;

		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x80")]
		private HashSet<int> SegmentInsertVertices;

		// Token: 0x020002EE RID: 750
		[Token(Token = "0x20002EE")]
		private class SegmentVtx
		{
			// Token: 0x060019A1 RID: 6561 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60019A1")]
			[Address(RVA = "0x1F0E820", Offset = "0x1F0CE20", VA = "0x181F0E820")]
			public SegmentVtx()
			{
			}

			// Token: 0x04000D55 RID: 3413
			[Token(Token = "0x4000D55")]
			[FieldOffset(Offset = "0x10")]
			public Vector3d v;

			// Token: 0x04000D56 RID: 3414
			[Token(Token = "0x4000D56")]
			[FieldOffset(Offset = "0x28")]
			public int type;

			// Token: 0x04000D57 RID: 3415
			[Token(Token = "0x4000D57")]
			[FieldOffset(Offset = "0x2C")]
			public int initial_type;

			// Token: 0x04000D58 RID: 3416
			[Token(Token = "0x4000D58")]
			[FieldOffset(Offset = "0x30")]
			public int vtx_id;

			// Token: 0x04000D59 RID: 3417
			[Token(Token = "0x4000D59")]
			[FieldOffset(Offset = "0x34")]
			public int elem_id;
		}

		// Token: 0x020002EF RID: 751
		[Token(Token = "0x20002EF")]
		private class IntersectSegment
		{
			// Token: 0x170003E0 RID: 992
			[Token(Token = "0x170003E0")]
			public MeshMeshCut.SegmentVtx this[int key]
			{
				[Token(Token = "0x60019A2")]
				[Address(RVA = "0x1F0E840", Offset = "0x1F0CE40", VA = "0x181F0E840")]
				get
				{
					return null;
				}
				[Token(Token = "0x60019A3")]
				[Address(RVA = "0x1F0E850", Offset = "0x1F0CE50", VA = "0x181F0E850")]
				set
				{
				}
			}

			// Token: 0x060019A4 RID: 6564 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60019A4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public IntersectSegment()
			{
			}

			// Token: 0x04000D5A RID: 3418
			[Token(Token = "0x4000D5A")]
			[FieldOffset(Offset = "0x10")]
			public int base_tid;

			// Token: 0x04000D5B RID: 3419
			[Token(Token = "0x4000D5B")]
			[FieldOffset(Offset = "0x18")]
			public MeshMeshCut.SegmentVtx v0;

			// Token: 0x04000D5C RID: 3420
			[Token(Token = "0x4000D5C")]
			[FieldOffset(Offset = "0x20")]
			public MeshMeshCut.SegmentVtx v1;
		}
	}
}

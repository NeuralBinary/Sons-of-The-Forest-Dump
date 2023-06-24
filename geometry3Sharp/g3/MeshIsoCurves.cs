using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002DF RID: 735
	[Token(Token = "0x20002DF")]
	public class MeshIsoCurves
	{
		// Token: 0x0600194E RID: 6478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600194E")]
		[Address(RVA = "0x1F01EB0", Offset = "0x1F004B0", VA = "0x181F01EB0")]
		public MeshIsoCurves(DMesh3 mesh, Func<Vector3d, double> valueF)
		{
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600194F")]
		[Address(RVA = "0x1F020A0", Offset = "0x1F006A0", VA = "0x181F020A0")]
		public void Compute()
		{
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001950")]
		[Address(RVA = "0x1F020E0", Offset = "0x1F006E0", VA = "0x181F020E0")]
		public void Compute(IEnumerable<int> Triangles)
		{
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001951")]
		[Address(RVA = "0x1F020F0", Offset = "0x1F006F0", VA = "0x181F020F0")]
		protected void compute_full(IEnumerable<int> Triangles, bool bIsFullMeshHint = false)
		{
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0001280C File Offset: 0x00010A0C
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x1F03560", Offset = "0x1F01B60", VA = "0x181F03560")]
		private int add_or_append_vertex(Vector3d pos)
		{
			return 0;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x1F03710", Offset = "0x1F01D10", VA = "0x181F03710")]
		private void add_edge_edge(int graph_eid, int mesh_tri, Index2i mesh_edges, Index2i order)
		{
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x1F037C0", Offset = "0x1F01DC0", VA = "0x181F037C0")]
		private void add_edge_vert(int graph_eid, int mesh_tri, int mesh_edge, int mesh_vert, Index2i order)
		{
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x1F03880", Offset = "0x1F01E80", VA = "0x181F03880")]
		private void add_on_edge(int graph_eid, int mesh_tri, int mesh_edge, Index2i order)
		{
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00012824 File Offset: 0x00010A24
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x1F03940", Offset = "0x1F01F40", VA = "0x181F03940")]
		private Vector3d find_crossing(Vector3d a, Vector3d b, double fA, double fB)
		{
			return default(Vector3d);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x1F03E10", Offset = "0x1F02410", VA = "0x181F03E10")]
		private void add_edge_pos(int a, int b, Vector3d crossing_pos)
		{
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x1F03F60", Offset = "0x1F02560", VA = "0x181F03F60")]
		public void SplitAtIsoCrossings(double min_len = 0.0)
		{
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0001283C File Offset: 0x00010A3C
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x1F04490", Offset = "0x1F02A90", VA = "0x181F04490")]
		public bool ShouldReverseGraphEdge(int graph_eid)
		{
			return default(bool);
		}

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x18")]
		public Func<Vector3d, double> ValueF;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x20")]
		public Func<int, double> VertexValueF;

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x28")]
		public bool PrecomputeVertexValues;

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x2C")]
		public MeshIsoCurves.RootfindingModes RootMode;

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0x30")]
		public int RootModeSteps;

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0x38")]
		public DGraph3 Graph;

		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0x40")]
		public bool WantGraphEdgeInfo;

		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0x48")]
		public DVector<MeshIsoCurves.GraphEdgeInfo> GraphEdges;

		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, Vector3d> EdgeLocations;

		// Token: 0x04000D04 RID: 3332
		[Token(Token = "0x4000D04")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Vector3d, int> Vertices;

		// Token: 0x020002E0 RID: 736
		[Token(Token = "0x20002E0")]
		public enum RootfindingModes
		{
			// Token: 0x04000D06 RID: 3334
			[Token(Token = "0x4000D06")]
			SingleLerp,
			// Token: 0x04000D07 RID: 3335
			[Token(Token = "0x4000D07")]
			LerpSteps,
			// Token: 0x04000D08 RID: 3336
			[Token(Token = "0x4000D08")]
			Bisection
		}

		// Token: 0x020002E1 RID: 737
		[Token(Token = "0x20002E1")]
		public enum TriangleCase
		{
			// Token: 0x04000D0A RID: 3338
			[Token(Token = "0x4000D0A")]
			EdgeEdge = 1,
			// Token: 0x04000D0B RID: 3339
			[Token(Token = "0x4000D0B")]
			EdgeVertex,
			// Token: 0x04000D0C RID: 3340
			[Token(Token = "0x4000D0C")]
			OnEdge
		}

		// Token: 0x020002E2 RID: 738
		[Token(Token = "0x20002E2")]
		public struct GraphEdgeInfo
		{
			// Token: 0x04000D0D RID: 3341
			[Token(Token = "0x4000D0D")]
			[FieldOffset(Offset = "0x0")]
			public MeshIsoCurves.TriangleCase caseType;

			// Token: 0x04000D0E RID: 3342
			[Token(Token = "0x4000D0E")]
			[FieldOffset(Offset = "0x4")]
			public int mesh_tri;

			// Token: 0x04000D0F RID: 3343
			[Token(Token = "0x4000D0F")]
			[FieldOffset(Offset = "0x8")]
			public Index2i mesh_edges;

			// Token: 0x04000D10 RID: 3344
			[Token(Token = "0x4000D10")]
			[FieldOffset(Offset = "0x10")]
			public Index2i order;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	public class Reducer : MeshRefinerBase
	{
		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x000119FC File Offset: 0x0000FBFC
		[Token(Token = "0x170003A5")]
		private bool EnableInlineProjection
		{
			[Token(Token = "0x600172C")]
			[Address(RVA = "0x1EBCFE0", Offset = "0x1EBB5E0", VA = "0x181EBCFE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600172D")]
		[Address(RVA = "0x1EBCFF0", Offset = "0x1EBB5F0", VA = "0x181EBCFF0")]
		public Reducer(DMesh3 m)
		{
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x1EBD130", Offset = "0x1EBB730", VA = "0x181EBD130")]
		protected Reducer()
		{
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
		public void SetProjectionTarget(IProjectionTarget target)
		{
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x1EBD200", Offset = "0x1EBB800", VA = "0x181EBD200", Slot = "5")]
		public virtual void DoReduce()
		{
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x1EBD570", Offset = "0x1EBBB70", VA = "0x181EBD570", Slot = "6")]
		public virtual void ReduceToTriangleCount(int nCount)
		{
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x1EBD5F0", Offset = "0x1EBBBF0", VA = "0x181EBD5F0", Slot = "7")]
		public virtual void ReduceToVertexCount(int nCount)
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x1EBD670", Offset = "0x1EBBC70", VA = "0x181EBD670", Slot = "8")]
		public virtual void ReduceToEdgeLength(double minEdgeLen)
		{
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001734")]
		[Address(RVA = "0x1EBD6A0", Offset = "0x1EBBCA0", VA = "0x181EBD6A0", Slot = "9")]
		public virtual void FastCollapsePass(double fMinEdgeLength, int nRounds = 1, bool MeshIsClosedHint = false)
		{
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x1EBDB30", Offset = "0x1EBC130", VA = "0x181EBDB30", Slot = "10")]
		protected virtual void InitializeVertexQuadrics()
		{
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001736")]
		[Address(RVA = "0x1EBDF20", Offset = "0x1EBC520", VA = "0x181EBDF20", Slot = "11")]
		protected virtual void InitializeQueue()
		{
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00011A14 File Offset: 0x0000FC14
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x1EBE460", Offset = "0x1EBCA60", VA = "0x181EBE460")]
		protected Vector3d OptimalPoint(int eid, ref QuadricError q, int ea, int eb)
		{
			return default(Vector3d);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00011A2C File Offset: 0x0000FC2C
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x1EBEA10", Offset = "0x1EBD010", VA = "0x181EBEA10")]
		private Vector3d project(Vector3d pos)
		{
			return default(Vector3d);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x1EBEB30", Offset = "0x1EBD130", VA = "0x181EBEB30", Slot = "12")]
		protected virtual void UpdateNeighbours(int vid)
		{
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x1EBF190", Offset = "0x1EBD790", VA = "0x181EBF190", Slot = "13")]
		protected virtual void Reproject()
		{
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x1EBF200", Offset = "0x1EBD800", VA = "0x181EBF200", Slot = "14")]
		protected virtual void Precompute(bool bMeshIsClosed = false)
		{
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00011A44 File Offset: 0x0000FC44
		[Token(Token = "0x600173C")]
		[Address(RVA = "0x1EBF500", Offset = "0x1EBDB00", VA = "0x181EBF500")]
		protected bool IsBoundaryV(int vid)
		{
			return default(bool);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600173D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		protected virtual void OnEdgeCollapse(int edgeID, int va, int vb, DMesh3.EdgeCollapseInfo collapseInfo)
		{
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00011A5C File Offset: 0x0000FC5C
		[Token(Token = "0x600173E")]
		[Address(RVA = "0x1EBF540", Offset = "0x1EBDB40", VA = "0x181EBF540", Slot = "16")]
		protected virtual int start_edges()
		{
			return 0;
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00011A74 File Offset: 0x0000FC74
		[Token(Token = "0x600173F")]
		[Address(RVA = "0x1EBF5B0", Offset = "0x1EBDBB0", VA = "0x181EBF5B0", Slot = "17")]
		protected virtual int next_edge(int cur_eid, out bool bDone)
		{
			return 0;
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001740")]
		[Address(RVA = "0x1EBF5D0", Offset = "0x1EBDBD0", VA = "0x181EBF5D0", Slot = "18")]
		protected virtual IEnumerable<int> project_vertices()
		{
			return null;
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00011A8C File Offset: 0x0000FC8C
		[Token(Token = "0x6001741")]
		[Address(RVA = "0x1EBF5F0", Offset = "0x1EBDBF0", VA = "0x181EBF5F0", Slot = "19")]
		protected virtual Reducer.ProcessResult CollapseEdge(int edgeID, Vector3d vNewPos, out int collapseToV)
		{
			return Reducer.ProcessResult.Ok_Collapsed;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001742")]
		[Address(RVA = "0x1EBFD80", Offset = "0x1EBE380", VA = "0x181EBFD80")]
		protected void project_vertex(int vID, IProjectionTarget targetIn)
		{
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00011AA4 File Offset: 0x0000FCA4
		[Token(Token = "0x6001743")]
		[Address(RVA = "0x1EBFED0", Offset = "0x1EBE4D0", VA = "0x181EBFED0")]
		protected Vector3d get_projected_collapse_position(int vid, Vector3d vNewPos)
		{
			return default(Vector3d);
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001744")]
		[Address(RVA = "0x1EC0010", Offset = "0x1EBE610", VA = "0x181EC0010", Slot = "20")]
		protected virtual void FullProjectionPass()
		{
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001745")]
		[Address(RVA = "0x1EC00A0", Offset = "0x1EBE6A0", VA = "0x181EC00A0", Slot = "21")]
		[Conditional("DEBUG")]
		protected virtual void RuntimeDebugCheck(int eid)
		{
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x1EC0160", Offset = "0x1EBE760", VA = "0x181EC0160", Slot = "22")]
		protected virtual void DoDebugChecks()
		{
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x1EC0180", Offset = "0x1EBE780", VA = "0x181EC0180", Slot = "23")]
		protected virtual void DebugCheckVertexConstraints()
		{
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001748")]
		[Address(RVA = "0x1EC0530", Offset = "0x1EBEB30", VA = "0x181EC0530", Slot = "24")]
		protected virtual void begin_pass()
		{
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x1EC0710", Offset = "0x1EBED10", VA = "0x181EC0710", Slot = "25")]
		protected virtual void end_pass()
		{
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174A")]
		[Address(RVA = "0x1EC0A30", Offset = "0x1EBF030", VA = "0x181EC0A30", Slot = "26")]
		protected virtual void begin_ops()
		{
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174B")]
		[Address(RVA = "0x1EC0AA0", Offset = "0x1EBF0A0", VA = "0x181EC0AA0", Slot = "27")]
		protected virtual void end_ops()
		{
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174C")]
		[Address(RVA = "0x1EC0AD0", Offset = "0x1EBF0D0", VA = "0x181EC0AD0", Slot = "28")]
		protected virtual void begin_setup()
		{
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174D")]
		[Address(RVA = "0x1EC0B40", Offset = "0x1EBF140", VA = "0x181EC0B40", Slot = "29")]
		protected virtual void end_setup()
		{
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174E")]
		[Address(RVA = "0x1EC0B70", Offset = "0x1EBF170", VA = "0x181EC0B70", Slot = "30")]
		protected virtual void begin_project()
		{
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600174F")]
		[Address(RVA = "0x1EC0BE0", Offset = "0x1EBF1E0", VA = "0x181EC0BE0", Slot = "31")]
		protected virtual void end_project()
		{
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001750")]
		[Address(RVA = "0x1EC0C10", Offset = "0x1EBF210", VA = "0x181EC0C10", Slot = "32")]
		protected virtual void begin_collapse()
		{
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001751")]
		[Address(RVA = "0x1EC0C80", Offset = "0x1EBF280", VA = "0x181EC0C80", Slot = "33")]
		protected virtual void end_collapse()
		{
		}

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x38")]
		protected IProjectionTarget target;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x40")]
		public bool MinimizeQuadricPositionError;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		[FieldOffset(Offset = "0x41")]
		public bool PreserveBoundaryShape;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		[FieldOffset(Offset = "0x48")]
		public List<int> DebugEdges;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		[FieldOffset(Offset = "0x50")]
		public Reducer.TargetProjectionMode ProjectionMode;

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		[FieldOffset(Offset = "0x54")]
		public bool ENABLE_PROFILING;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x58")]
		protected double MinEdgeLength;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x60")]
		protected int TargetCount;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x64")]
		protected Reducer.TargetModes ReduceMode;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x68")]
		protected QuadricError[] vertQuadrics;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x70")]
		protected Reducer.QEdge[] EdgeQuadrics;

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x78")]
		protected IndexPriorityQueue EdgeQueue;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x80")]
		protected bool HaveBoundary;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x88")]
		protected bool[] IsBoundaryVtxCache;

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		private const int nPrime = 31337;

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x90")]
		private int nMaxEdgeID;

		// Token: 0x04000AD1 RID: 2769
		[Token(Token = "0x4000AD1")]
		[FieldOffset(Offset = "0x94")]
		public bool ENABLE_DEBUG_CHECKS;

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x98")]
		private int COUNT_COLLAPSES;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x9C")]
		private int COUNT_ITERATIONS;

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0xA0")]
		private Stopwatch AllOpsW;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0xA8")]
		private Stopwatch SetupW;

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0xB0")]
		private Stopwatch ProjectW;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		[FieldOffset(Offset = "0xB8")]
		private Stopwatch CollapseW;

		// Token: 0x02000286 RID: 646
		[Token(Token = "0x2000286")]
		public enum TargetProjectionMode
		{
			// Token: 0x04000AD9 RID: 2777
			[Token(Token = "0x4000AD9")]
			NoProjection,
			// Token: 0x04000ADA RID: 2778
			[Token(Token = "0x4000ADA")]
			AfterRefinement,
			// Token: 0x04000ADB RID: 2779
			[Token(Token = "0x4000ADB")]
			Inline
		}

		// Token: 0x02000287 RID: 647
		[Token(Token = "0x2000287")]
		protected enum TargetModes
		{
			// Token: 0x04000ADD RID: 2781
			[Token(Token = "0x4000ADD")]
			TriangleCount,
			// Token: 0x04000ADE RID: 2782
			[Token(Token = "0x4000ADE")]
			VertexCount,
			// Token: 0x04000ADF RID: 2783
			[Token(Token = "0x4000ADF")]
			MinEdgeLength
		}

		// Token: 0x02000288 RID: 648
		[Token(Token = "0x2000288")]
		protected struct QEdge
		{
			// Token: 0x06001753 RID: 5971 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001753")]
			[Address(RVA = "0x1EC0E50", Offset = "0x1EBF450", VA = "0x181EC0E50")]
			public QEdge(int edge_id, ref QuadricError qin, ref Vector3d pt)
			{
			}

			// Token: 0x04000AE0 RID: 2784
			[Token(Token = "0x4000AE0")]
			[FieldOffset(Offset = "0x0")]
			public int eid;

			// Token: 0x04000AE1 RID: 2785
			[Token(Token = "0x4000AE1")]
			[FieldOffset(Offset = "0x8")]
			public QuadricError q;

			// Token: 0x04000AE2 RID: 2786
			[Token(Token = "0x4000AE2")]
			[FieldOffset(Offset = "0x58")]
			public Vector3d collapse_pt;
		}

		// Token: 0x02000289 RID: 649
		[Token(Token = "0x2000289")]
		protected enum ProcessResult
		{
			// Token: 0x04000AE4 RID: 2788
			[Token(Token = "0x4000AE4")]
			Ok_Collapsed,
			// Token: 0x04000AE5 RID: 2789
			[Token(Token = "0x4000AE5")]
			Ignored_CannotCollapse,
			// Token: 0x04000AE6 RID: 2790
			[Token(Token = "0x4000AE6")]
			Ignored_EdgeIsFullyConstrained,
			// Token: 0x04000AE7 RID: 2791
			[Token(Token = "0x4000AE7")]
			Ignored_EdgeTooLong,
			// Token: 0x04000AE8 RID: 2792
			[Token(Token = "0x4000AE8")]
			Ignored_Constrained,
			// Token: 0x04000AE9 RID: 2793
			[Token(Token = "0x4000AE9")]
			Ignored_CreatesFlip,
			// Token: 0x04000AEA RID: 2794
			[Token(Token = "0x4000AEA")]
			Failed_OpNotSuccessful,
			// Token: 0x04000AEB RID: 2795
			[Token(Token = "0x4000AEB")]
			Failed_NotAnEdge
		}
	}
}

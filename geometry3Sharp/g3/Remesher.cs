using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	public class Remesher : MeshRefinerBase
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x00011B1C File Offset: 0x0000FD1C
		[Token(Token = "0x170003A7")]
		private bool EnableInlineProjection
		{
			[Token(Token = "0x6001768")]
			[Address(RVA = "0x1EC3020", Offset = "0x1EC1620", VA = "0x181EC3020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x1EC3030", Offset = "0x1EC1630", VA = "0x181EC3030")]
		public Remesher(DMesh3 m)
		{
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600176A")]
		[Address(RVA = "0x1EC3280", Offset = "0x1EC1880", VA = "0x181EC3280")]
		protected Remesher()
		{
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170003A8")]
		public IProjectionTarget ProjectionTarget
		{
			[Token(Token = "0x600176B")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
		public void SetProjectionTarget(IProjectionTarget target)
		{
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600176D")]
		[Address(RVA = "0x1EC3480", Offset = "0x1EC1A80", VA = "0x181EC3480")]
		public void SetTargetEdgeLength(double fLength)
		{
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600176E")]
		[Address(RVA = "0x1EC34A0", Offset = "0x1EC1AA0", VA = "0x181EC34A0", Slot = "5")]
		public virtual void Precompute()
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600176F")]
		[Address(RVA = "0x1EC3620", Offset = "0x1EC1C20", VA = "0x181EC3620", Slot = "6")]
		public virtual void BasicRemeshPass()
		{
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001770")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		protected virtual void OnEdgeSplit(int edgeID, int va, int vb, DMesh3.EdgeSplitInfo splitInfo)
		{
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001771")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		protected virtual void OnEdgeCollapse(int edgeID, int va, int vb, DMesh3.EdgeCollapseInfo collapseInfo)
		{
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00011B34 File Offset: 0x0000FD34
		[Token(Token = "0x6001772")]
		[Address(RVA = "0x1EBF540", Offset = "0x1EBDB40", VA = "0x181EBF540", Slot = "9")]
		protected virtual int start_edges()
		{
			return 0;
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00011B4C File Offset: 0x0000FD4C
		[Token(Token = "0x6001773")]
		[Address(RVA = "0x1EBF5B0", Offset = "0x1EBDBB0", VA = "0x181EBF5B0", Slot = "10")]
		protected virtual int next_edge(int cur_eid, out bool bDone)
		{
			return 0;
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x1EBF5D0", Offset = "0x1EBDBD0", VA = "0x181EBF5D0", Slot = "11")]
		protected virtual IEnumerable<int> smooth_vertices()
		{
			return null;
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x1EBF5D0", Offset = "0x1EBDBD0", VA = "0x181EBF5D0", Slot = "12")]
		protected virtual IEnumerable<int> project_vertices()
		{
			return null;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00011B64 File Offset: 0x0000FD64
		[Token(Token = "0x6001776")]
		[Address(RVA = "0x1EC3950", Offset = "0x1EC1F50", VA = "0x181EC3950", Slot = "13")]
		protected virtual Remesher.ProcessResult ProcessEdge(int edgeID)
		{
			return Remesher.ProcessResult.Ok_Collapsed;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001777")]
		[Address(RVA = "0x1EC43A0", Offset = "0x1EC29A0", VA = "0x181EC43A0", Slot = "14")]
		protected virtual void update_after_split(int edgeID, int va, int vb, ref DMesh3.EdgeSplitInfo splitInfo)
		{
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001778")]
		[Address(RVA = "0x1EC47A0", Offset = "0x1EC2DA0", VA = "0x181EC47A0", Slot = "15")]
		protected virtual void project_vertex(int vID, IProjectionTarget targetIn)
		{
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00011B7C File Offset: 0x0000FD7C
		[Token(Token = "0x6001779")]
		[Address(RVA = "0x1EC48F0", Offset = "0x1EC2EF0", VA = "0x181EC48F0", Slot = "16")]
		protected virtual Vector3d get_projected_collapse_position(int vid, Vector3d vNewPos)
		{
			return default(Vector3d);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x1EC4AD0", Offset = "0x1EC30D0", VA = "0x181EC4AD0", Slot = "17")]
		protected virtual void FullSmoothPass_InPlace(bool bParallel)
		{
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x1EC4F50", Offset = "0x1EC3550", VA = "0x181EC4F50", Slot = "18")]
		protected virtual void FullSmoothPass_Buffer(bool bParallel)
		{
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x1EC5410", Offset = "0x1EC3A10", VA = "0x181EC5410", Slot = "19")]
		protected virtual void InitializeVertexBufferForPass()
		{
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600177D")]
		[Address(RVA = "0x1EC5750", Offset = "0x1EC3D50", VA = "0x181EC5750", Slot = "20")]
		protected virtual void ApplyVertexBuffer(bool bParallel)
		{
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00011B94 File Offset: 0x0000FD94
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x1EC5A80", Offset = "0x1EC4080", VA = "0x181EC5A80", Slot = "21")]
		protected virtual Vector3d ComputeSmoothedVertexPos(int vID, Func<DMesh3, int, double, Vector3d> smoothFunc, out bool bModified)
		{
			return default(Vector3d);
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x1EC5C60", Offset = "0x1EC4260", VA = "0x181EC5C60", Slot = "22")]
		protected virtual void FullProjectionPass()
		{
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x1EC5EA0", Offset = "0x1EC44A0", VA = "0x181EC5EA0")]
		[Conditional("DEBUG")]
		private void RuntimeDebugCheck(int eid)
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x1EC5F60", Offset = "0x1EC4560", VA = "0x181EC5F60", Slot = "23")]
		protected virtual void DoDebugChecks()
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001782")]
		[Address(RVA = "0x1EC5F80", Offset = "0x1EC4580", VA = "0x181EC5F80")]
		private void DebugCheckVertexConstraints()
		{
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x1EC6330", Offset = "0x1EC4930", VA = "0x181EC6330", Slot = "24")]
		protected virtual void begin_pass()
		{
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x1EC65D0", Offset = "0x1EC4BD0", VA = "0x181EC65D0", Slot = "25")]
		protected virtual void end_pass()
		{
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001785")]
		[Address(RVA = "0x1EC69E0", Offset = "0x1EC4FE0", VA = "0x181EC69E0", Slot = "26")]
		protected virtual void begin_ops()
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001786")]
		[Address(RVA = "0x1EC6A60", Offset = "0x1EC5060", VA = "0x181EC6A60", Slot = "27")]
		protected virtual void end_ops()
		{
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001787")]
		[Address(RVA = "0x1EC6A90", Offset = "0x1EC5090", VA = "0x181EC6A90", Slot = "28")]
		protected virtual void begin_smooth()
		{
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001788")]
		[Address(RVA = "0x1EC6B10", Offset = "0x1EC5110", VA = "0x181EC6B10", Slot = "29")]
		protected virtual void end_smooth()
		{
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001789")]
		[Address(RVA = "0x1EC6B40", Offset = "0x1EC5140", VA = "0x181EC6B40", Slot = "30")]
		protected virtual void begin_project()
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600178A")]
		[Address(RVA = "0x1EC6BC0", Offset = "0x1EC51C0", VA = "0x181EC6BC0", Slot = "31")]
		protected virtual void end_project()
		{
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x1EC6BF0", Offset = "0x1EC51F0", VA = "0x181EC6BF0", Slot = "32")]
		protected virtual void begin_collapse()
		{
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x1EC6C70", Offset = "0x1EC5270", VA = "0x181EC6C70", Slot = "33")]
		protected virtual void end_collapse()
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x1EC6CA0", Offset = "0x1EC52A0", VA = "0x181EC6CA0", Slot = "34")]
		protected virtual void begin_flip()
		{
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x1EC6D20", Offset = "0x1EC5320", VA = "0x181EC6D20", Slot = "35")]
		protected virtual void end_flip()
		{
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x1EC6D50", Offset = "0x1EC5350", VA = "0x181EC6D50", Slot = "36")]
		protected virtual void begin_split()
		{
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001790")]
		[Address(RVA = "0x1EC6DD0", Offset = "0x1EC53D0", VA = "0x181EC6DD0", Slot = "37")]
		protected virtual void end_split()
		{
		}

		// Token: 0x04000B05 RID: 2821
		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0x38")]
		private IProjectionTarget target;

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x40")]
		public bool EnableFlips;

		// Token: 0x04000B07 RID: 2823
		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0x41")]
		public bool EnableCollapses;

		// Token: 0x04000B08 RID: 2824
		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0x42")]
		public bool EnableSplits;

		// Token: 0x04000B09 RID: 2825
		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0x43")]
		public bool EnableSmoothing;

		// Token: 0x04000B0A RID: 2826
		[Token(Token = "0x4000B0A")]
		[FieldOffset(Offset = "0x44")]
		public bool PreventNormalFlips;

		// Token: 0x04000B0B RID: 2827
		[Token(Token = "0x4000B0B")]
		[FieldOffset(Offset = "0x48")]
		public double MinEdgeLength;

		// Token: 0x04000B0C RID: 2828
		[Token(Token = "0x4000B0C")]
		[FieldOffset(Offset = "0x50")]
		public double MaxEdgeLength;

		// Token: 0x04000B0D RID: 2829
		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x58")]
		public double SmoothSpeedT;

		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4000B0E")]
		[FieldOffset(Offset = "0x60")]
		public Remesher.SmoothTypes SmoothType;

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x68")]
		public Func<DMesh3, int, double, Vector3d> CustomSmoothF;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x70")]
		public Func<int, Remesher.VertexControl> VertexControlF;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x78")]
		public List<int> DebugEdges;

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		[FieldOffset(Offset = "0x80")]
		public Remesher.TargetProjectionMode ProjectionMode;

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x84")]
		public bool EnableParallelProjection;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x85")]
		public bool EnableParallelSmooth;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0x86")]
		public bool EnableSmoothInPlace;

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x87")]
		public bool ENABLE_PROFILING;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x88")]
		private bool MeshIsClosed;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x8C")]
		public int ModifiedEdgesLastPass;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		private const int nPrime = 31337;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x90")]
		private int nMaxEdgeID;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x98")]
		protected DVector<Vector3d> vBufferV;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0xA0")]
		protected BitArray vModifiedV;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0xA8")]
		public bool ENABLE_DEBUG_CHECKS;

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0xAC")]
		private int COUNT_SPLITS;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0xB0")]
		private int COUNT_COLLAPSES;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0xB4")]
		private int COUNT_FLIPS;

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0xB8")]
		private Stopwatch AllOpsW;

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0xC0")]
		private Stopwatch SmoothW;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0xC8")]
		private Stopwatch ProjectW;

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4000B24")]
		[FieldOffset(Offset = "0xD0")]
		private Stopwatch FlipW;

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		[FieldOffset(Offset = "0xD8")]
		private Stopwatch SplitW;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4000B26")]
		[FieldOffset(Offset = "0xE0")]
		private Stopwatch CollapseW;

		// Token: 0x02000290 RID: 656
		[Token(Token = "0x2000290")]
		public enum SmoothTypes
		{
			// Token: 0x04000B28 RID: 2856
			[Token(Token = "0x4000B28")]
			Uniform,
			// Token: 0x04000B29 RID: 2857
			[Token(Token = "0x4000B29")]
			Cotan,
			// Token: 0x04000B2A RID: 2858
			[Token(Token = "0x4000B2A")]
			MeanValue
		}

		// Token: 0x02000291 RID: 657
		[Token(Token = "0x2000291")]
		[Flags]
		public enum VertexControl
		{
			// Token: 0x04000B2C RID: 2860
			[Token(Token = "0x4000B2C")]
			AllowAll = 0,
			// Token: 0x04000B2D RID: 2861
			[Token(Token = "0x4000B2D")]
			NoSmooth = 1,
			// Token: 0x04000B2E RID: 2862
			[Token(Token = "0x4000B2E")]
			NoProject = 2,
			// Token: 0x04000B2F RID: 2863
			[Token(Token = "0x4000B2F")]
			NoMovement = 3
		}

		// Token: 0x02000292 RID: 658
		[Token(Token = "0x2000292")]
		public enum TargetProjectionMode
		{
			// Token: 0x04000B31 RID: 2865
			[Token(Token = "0x4000B31")]
			NoProjection,
			// Token: 0x04000B32 RID: 2866
			[Token(Token = "0x4000B32")]
			AfterRefinement,
			// Token: 0x04000B33 RID: 2867
			[Token(Token = "0x4000B33")]
			Inline
		}

		// Token: 0x02000293 RID: 659
		[Token(Token = "0x2000293")]
		protected enum ProcessResult
		{
			// Token: 0x04000B35 RID: 2869
			[Token(Token = "0x4000B35")]
			Ok_Collapsed,
			// Token: 0x04000B36 RID: 2870
			[Token(Token = "0x4000B36")]
			Ok_Flipped,
			// Token: 0x04000B37 RID: 2871
			[Token(Token = "0x4000B37")]
			Ok_Split,
			// Token: 0x04000B38 RID: 2872
			[Token(Token = "0x4000B38")]
			Ignored_EdgeIsFine,
			// Token: 0x04000B39 RID: 2873
			[Token(Token = "0x4000B39")]
			Ignored_EdgeIsFullyConstrained,
			// Token: 0x04000B3A RID: 2874
			[Token(Token = "0x4000B3A")]
			Failed_OpNotSuccessful,
			// Token: 0x04000B3B RID: 2875
			[Token(Token = "0x4000B3B")]
			Failed_NotAnEdge
		}
	}
}

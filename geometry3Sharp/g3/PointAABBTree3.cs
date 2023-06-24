using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000393 RID: 915
	[Token(Token = "0x2000393")]
	public class PointAABBTree3
	{
		// Token: 0x06001DB4 RID: 7604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0x1F853E0", Offset = "0x1F839E0", VA = "0x181F853E0")]
		public PointAABBTree3(IPointSet pointsIn, bool autoBuild = true)
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000475")]
		public IPointSet Points
		{
			[Token(Token = "0x6001DB5")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x1F85660", Offset = "0x1F83C60", VA = "0x181F85660")]
		public void Build(PointAABBTree3.BuildStrategy eStrategy = PointAABBTree3.BuildStrategy.TopDownMidpoint)
		{
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00014DA4 File Offset: 0x00012FA4
		[Token(Token = "0x6001DB7")]
		[Address(RVA = "0x1F856E0", Offset = "0x1F83CE0", VA = "0x181F856E0", Slot = "4")]
		public virtual int FindNearestPoint(Vector3d p, double fMaxDist = 1.7976931348623157E+308)
		{
			return 0;
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DB8")]
		[Address(RVA = "0x1F85820", Offset = "0x1F83E20", VA = "0x181F85820")]
		protected void find_nearest_point(int iBox, Vector3d p, ref double fNearestSqr, ref int tID)
		{
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DB9")]
		[Address(RVA = "0x1F85C60", Offset = "0x1F84260", VA = "0x181F85C60", Slot = "5")]
		public virtual void DoTraversal(PointAABBTree3.TreeTraversal traversal)
		{
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DBA")]
		[Address(RVA = "0x1F85D40", Offset = "0x1F84340", VA = "0x181F85D40", Slot = "6")]
		protected virtual void tree_traversal(int iBox, int depth, PointAABBTree3.TreeTraversal traversal)
		{
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00014DBC File Offset: 0x00012FBC
		[Token(Token = "0x6001DBB")]
		[Address(RVA = "0x1F860C0", Offset = "0x1F846C0", VA = "0x181F860C0", Slot = "7")]
		public virtual double FastWindingNumber(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00014DD4 File Offset: 0x00012FD4
		[Token(Token = "0x6001DBC")]
		[Address(RVA = "0x1F86200", Offset = "0x1F84800", VA = "0x181F86200")]
		protected double branch_fast_winding_num(int iBox, Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DBD")]
		[Address(RVA = "0x1F86930", Offset = "0x1F84F30", VA = "0x181F86930")]
		protected void build_fast_winding_cache()
		{
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00014DEC File Offset: 0x00012FEC
		[Token(Token = "0x6001DBE")]
		[Address(RVA = "0x1F86D20", Offset = "0x1F85320", VA = "0x181F86D20")]
		protected int build_fast_winding_cache(int iBox, int depth, int pt_count_thresh, out HashSet<int> pts_hash)
		{
			return 0;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00014E04 File Offset: 0x00013004
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0x1F87140", Offset = "0x1F85740", VA = "0x181F87140")]
		protected bool can_use_fast_winding_cache(int iBox, ref Vector3d q)
		{
			return default(bool);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0x1F87290", Offset = "0x1F85890", VA = "0x181F87290")]
		protected void make_box_fast_winding_cache(int iBox, IEnumerable<int> pointIndices)
		{
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00014E1C File Offset: 0x0001301C
		[Token(Token = "0x6001DC1")]
		[Address(RVA = "0x1F873D0", Offset = "0x1F859D0", VA = "0x181F873D0")]
		protected double evaluate_box_fast_winding_cache(int iBox, ref Vector3d q)
		{
			return 0.0;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x1F876B0", Offset = "0x1F85CB0", VA = "0x181F876B0")]
		protected void collect_points(int iBox, HashSet<int> points)
		{
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00014E34 File Offset: 0x00013034
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x1F878A0", Offset = "0x1F85EA0", VA = "0x181F878A0")]
		public double TotalVolume()
		{
			return 0.0;
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00014E4C File Offset: 0x0001304C
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x1F879E0", Offset = "0x1F85FE0", VA = "0x181F879E0")]
		public double TotalExtentSum()
		{
			return 0.0;
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00014E64 File Offset: 0x00013064
		[Token(Token = "0x17000476")]
		public AxisAlignedBox3d Bounds
		{
			[Token(Token = "0x6001DC5")]
			[Address(RVA = "0x1F87B20", Offset = "0x1F86120", VA = "0x181F87B20")]
			get
			{
				return default(AxisAlignedBox3d);
			}
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x1F87B60", Offset = "0x1F86160", VA = "0x181F87B60")]
		private void build_top_down(bool bSorted)
		{
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00014E7C File Offset: 0x0001307C
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x1F88800", Offset = "0x1F86E00", VA = "0x181F88800")]
		private int split_point_set_sorted(int[] pt_indices, Vector3d[] positions, int iStart, int iCount, int depth, int minIndexCount, PointAABBTree3.boxes_set leafs, PointAABBTree3.boxes_set nodes, out AxisAlignedBox3d box)
		{
			return 0;
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00014E94 File Offset: 0x00013094
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x1F88F30", Offset = "0x1F87530", VA = "0x181F88F30")]
		private int split_point_set_midpoint(int[] pt_indices, Vector3d[] positions, int iStart, int iCount, int depth, int minIndexCount, PointAABBTree3.boxes_set leafs, PointAABBTree3.boxes_set nodes, out AxisAlignedBox3d box)
		{
			return 0;
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00014EAC File Offset: 0x000130AC
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0x1F898C0", Offset = "0x1F87EC0", VA = "0x181F898C0")]
		private AxisAlignedBox3d get_box(int iBox)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00014EC4 File Offset: 0x000130C4
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x1F89A80", Offset = "0x1F88080", VA = "0x181F89A80")]
		private double box_distance_sqr(int iBox, ref Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00014EDC File Offset: 0x000130DC
		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0x1F89CE0", Offset = "0x1F882E0", VA = "0x181F89CE0")]
		protected bool box_contains(int iBox, Vector3d p)
		{
			return default(bool);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0x1F89F00", Offset = "0x1F88500", VA = "0x181F89F00")]
		public void TestCoverage()
		{
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DCD")]
		[Address(RVA = "0x1F8A1E0", Offset = "0x1F887E0", VA = "0x181F8A1E0")]
		private void test_coverage(int[] point_counts, int[] parent_indices, int iBox)
		{
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0x1F8A5F0", Offset = "0x1F88BF0", VA = "0x181F8A5F0")]
		private void debug_check_child_point_distances(int iBox, Vector3d p)
		{
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0x1F8A7C0", Offset = "0x1F88DC0", VA = "0x181F8A7C0")]
		private void debug_check_child_points_in_box(int iBox)
		{
		}

		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		[FieldOffset(Offset = "0x10")]
		private IPointSet points;

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x18")]
		private int points_timestamp;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x20")]
		public Func<int, bool> PointFilterF;

		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		[FieldOffset(Offset = "0x28")]
		public int LeafMaxPointCount;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x30")]
		public double FWNBeta;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x38")]
		public int FWNApproxOrder;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x40")]
		public Func<int, double> FWNAreaEstimateF;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, PointAABBTree3.FWNInfo> FastWindingCache;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x50")]
		private double[] FastWindingAreaCache;

		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0x58")]
		private int fast_winding_cache_timestamp;

		// Token: 0x0400102A RID: 4138
		[Token(Token = "0x400102A")]
		[FieldOffset(Offset = "0x60")]
		private DVector<int> box_to_index;

		// Token: 0x0400102B RID: 4139
		[Token(Token = "0x400102B")]
		[FieldOffset(Offset = "0x68")]
		private DVector<Vector3d> box_centers;

		// Token: 0x0400102C RID: 4140
		[Token(Token = "0x400102C")]
		[FieldOffset(Offset = "0x70")]
		private DVector<Vector3d> box_extents;

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x78")]
		private DVector<int> index_list;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x80")]
		private int points_end;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x84")]
		private int root_index;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		private const double box_eps = 1.1102230246251565E-14;

		// Token: 0x02000394 RID: 916
		[Token(Token = "0x2000394")]
		public enum BuildStrategy
		{
			// Token: 0x04001032 RID: 4146
			[Token(Token = "0x4001032")]
			Default,
			// Token: 0x04001033 RID: 4147
			[Token(Token = "0x4001033")]
			TopDownMidpoint,
			// Token: 0x04001034 RID: 4148
			[Token(Token = "0x4001034")]
			TopDownMedian
		}

		// Token: 0x02000395 RID: 917
		[Token(Token = "0x2000395")]
		public class TreeTraversal
		{
			// Token: 0x06001DD0 RID: 7632 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001DD0")]
			[Address(RVA = "0x1F8A9B0", Offset = "0x1F88FB0", VA = "0x181F8A9B0")]
			public TreeTraversal()
			{
			}

			// Token: 0x04001035 RID: 4149
			[Token(Token = "0x4001035")]
			[FieldOffset(Offset = "0x10")]
			public Func<AxisAlignedBox3d, int, bool> NextBoxF;

			// Token: 0x04001036 RID: 4150
			[Token(Token = "0x4001036")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> NextPointF;
		}

		// Token: 0x02000397 RID: 919
		[Token(Token = "0x2000397")]
		private struct FWNInfo
		{
			// Token: 0x0400103A RID: 4154
			[Token(Token = "0x400103A")]
			[FieldOffset(Offset = "0x0")]
			public Vector3d Center;

			// Token: 0x0400103B RID: 4155
			[Token(Token = "0x400103B")]
			[FieldOffset(Offset = "0x18")]
			public double R;

			// Token: 0x0400103C RID: 4156
			[Token(Token = "0x400103C")]
			[FieldOffset(Offset = "0x20")]
			public Vector3d Order1Vec;

			// Token: 0x0400103D RID: 4157
			[Token(Token = "0x400103D")]
			[FieldOffset(Offset = "0x38")]
			public Matrix3d Order2Mat;
		}

		// Token: 0x02000398 RID: 920
		[Token(Token = "0x2000398")]
		private class AxisComp : IComparer<Vector3d>
		{
			// Token: 0x06001DD5 RID: 7637 RVA: 0x00014F0C File Offset: 0x0001310C
			[Token(Token = "0x6001DD5")]
			[Address(RVA = "0x1F7B1E0", Offset = "0x1F797E0", VA = "0x181F7B1E0", Slot = "4")]
			public int Compare(Vector3d a, Vector3d b)
			{
				return 0;
			}

			// Token: 0x06001DD6 RID: 7638 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001DD6")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public AxisComp()
			{
			}

			// Token: 0x0400103E RID: 4158
			[Token(Token = "0x400103E")]
			[FieldOffset(Offset = "0x10")]
			public int Axis;
		}

		// Token: 0x02000399 RID: 921
		[Token(Token = "0x2000399")]
		private class boxes_set
		{
			// Token: 0x06001DD7 RID: 7639 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001DD7")]
			[Address(RVA = "0x1F8AD50", Offset = "0x1F89350", VA = "0x181F8AD50")]
			public boxes_set()
			{
			}

			// Token: 0x0400103F RID: 4159
			[Token(Token = "0x400103F")]
			[FieldOffset(Offset = "0x10")]
			public DVector<int> box_to_index;

			// Token: 0x04001040 RID: 4160
			[Token(Token = "0x4001040")]
			[FieldOffset(Offset = "0x18")]
			public DVector<Vector3d> box_centers;

			// Token: 0x04001041 RID: 4161
			[Token(Token = "0x4001041")]
			[FieldOffset(Offset = "0x20")]
			public DVector<Vector3d> box_extents;

			// Token: 0x04001042 RID: 4162
			[Token(Token = "0x4001042")]
			[FieldOffset(Offset = "0x28")]
			public DVector<int> index_list;

			// Token: 0x04001043 RID: 4163
			[Token(Token = "0x4001043")]
			[FieldOffset(Offset = "0x30")]
			public int iBoxCur;

			// Token: 0x04001044 RID: 4164
			[Token(Token = "0x4001044")]
			[FieldOffset(Offset = "0x34")]
			public int iIndicesCur;
		}
	}
}

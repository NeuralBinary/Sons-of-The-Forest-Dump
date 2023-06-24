using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000364 RID: 868
	[Token(Token = "0x2000364")]
	public class DMeshAABBTree3 : ISpatial
	{
		// Token: 0x06001CD8 RID: 7384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x1F6CD30", Offset = "0x1F6B330", VA = "0x181F6CD30")]
		public DMeshAABBTree3(DMesh3 m, bool autoBuild = false)
		{
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000460")]
		public DMesh3 Mesh
		{
			[Token(Token = "0x6001CD9")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x1F6CE00", Offset = "0x1F6B400", VA = "0x181F6CE00")]
		public void Build(DMeshAABBTree3.BuildStrategy eStrategy = DMeshAABBTree3.BuildStrategy.TopDownMidpoint, DMeshAABBTree3.ClusterPolicy ePolicy = DMeshAABBTree3.ClusterPolicy.Default)
		{
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x000143CC File Offset: 0x000125CC
		[Token(Token = "0x17000461")]
		public bool IsValid
		{
			[Token(Token = "0x6001CDB")]
			[Address(RVA = "0x1F6CE60", Offset = "0x1F6B460", VA = "0x181F6CE60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x000143E4 File Offset: 0x000125E4
		[Token(Token = "0x17000462")]
		public bool SupportsNearestTriangle
		{
			[Token(Token = "0x6001CDC")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000143FC File Offset: 0x000125FC
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x1F6CE90", Offset = "0x1F6B490", VA = "0x181F6CE90", Slot = "10")]
		public virtual int FindNearestTriangle(Vector3d p, double fMaxDist = 1.7976931348623157E+308)
		{
			return 0;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00014414 File Offset: 0x00012614
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x1F6CF70", Offset = "0x1F6B570", VA = "0x181F6CF70", Slot = "11")]
		public virtual int FindNearestTriangle(Vector3d p, out double fNearestDistSqr, double fMaxDist = 1.7976931348623157E+308)
		{
			return 0;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x1F6D050", Offset = "0x1F6B650", VA = "0x181F6D050")]
		protected void find_nearest_tri(int iBox, Vector3d p, ref double fNearestSqr, ref int tID)
		{
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0001442C File Offset: 0x0001262C
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x1F6D440", Offset = "0x1F6BA40", VA = "0x181F6D440", Slot = "12")]
		public virtual int FindNearestVertex(Vector3d p, double fMaxDist = 1.7976931348623157E+308)
		{
			return 0;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x1F6D520", Offset = "0x1F6BB20", VA = "0x181F6D520")]
		protected void find_nearest_vtx(int iBox, Vector3d p, ref double fNearestSqr, ref int vid)
		{
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00014444 File Offset: 0x00012644
		[Token(Token = "0x17000463")]
		public bool SupportsTriangleRayIntersection
		{
			[Token(Token = "0x6001CE2")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0001445C File Offset: 0x0001265C
		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x1F6DA10", Offset = "0x1F6C010", VA = "0x181F6DA10", Slot = "13")]
		public virtual int FindNearestHitTriangle(Ray3d ray, double fMaxDist = 1.7976931348623157E+308)
		{
			return 0;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x1F6DB50", Offset = "0x1F6C150", VA = "0x181F6DB50")]
		protected void find_hit_triangle(int iBox, ref Ray3d ray, ref double fNearestT, ref int tID)
		{
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00014474 File Offset: 0x00012674
		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x1F6DF20", Offset = "0x1F6C520", VA = "0x181F6DF20", Slot = "14")]
		public virtual int FindAllHitTriangles(Ray3d ray, [Optional] List<int> hitTriangles, double fMaxDist = 1.7976931348623157E+308)
		{
			return 0;
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0001448C File Offset: 0x0001268C
		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x1F6E050", Offset = "0x1F6C650", VA = "0x181F6E050")]
		protected int find_all_hit_triangles(int iBox, List<int> hitTriangles, ref Ray3d ray, double fMaxDist)
		{
			return 0;
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x000144A4 File Offset: 0x000126A4
		[Token(Token = "0x6001CE7")]
		[Address(RVA = "0x1F6E440", Offset = "0x1F6CA40", VA = "0x181F6E440", Slot = "15")]
		public virtual bool TestIntersection(IMesh testMesh, [Optional] Func<Vector3d, Vector3d> TransformF, bool bBoundsCheck = true)
		{
			return default(bool);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x000144BC File Offset: 0x000126BC
		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0x1F6E940", Offset = "0x1F6CF40", VA = "0x181F6E940", Slot = "16")]
		public virtual bool TestIntersection(Triangle3d triangle)
		{
			return default(bool);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000144D4 File Offset: 0x000126D4
		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x1F6EB10", Offset = "0x1F6D110", VA = "0x181F6EB10")]
		protected int find_any_intersection(int iBox, ref Triangle3d triangle, ref AxisAlignedBox3d triBounds)
		{
			return 0;
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x000144EC File Offset: 0x000126EC
		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x1F6EE10", Offset = "0x1F6D410", VA = "0x181F6EE10", Slot = "17")]
		public virtual bool TestIntersection(DMeshAABBTree3 otherTree, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return default(bool);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00014504 File Offset: 0x00012704
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x1F6EEC0", Offset = "0x1F6D4C0", VA = "0x181F6EEC0")]
		protected bool find_any_intersection(int iBox, DMeshAABBTree3 otherTree, Func<Vector3d, Vector3d> TransformF, int oBox, int depth)
		{
			return default(bool);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x1F6F770", Offset = "0x1F6DD70", VA = "0x181F6F770", Slot = "18")]
		public virtual DMeshAABBTree3.IntersectionsQueryResult FindAllIntersections(DMeshAABBTree3 otherTree, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return null;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x1F6FA30", Offset = "0x1F6E030", VA = "0x181F6FA30")]
		protected void find_intersections(int iBox, DMeshAABBTree3 otherTree, Func<Vector3d, Vector3d> TransformF, int oBox, int depth, IntrTriangle3Triangle3 intr, DMeshAABBTree3.IntersectionsQueryResult result)
		{
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0001451C File Offset: 0x0001271C
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x1F70520", Offset = "0x1F6EB20", VA = "0x181F70520", Slot = "19")]
		public virtual Index2i FindNearestTriangles(DMeshAABBTree3 otherTree, Func<Vector3d, Vector3d> TransformF, out double distance, double max_dist = 1.7976931348623157E+308)
		{
			return default(Index2i);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x1F706F0", Offset = "0x1F6ECF0", VA = "0x181F706F0")]
		protected void find_nearest_triangles(int iBox, DMeshAABBTree3 otherTree, Func<Vector3d, Vector3d> TransformF, int oBox, int depth, ref double nearest_sqr, ref Index2i nearest_pair)
		{
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00014534 File Offset: 0x00012734
		[Token(Token = "0x17000464")]
		public bool SupportsPointContainment
		{
			[Token(Token = "0x6001CF0")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0001454C File Offset: 0x0001274C
		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0x1F710A0", Offset = "0x1F6F6A0", VA = "0x181F710A0", Slot = "20")]
		public virtual bool IsInside(Vector3d p)
		{
			return default(bool);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0x1F71180", Offset = "0x1F6F780", VA = "0x181F71180", Slot = "21")]
		public virtual void DoTraversal(DMeshAABBTree3.TreeTraversal traversal)
		{
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0x1F71220", Offset = "0x1F6F820", VA = "0x181F71220", Slot = "22")]
		protected virtual void tree_traversal(int iBox, int depth, DMeshAABBTree3.TreeTraversal traversal)
		{
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00014564 File Offset: 0x00012764
		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x1F71590", Offset = "0x1F6FB90", VA = "0x181F71590", Slot = "23")]
		public virtual double WindingNumber(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0001457C File Offset: 0x0001277C
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x1F71780", Offset = "0x1F6FD80", VA = "0x181F71780")]
		protected double branch_winding_num(int iBox, Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x1F71CB0", Offset = "0x1F702B0", VA = "0x181F71CB0")]
		protected void build_winding_cache()
		{
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00014594 File Offset: 0x00012794
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x1F71DE0", Offset = "0x1F703E0", VA = "0x181F71DE0")]
		protected int build_winding_cache(int iBox, int depth, int tri_count_thresh, out HashSet<int> tri_hash)
		{
			return 0;
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x1F720D0", Offset = "0x1F706D0", VA = "0x181F720D0")]
		protected void make_box_winding_cache(int iBox, HashSet<int> triangles)
		{
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000145AC File Offset: 0x000127AC
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x1F72420", Offset = "0x1F70A20", VA = "0x181F72420")]
		protected double evaluate_box_winding_cache(int iBox, Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x1F727A0", Offset = "0x1F70DA0", VA = "0x181F727A0")]
		protected void collect_triangles(int iBox, HashSet<int> triangles)
		{
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000145C4 File Offset: 0x000127C4
		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x1F72990", Offset = "0x1F70F90", VA = "0x181F72990", Slot = "24")]
		public virtual double FastWindingNumber(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000145DC File Offset: 0x000127DC
		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x1F72BF0", Offset = "0x1F711F0", VA = "0x181F72BF0")]
		protected double branch_fast_winding_num(int iBox, Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x1F73080", Offset = "0x1F71680", VA = "0x181F73080")]
		protected void build_fast_winding_cache()
		{
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000145F4 File Offset: 0x000127F4
		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x1F73220", Offset = "0x1F71820", VA = "0x181F73220")]
		protected int build_fast_winding_cache(int iBox, int depth, int tri_count_thresh, out HashSet<int> tri_hash, MeshTriInfoCache triCache)
		{
			return 0;
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0001460C File Offset: 0x0001280C
		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x1F73660", Offset = "0x1F71C60", VA = "0x181F73660")]
		protected bool can_use_fast_winding_cache(int iBox, ref Vector3d q)
		{
			return default(bool);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x1F737B0", Offset = "0x1F71DB0", VA = "0x181F737B0")]
		protected void make_box_fast_winding_cache(int iBox, IEnumerable<int> triangles, MeshTriInfoCache triCache)
		{
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00014624 File Offset: 0x00012824
		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x1F73900", Offset = "0x1F71F00", VA = "0x181F73900")]
		protected double evaluate_box_fast_winding_cache(int iBox, ref Vector3d q)
		{
			return 0.0;
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0001463C File Offset: 0x0001283C
		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x1F73BE0", Offset = "0x1F721E0", VA = "0x181F73BE0")]
		public double TotalVolume()
		{
			return 0.0;
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00014654 File Offset: 0x00012854
		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x1F73D20", Offset = "0x1F72320", VA = "0x181F73D20")]
		public double TotalExtentSum()
		{
			return 0.0;
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0001466C File Offset: 0x0001286C
		[Token(Token = "0x17000465")]
		public AxisAlignedBox3d Bounds
		{
			[Token(Token = "0x6001D04")]
			[Address(RVA = "0x1F73E60", Offset = "0x1F72460", VA = "0x181F73E60")]
			get
			{
				return default(AxisAlignedBox3d);
			}
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x1F73FC0", Offset = "0x1F725C0", VA = "0x181F73FC0")]
		private void build_top_down(bool bSorted)
		{
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00014684 File Offset: 0x00012884
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x1F74C70", Offset = "0x1F73270", VA = "0x181F74C70")]
		private int split_tri_set_sorted(int[] triangles, Vector3d[] centers, int iStart, int iCount, int depth, int minTriCount, DMeshAABBTree3.boxes_set tris, DMeshAABBTree3.boxes_set nodes, out AxisAlignedBox3f box)
		{
			return 0;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0001469C File Offset: 0x0001289C
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x1F75370", Offset = "0x1F73970", VA = "0x181F75370")]
		private int split_tri_set_midpoint(int[] triangles, Vector3d[] centers, int iStart, int iCount, int depth, int minTriCount, DMeshAABBTree3.boxes_set tris, DMeshAABBTree3.boxes_set nodes, out AxisAlignedBox3f box)
		{
			return 0;
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x1F75CD0", Offset = "0x1F742D0", VA = "0x181F75CD0")]
		private void build_by_one_rings(DMeshAABBTree3.ClusterPolicy ePolicy)
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x000146B4 File Offset: 0x000128B4
		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x1F76630", Offset = "0x1F74C30", VA = "0x181F76630")]
		private int add_one_ring_box(int vid, byte[] used_triangles, int[] temp_tris, ref int iBoxCur, ref int iIndicesCur, DVector<int> spill, int nSpillThresh)
		{
			return 0;
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000146CC File Offset: 0x000128CC
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x1F76CE0", Offset = "0x1F752E0", VA = "0x181F76CE0")]
		private int cluster_boxes(int iStart, int iCount, ref int iBoxCur, ref int iIndicesCur)
		{
			return 0;
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000146E4 File Offset: 0x000128E4
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x1F77600", Offset = "0x1F75C00", VA = "0x181F77600")]
		private int cluster_boxes_nearsearch(int iStart, int iCount, ref int iBoxCur, ref int iIndicesCur)
		{
			return 0;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000146FC File Offset: 0x000128FC
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x1F77D00", Offset = "0x1F76300", VA = "0x181F77D00")]
		private static double find_smallest_upper(double[,] m, ref int ii, ref int jj)
		{
			return 0.0;
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00014714 File Offset: 0x00012914
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x1F77E30", Offset = "0x1F76430", VA = "0x181F77E30")]
		private int cluster_boxes_matrix(int iStart, int iCount, ref int iBoxCur, ref int iIndicesCur)
		{
			return 0;
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x1F78330", Offset = "0x1F76930", VA = "0x181F78330")]
		private void duplicate_box(int i, ref int iBoxCur, ref int iIndicesCur)
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x1F78500", Offset = "0x1F76B00", VA = "0x181F78500")]
		private void get_combined_box(int b0, int b1, out Vector3f center, out Vector3f extent)
		{
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0001472C File Offset: 0x0001292C
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x1F78920", Offset = "0x1F76F20", VA = "0x181F78920")]
		private AxisAlignedBox3f get_box(int iBox)
		{
			return default(AxisAlignedBox3f);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00014744 File Offset: 0x00012944
		[Token(Token = "0x6001D11")]
		[Address(RVA = "0x1F78B10", Offset = "0x1F77110", VA = "0x181F78B10")]
		private AxisAlignedBox3d get_boxd(int iBox)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0001475C File Offset: 0x0001295C
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x1F78D40", Offset = "0x1F77340", VA = "0x181F78D40")]
		private AxisAlignedBox3d get_boxd(int iBox, Func<Vector3d, Vector3d> TransformF)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00014774 File Offset: 0x00012974
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x1F78F50", Offset = "0x1F77550", VA = "0x181F78F50")]
		private double box_ray_intersect_t(int iBox, Ray3d ray)
		{
			return 0.0;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0001478C File Offset: 0x0001298C
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x1F79280", Offset = "0x1F77880", VA = "0x181F79280")]
		private bool box_box_intersect(int iBox, ref AxisAlignedBox3d testBox)
		{
			return default(bool);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x000147A4 File Offset: 0x000129A4
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x1F794E0", Offset = "0x1F77AE0", VA = "0x181F794E0")]
		private double box_box_distsqr(int iBox, ref AxisAlignedBox3d testBox)
		{
			return 0.0;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x000147BC File Offset: 0x000129BC
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x1F79730", Offset = "0x1F77D30", VA = "0x181F79730")]
		private double box_distance_sqr(int iBox, Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000147D4 File Offset: 0x000129D4
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x1F799C0", Offset = "0x1F77FC0", VA = "0x181F799C0")]
		protected bool box_contains(int iBox, Vector3d p)
		{
			return default(bool);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000147EC File Offset: 0x000129EC
		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x1F79C20", Offset = "0x1F78220", VA = "0x181F79C20")]
		private double combined_box_volume(int b0, int b1)
		{
			return 0.0;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00014804 File Offset: 0x00012A04
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x1F79FE0", Offset = "0x1F785E0", VA = "0x181F79FE0")]
		private double combined_box_length(int b0, int b1)
		{
			return 0.0;
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x1F7A3B0", Offset = "0x1F789B0", VA = "0x181F7A3B0")]
		public void TestCoverage()
		{
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x1F7A6A0", Offset = "0x1F78CA0", VA = "0x181F7A6A0")]
		private void test_coverage(int[] tri_counts, int[] parent_indices, int iBox)
		{
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x1F7AAB0", Offset = "0x1F790B0", VA = "0x181F7AAB0")]
		private void debug_check_child_tri_distances(int iBox, Vector3d p)
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x1F7AC80", Offset = "0x1F79280", VA = "0x181F7AC80")]
		private void debug_check_child_tris_in_box(int iBox)
		{
		}

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected DMesh3 mesh;

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int mesh_timestamp;

		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<int, bool> TriangleFilterF;

		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int TopDownLeafMaxTriCount;

		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int BottomUpClusterLookahead;

		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, List<int>> WindingCache;

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int winding_cache_timestamp;

		// Token: 0x04000F65 RID: 3941
		[Token(Token = "0x4000F65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public double FWNBeta;

		// Token: 0x04000F66 RID: 3942
		[Token(Token = "0x4000F66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int FWNApproxOrder;

		// Token: 0x04000F67 RID: 3943
		[Token(Token = "0x4000F67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, DMeshAABBTree3.FWNInfo> FastWindingCache;

		// Token: 0x04000F68 RID: 3944
		[Token(Token = "0x4000F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int fast_winding_cache_timestamp;

		// Token: 0x04000F69 RID: 3945
		[Token(Token = "0x4000F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected DVector<int> box_to_index;

		// Token: 0x04000F6A RID: 3946
		[Token(Token = "0x4000F6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected DVector<Vector3f> box_centers;

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected DVector<Vector3f> box_extents;

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected DVector<int> index_list;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected int triangles_end;

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected int root_index;

		// Token: 0x04000F6F RID: 3951
		[Token(Token = "0x4000F6F")]
		private const float box_eps = 5.9604645E-06f;

		// Token: 0x02000365 RID: 869
		[Token(Token = "0x2000365")]
		public enum BuildStrategy
		{
			// Token: 0x04000F71 RID: 3953
			[Token(Token = "0x4000F71")]
			Default,
			// Token: 0x04000F72 RID: 3954
			[Token(Token = "0x4000F72")]
			TopDownMidpoint,
			// Token: 0x04000F73 RID: 3955
			[Token(Token = "0x4000F73")]
			BottomUpFromOneRings,
			// Token: 0x04000F74 RID: 3956
			[Token(Token = "0x4000F74")]
			TopDownMedian
		}

		// Token: 0x02000366 RID: 870
		[Token(Token = "0x2000366")]
		public enum ClusterPolicy
		{
			// Token: 0x04000F76 RID: 3958
			[Token(Token = "0x4000F76")]
			Default,
			// Token: 0x04000F77 RID: 3959
			[Token(Token = "0x4000F77")]
			Fastest,
			// Token: 0x04000F78 RID: 3960
			[Token(Token = "0x4000F78")]
			FastVolumeMetric,
			// Token: 0x04000F79 RID: 3961
			[Token(Token = "0x4000F79")]
			MinimalVolume
		}

		// Token: 0x02000367 RID: 871
		[Token(Token = "0x2000367")]
		public struct PointIntersection
		{
			// Token: 0x04000F7A RID: 3962
			[Token(Token = "0x4000F7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int t0;

			// Token: 0x04000F7B RID: 3963
			[Token(Token = "0x4000F7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int t1;

			// Token: 0x04000F7C RID: 3964
			[Token(Token = "0x4000F7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3d point;
		}

		// Token: 0x02000368 RID: 872
		[Token(Token = "0x2000368")]
		public struct SegmentIntersection
		{
			// Token: 0x04000F7D RID: 3965
			[Token(Token = "0x4000F7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int t0;

			// Token: 0x04000F7E RID: 3966
			[Token(Token = "0x4000F7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int t1;

			// Token: 0x04000F7F RID: 3967
			[Token(Token = "0x4000F7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3d point0;

			// Token: 0x04000F80 RID: 3968
			[Token(Token = "0x4000F80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3d point1;
		}

		// Token: 0x02000369 RID: 873
		[Token(Token = "0x2000369")]
		public class IntersectionsQueryResult
		{
			// Token: 0x06001D1E RID: 7454 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001D1E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public IntersectionsQueryResult()
			{
			}

			// Token: 0x04000F81 RID: 3969
			[Token(Token = "0x4000F81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<DMeshAABBTree3.PointIntersection> Points;

			// Token: 0x04000F82 RID: 3970
			[Token(Token = "0x4000F82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<DMeshAABBTree3.SegmentIntersection> Segments;
		}

		// Token: 0x0200036A RID: 874
		[Token(Token = "0x200036A")]
		public class TreeTraversal
		{
			// Token: 0x06001D1F RID: 7455 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001D1F")]
			[Address(RVA = "0x1F7AE40", Offset = "0x1F79440", VA = "0x181F7AE40")]
			public TreeTraversal()
			{
			}

			// Token: 0x04000F83 RID: 3971
			[Token(Token = "0x4000F83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<AxisAlignedBox3f, int, bool> NextBoxF;

			// Token: 0x04000F84 RID: 3972
			[Token(Token = "0x4000F84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<int> NextTriangleF;
		}

		// Token: 0x0200036C RID: 876
		[Token(Token = "0x200036C")]
		private struct FWNInfo
		{
			// Token: 0x04000F88 RID: 3976
			[Token(Token = "0x4000F88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3d Center;

			// Token: 0x04000F89 RID: 3977
			[Token(Token = "0x4000F89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public double R;

			// Token: 0x04000F8A RID: 3978
			[Token(Token = "0x4000F8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3d Order1Vec;

			// Token: 0x04000F8B RID: 3979
			[Token(Token = "0x4000F8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Matrix3d Order2Mat;
		}

		// Token: 0x0200036D RID: 877
		[Token(Token = "0x200036D")]
		private class AxisComp : IComparer<Vector3d>
		{
			// Token: 0x06001D24 RID: 7460 RVA: 0x00014834 File Offset: 0x00012A34
			[Token(Token = "0x6001D24")]
			[Address(RVA = "0x1F7B1E0", Offset = "0x1F797E0", VA = "0x181F7B1E0", Slot = "4")]
			public int Compare(Vector3d a, Vector3d b)
			{
				return 0;
			}

			// Token: 0x06001D25 RID: 7461 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001D25")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public AxisComp()
			{
			}

			// Token: 0x04000F8C RID: 3980
			[Token(Token = "0x4000F8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int Axis;
		}

		// Token: 0x0200036E RID: 878
		[Token(Token = "0x200036E")]
		private class boxes_set
		{
			// Token: 0x06001D26 RID: 7462 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001D26")]
			[Address(RVA = "0x1F7B270", Offset = "0x1F79870", VA = "0x181F7B270")]
			public boxes_set()
			{
			}

			// Token: 0x04000F8D RID: 3981
			[Token(Token = "0x4000F8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DVector<int> box_to_index;

			// Token: 0x04000F8E RID: 3982
			[Token(Token = "0x4000F8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DVector<Vector3f> box_centers;

			// Token: 0x04000F8F RID: 3983
			[Token(Token = "0x4000F8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DVector<Vector3f> box_extents;

			// Token: 0x04000F90 RID: 3984
			[Token(Token = "0x4000F90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DVector<int> index_list;

			// Token: 0x04000F91 RID: 3985
			[Token(Token = "0x4000F91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int iBoxCur;

			// Token: 0x04000F92 RID: 3986
			[Token(Token = "0x4000F92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int iIndicesCur;
		}

		// Token: 0x0200036F RID: 879
		// (Invoke) Token: 0x06001D28 RID: 7464
		[Token(Token = "0x200036F")]
		public delegate int ClusterFunctionType(int iStart, int iCount, ref int iBoxCur, ref int iIndicesCur);
	}
}

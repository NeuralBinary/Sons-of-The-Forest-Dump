using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	public class MeshSignedDistanceGrid
	{
		// Token: 0x06001D82 RID: 7554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D82")]
		[Address(RVA = "0x1F7D380", Offset = "0x1F7B980", VA = "0x181F7D380")]
		public MeshSignedDistanceGrid(DMesh3 mesh, double cellSize, [Optional] DMeshAABBTree3 spatial)
		{
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D83")]
		[Address(RVA = "0x1F7D650", Offset = "0x1F7BC50", VA = "0x181F7D650")]
		public void Compute()
		{
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x00014BF4 File Offset: 0x00012DF4
		[Token(Token = "0x1700046E")]
		public Vector3i Dimensions
		{
			[Token(Token = "0x6001D84")]
			[Address(RVA = "0x1F7DB20", Offset = "0x1F7C120", VA = "0x181F7DB20")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700046F")]
		public DenseGrid3f Grid
		{
			[Token(Token = "0x6001D85")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x00014C0C File Offset: 0x00012E0C
		[Token(Token = "0x17000470")]
		public Vector3f GridOrigin
		{
			[Token(Token = "0x6001D86")]
			[Address(RVA = "0x1F7DB50", Offset = "0x1F7C150", VA = "0x181F7DB50")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000471")]
		public DenseGrid3i ClosestTriGrid
		{
			[Token(Token = "0x6001D87")]
			[Address(RVA = "0x1F7DB70", Offset = "0x1F7C170", VA = "0x181F7DB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000472")]
		public DenseGrid3i IntersectionsGrid
		{
			[Token(Token = "0x6001D88")]
			[Address(RVA = "0x1F7DBE0", Offset = "0x1F7C1E0", VA = "0x181F7DBE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000473 RID: 1139
		[Token(Token = "0x17000473")]
		public float this[int i, int j, int k]
		{
			[Token(Token = "0x6001D89")]
			[Address(RVA = "0x1F7DC50", Offset = "0x1F7C250", VA = "0x181F7DC50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000474 RID: 1140
		[Token(Token = "0x17000474")]
		public float this[Vector3i idx]
		{
			[Token(Token = "0x6001D8A")]
			[Address(RVA = "0x1F7DCA0", Offset = "0x1F7C2A0", VA = "0x181F7DCA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x00014C54 File Offset: 0x00012E54
		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0x1F7DCF0", Offset = "0x1F7C2F0", VA = "0x181F7DCF0")]
		public Vector3f CellCenter(int i, int j, int k)
		{
			return default(Vector3f);
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x00014C6C File Offset: 0x00012E6C
		[Token(Token = "0x6001D8C")]
		[Address(RVA = "0x1F7DD60", Offset = "0x1F7C360", VA = "0x181F7DD60")]
		private Vector3f cell_center(Vector3i ijk)
		{
			return default(Vector3f);
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00014C84 File Offset: 0x00012E84
		[Token(Token = "0x6001D8D")]
		[Address(RVA = "0x1F7DDB0", Offset = "0x1F7C3B0", VA = "0x181F7DDB0")]
		private float upper_bound(DenseGrid3f grid)
		{
			return 0f;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00014C9C File Offset: 0x00012E9C
		[Token(Token = "0x6001D8E")]
		[Address(RVA = "0x1F7DDE0", Offset = "0x1F7C3E0", VA = "0x181F7DDE0")]
		private float cell_tri_dist(Vector3i idx, int tid)
		{
			return 0f;
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D8F")]
		[Address(RVA = "0x1F7DF50", Offset = "0x1F7C550", VA = "0x181F7DF50")]
		private void make_level_set3(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3f distances, int exact_band)
		{
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D90")]
		[Address(RVA = "0x1F7EBA0", Offset = "0x1F7D1A0", VA = "0x181F7EBA0")]
		private void make_level_set3_parallel(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3f distances, int exact_band)
		{
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D91")]
		[Address(RVA = "0x1F7F2D0", Offset = "0x1F7D8D0", VA = "0x181F7F2D0")]
		private void make_level_set3_parallel_spatial(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3f distances, int exact_band)
		{
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D92")]
		[Address(RVA = "0x1F7FA60", Offset = "0x1F7E060", VA = "0x181F7FA60")]
		private void make_level_set3_parallel_floodfill(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3f distances, int exact_band)
		{
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x1F805C0", Offset = "0x1F7EBC0", VA = "0x181F805C0")]
		private void sweep_pass(Vector3f origin, float dx, DenseGrid3f distances, DenseGrid3i closest_tri)
		{
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D94")]
		[Address(RVA = "0x1F80930", Offset = "0x1F7EF30", VA = "0x181F80930")]
		private void sweep(DenseGrid3f phi, DenseGrid3i closest_tri, Vector3f origin, float dx, int di, int dj, int dk)
		{
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x1F80D40", Offset = "0x1F7F340", VA = "0x181F80D40")]
		private void check_neighbour(DenseGrid3f phi, DenseGrid3i closest_tri, ref Vector3d gx, int i0, int j0, int k0, int i1, int j1, int k1)
		{
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x1F81010", Offset = "0x1F7F610", VA = "0x181F81010")]
		private void compute_intersections(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3i intersection_count)
		{
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x1F813A0", Offset = "0x1F7F9A0", VA = "0x181F813A0")]
		private void compute_signs(int ni, int nj, int nk, DenseGrid3f distances, DenseGrid3i intersection_counts)
		{
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00014CB4 File Offset: 0x00012EB4
		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x1F81A20", Offset = "0x1F80020", VA = "0x181F81A20")]
		public static float point_segment_distance(ref Vector3f x0, ref Vector3f x1, ref Vector3f x2)
		{
			return 0f;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00014CCC File Offset: 0x00012ECC
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x1F81C10", Offset = "0x1F80210", VA = "0x181F81C10")]
		public static double point_segment_distance(ref Vector3d x0, ref Vector3d x1, ref Vector3d x2)
		{
			return 0.0;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00014CE4 File Offset: 0x00012EE4
		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x1F81DF0", Offset = "0x1F803F0", VA = "0x181F81DF0")]
		public static float point_triangle_distance(ref Vector3f x0, ref Vector3f x1, ref Vector3f x2, ref Vector3f x3)
		{
			return 0f;
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00014CFC File Offset: 0x00012EFC
		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x1F82260", Offset = "0x1F80860", VA = "0x181F82260")]
		public static double point_triangle_distance(ref Vector3d x0, ref Vector3d x1, ref Vector3d x2, ref Vector3d x3)
		{
			return 0.0;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00014D14 File Offset: 0x00012F14
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x1F826E0", Offset = "0x1F80CE0", VA = "0x181F826E0")]
		public static int orientation(double x1, double y1, double x2, double y2, out double twice_signed_area)
		{
			return 0;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00014D2C File Offset: 0x00012F2C
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x1F82740", Offset = "0x1F80D40", VA = "0x181F82740")]
		public static bool point_in_triangle_2d(double x0, double y0, double x1, double y1, double x2, double y2, double x3, double y3, out double a, out double b, out double c)
		{
			return default(bool);
		}

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DMeshAABBTree3 Spatial;

		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CellSize;

		// Token: 0x04000FBD RID: 4029
		[Token(Token = "0x4000FBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int ExactBandWidth;

		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3d ExpandBounds;

		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseParallel;

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public MeshSignedDistanceGrid.ComputeModes ComputeMode;

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double NarrowBandMaxDistance;

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool ComputeSigns;

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MeshSignedDistanceGrid.InsideModes InsideMode;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool WantClosestTriGrid;

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool WantIntersectionsGrid;

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Func<bool> CancelF;

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool DebugPrint;

		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3f grid_origin;

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DenseGrid3f grid;

		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DenseGrid3i closest_tri_grid;

		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DenseGrid3i intersections_grid;

		// Token: 0x0200038A RID: 906
		[Token(Token = "0x200038A")]
		public enum ComputeModes
		{
			// Token: 0x04000FCD RID: 4045
			[Token(Token = "0x4000FCD")]
			FullGrid,
			// Token: 0x04000FCE RID: 4046
			[Token(Token = "0x4000FCE")]
			NarrowBandOnly,
			// Token: 0x04000FCF RID: 4047
			[Token(Token = "0x4000FCF")]
			NarrowBand_SpatialFloodFill
		}

		// Token: 0x0200038B RID: 907
		[Token(Token = "0x200038B")]
		public enum InsideModes
		{
			// Token: 0x04000FD1 RID: 4049
			[Token(Token = "0x4000FD1")]
			CrossingCount,
			// Token: 0x04000FD2 RID: 4050
			[Token(Token = "0x4000FD2")]
			ParityCount
		}
	}
}

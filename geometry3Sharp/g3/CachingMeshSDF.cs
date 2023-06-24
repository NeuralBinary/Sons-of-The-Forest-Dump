using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	public class CachingMeshSDF
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1FEC3D0", Offset = "0x1FEA9D0", VA = "0x181FEC3D0")]
		public CachingMeshSDF(DMesh3 mesh, double cellSize, DMeshAABBTree3 spatial)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1FEC690", Offset = "0x1FEAC90", VA = "0x181FEC690")]
		public void Initialize()
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000071CC File Offset: 0x000053CC
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1FECCA0", Offset = "0x1FEB2A0", VA = "0x181FECCA0")]
		public float GetValue(Vector3i idx)
		{
			return 0f;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x000071E4 File Offset: 0x000053E4
		[Token(Token = "0x170001AD")]
		public Vector3i Dimensions
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x1FECFE0", Offset = "0x1FEB5E0", VA = "0x181FECFE0")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001AE")]
		public DenseGrid3f Grid
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x000071FC File Offset: 0x000053FC
		[Token(Token = "0x170001AF")]
		public Vector3f GridOrigin
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x1FED010", Offset = "0x1FEB610", VA = "0x181FED010")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001B0")]
		public DenseGrid3i ClosestTriGrid
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x1FED030", Offset = "0x1FEB630", VA = "0x181FED030")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001B1")]
		public DenseGrid3i IntersectionsGrid
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x1FED0A0", Offset = "0x1FEB6A0", VA = "0x181FED0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B2 RID: 434
		[Token(Token = "0x170001B2")]
		public float this[int i, int j, int k]
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x1FED110", Offset = "0x1FEB710", VA = "0x181FED110")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001B3 RID: 435
		[Token(Token = "0x170001B3")]
		public float this[Vector3i idx]
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x1FED160", Offset = "0x1FEB760", VA = "0x181FED160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00007244 File Offset: 0x00005444
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1FED1B0", Offset = "0x1FEB7B0", VA = "0x181FED1B0")]
		public Vector3f CellCenter(int i, int j, int k)
		{
			return default(Vector3f);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0000725C File Offset: 0x0000545C
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1FED220", Offset = "0x1FEB820", VA = "0x181FED220")]
		private Vector3f cell_center(Vector3i ijk)
		{
			return default(Vector3f);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x1FED270", Offset = "0x1FEB870", VA = "0x181FED270")]
		private void compute_intersections(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3i intersection_count)
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1FED600", Offset = "0x1FEBC00", VA = "0x181FED600")]
		private void compute_signs(int ni, int nj, int nk, DenseGrid3f distances, DenseGrid3i intersection_counts)
		{
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00007274 File Offset: 0x00005474
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1F826E0", Offset = "0x1F80CE0", VA = "0x181F826E0")]
		public static int orientation(double x1, double y1, double x2, double y2, out double twice_signed_area)
		{
			return 0;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0000728C File Offset: 0x0000548C
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1FEDC80", Offset = "0x1FEC280", VA = "0x181FEDC80")]
		public static bool point_in_triangle_2d(double x0, double y0, double x1, double y1, double x2, double y2, double x3, double y3, out double a, out double b, out double c)
		{
			return default(bool);
		}

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x18")]
		public DMeshAABBTree3 Spatial;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x20")]
		public float CellSize;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x28")]
		public Vector3d ExpandBounds;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x40")]
		public float MaxOffsetDistance;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x44")]
		public bool UseParallel;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x45")]
		public bool ComputeSigns;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x48")]
		public CachingMeshSDF.InsideModes InsideMode;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x4C")]
		public bool WantClosestTriGrid;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x4D")]
		public bool WantIntersectionsGrid;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x50")]
		public Func<bool> CancelF;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x58")]
		public bool DebugPrint;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3f grid_origin;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x68")]
		private DenseGrid3f grid;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x70")]
		private DenseGrid3i closest_tri_grid;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x78")]
		private DenseGrid3i intersections_grid;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x80")]
		private float UpperBoundDistance;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x88")]
		private double MaxDistQueryDist;

		// Token: 0x02000155 RID: 341
		[Token(Token = "0x2000155")]
		public enum InsideModes
		{
			// Token: 0x0400054B RID: 1355
			[Token(Token = "0x400054B")]
			CrossingCount,
			// Token: 0x0400054C RID: 1356
			[Token(Token = "0x400054C")]
			ParityCount
		}
	}
}

using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public class MinimalHoleFill
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1E0B3C0", Offset = "0x1E099C0", VA = "0x181E0B3C0")]
		public MinimalHoleFill(DMesh3 mesh, EdgeLoop fillLoop)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1E0B480", Offset = "0x1E09A80", VA = "0x181E0B480")]
		public bool Apply()
		{
			return default(bool);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1E0D420", Offset = "0x1E0BA20", VA = "0x181E0D420")]
		private void remove_remaining_interior_verts()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1E0D860", Offset = "0x1E0BE60", VA = "0x181E0D860")]
		private void add_all_edges(int ei, HashSet<int> edge_set)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1E0DA00", Offset = "0x1E0C000", VA = "0x181E0DA00")]
		private double area_metric(int eid)
		{
			return 0.0;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1E0DC90", Offset = "0x1E0C290", VA = "0x181E0DC90")]
		private double aspect_metric(int eid)
		{
			return 0.0;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1E0DEE0", Offset = "0x1E0C4E0", VA = "0x181E0DEE0")]
		private void update_curvature(int vid)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1E0E210", Offset = "0x1E0C810", VA = "0x181E0E210")]
		private double curvature_metric_cached(int a, int b, int c, int d)
		{
			return 0.0;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1E0E330", Offset = "0x1E0C930", VA = "0x181E0E330")]
		private double curvature_metric_eval(int a, int b, int c, int d)
		{
			return 0.0;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1E0E430", Offset = "0x1E0CA30", VA = "0x181E0E430")]
		private double compute_gauss_curvature(int vid)
		{
			return 0.0;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1E0E720", Offset = "0x1E0CD20", VA = "0x181E0E720")]
		private Vector3d get_tri_normal(DMesh3 mesh, Index3i tri)
		{
			return default(Vector3d);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1E0E8C0", Offset = "0x1E0CEC0", VA = "0x181E0E8C0")]
		private double get_tri_area(DMesh3 mesh, ref Index3i tri)
		{
			return 0.0;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1E0EB00", Offset = "0x1E0D100", VA = "0x181E0EB00")]
		private double get_tri_aspect(DMesh3 mesh, ref Index3i tri)
		{
			return 0.0;
		}

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x18")]
		public EdgeLoop FillLoop;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x20")]
		public bool IgnoreBoundaryTriangles;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x21")]
		public bool OptimizeDevelopability;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x22")]
		public bool OptimizeTriangles;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x28")]
		public double DevelopabilityTolerance;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x30")]
		public int[] FillVertices;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x38")]
		public int[] FillTriangles;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x40")]
		private RegionOperator regionop;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x48")]
		private DMesh3 fillmesh;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x50")]
		private HashSet<int> boundaryv;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<int, double> exterior_angle_sums;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x60")]
		private double[] curvatures;
	}
}

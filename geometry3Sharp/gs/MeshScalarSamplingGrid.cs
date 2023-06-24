using System;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class MeshScalarSamplingGrid
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1E12F80", Offset = "0x1E11580", VA = "0x181E12F80")]
		public MeshScalarSamplingGrid(DMesh3 mesh, double cellSize, Func<Vector3d, double> scalarF)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1E131E0", Offset = "0x1E117E0", VA = "0x181E131E0")]
		public void Compute()
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x1700000D")]
		public Vector3i Dimensions
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x1E13550", Offset = "0x1E11B50", VA = "0x181E13550")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700000E")]
		public DenseGrid3f Grid
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x1700000F")]
		public Vector3f GridOrigin
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x1E13580", Offset = "0x1E11B80", VA = "0x181E13580")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000010")]
		public MeshSignedDistanceGrid SDFGrid
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000011 RID: 17
		[Token(Token = "0x17000011")]
		public float this[int i, int j, int k]
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x1E135A0", Offset = "0x1E11BA0", VA = "0x181E135A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1E135F0", Offset = "0x1E11BF0", VA = "0x181E135F0")]
		public Vector3f CellCenter(int i, int j, int k)
		{
			return default(Vector3f);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1E13670", Offset = "0x1E11C70", VA = "0x181E13670")]
		private void make_grid(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3f scalars)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1E14DE0", Offset = "0x1E133E0", VA = "0x181E14DE0")]
		private void make_grid_dense(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3f scalars)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1E14FC0", Offset = "0x1E135C0", VA = "0x181E14FC0")]
		private void fill_spans(int ni, int nj, int nk, DenseGrid3f scalars)
		{
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x18")]
		public Func<Vector3d, double> ScalarF;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x20")]
		public double CellSize;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x28")]
		public int BufferCells;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x2C")]
		public MeshScalarSamplingGrid.ComputeModes ComputeMode;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x30")]
		public float IsoValue;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x34")]
		public bool WantMeshSDFGrid;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x38")]
		public Func<bool> CancelF;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x40")]
		public bool DebugPrint;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x44")]
		private Vector3f grid_origin;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x50")]
		private DenseGrid3f scalar_grid;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x58")]
		private MeshSignedDistanceGrid mesh_sdf;

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		public enum ComputeModes
		{
			// Token: 0x040000F7 RID: 247
			[Token(Token = "0x40000F7")]
			FullGrid,
			// Token: 0x040000F8 RID: 248
			[Token(Token = "0x40000F8")]
			NarrowBand
		}
	}
}

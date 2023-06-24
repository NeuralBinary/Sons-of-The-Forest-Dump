using System;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class MeshWindingNumberGrid
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1E15BB0", Offset = "0x1E141B0", VA = "0x181E15BB0")]
		public MeshWindingNumberGrid(DMesh3 mesh, DMeshAABBTree3 spatial, double cellSize)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1E15E10", Offset = "0x1E14410", VA = "0x181E15E10")]
		public void Compute()
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x17000012")]
		public Vector3i Dimensions
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1E13550", Offset = "0x1E11B50", VA = "0x181E13550")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000013")]
		public DenseGrid3f Grid
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x17000014")]
		public Vector3f GridOrigin
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1E13580", Offset = "0x1E11B80", VA = "0x181E13580")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000015")]
		public MeshSignedDistanceGrid SDFGrid
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		[Token(Token = "0x17000016")]
		public float this[int i, int j, int k]
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1E135A0", Offset = "0x1E11BA0", VA = "0x181E135A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1E135F0", Offset = "0x1E11BF0", VA = "0x181E135F0")]
		public Vector3f CellCenter(int i, int j, int k)
		{
			return default(Vector3f);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1E16180", Offset = "0x1E14780", VA = "0x181E16180")]
		private void make_grid(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3f winding)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1E17960", Offset = "0x1E15F60", VA = "0x181E17960")]
		private void make_grid_dense(Vector3f origin, float dx, int ni, int nj, int nk, DenseGrid3f winding)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1E17BC0", Offset = "0x1E161C0", VA = "0x181E17BC0")]
		private void fill_spans(int ni, int nj, int nk, DenseGrid3f winding)
		{
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x18")]
		public DMeshAABBTree3 MeshSpatial;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x20")]
		public double CellSize;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x28")]
		public int BufferCells;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x2C")]
		public MeshWindingNumberGrid.ComputeModes ComputeMode;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x30")]
		public float WindingIsoValue;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x34")]
		public bool WantMeshSDFGrid;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x38")]
		public Func<bool> CancelF;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x40")]
		public bool DebugPrint;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x44")]
		private Vector3f grid_origin;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x50")]
		private DenseGrid3f winding_grid;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x58")]
		private MeshSignedDistanceGrid mesh_sdf;

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		public enum ComputeModes
		{
			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			FullGrid,
			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			NarrowBand
		}
	}
}

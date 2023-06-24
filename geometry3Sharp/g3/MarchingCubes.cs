using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x20002B4")]
	public class MarchingCubes
	{
		// Token: 0x060018A3 RID: 6307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x1EDE380", Offset = "0x1EDC980", VA = "0x181EDE380")]
		public MarchingCubes()
		{
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x1EDE640", Offset = "0x1EDCC40", VA = "0x181EDE640")]
		public void Generate()
		{
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x1EDEA30", Offset = "0x1EDD030", VA = "0x181EDEA30")]
		private void GridToPos(int x, int y, int z, ref Vector3d p)
		{
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x1EDEA80", Offset = "0x1EDD080", VA = "0x181EDEA80")]
		private void initialize_cell(MarchingCubes.GridCell cell, ref Vector3i idx)
		{
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x1EDEF40", Offset = "0x1EDD540", VA = "0x181EDEF40")]
		private void shift_cell_x(MarchingCubes.GridCell cell, int xi)
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x1EDF280", Offset = "0x1EDD880", VA = "0x181EDF280")]
		private void generate_parallel()
		{
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x1EDF370", Offset = "0x1EDD970", VA = "0x181EDF370")]
		private void generate_basic()
		{
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x000123A4 File Offset: 0x000105A4
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x1EDF4E0", Offset = "0x1EDDAE0", VA = "0x181EDF4E0")]
		private bool polygonize_cell(MarchingCubes.GridCell cell, Vector3d[] vertList)
		{
			return default(bool);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x000123BC File Offset: 0x000105BC
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x1EDF960", Offset = "0x1EDDF60", VA = "0x181EDF960")]
		private int find_or_append_vertex(ref Vector3d pos)
		{
			return 0;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x000123D4 File Offset: 0x000105D4
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x1EDFC80", Offset = "0x1EDE280", VA = "0x181EDFC80")]
		private int append_vertex(Vector3d v)
		{
			return 0;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x000123EC File Offset: 0x000105EC
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x1EDFE00", Offset = "0x1EDE400", VA = "0x181EDFE00")]
		private int append_triangle(int a, int b, int c)
		{
			return 0;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x1EDFF40", Offset = "0x1EDE540", VA = "0x181EDFF40")]
		private void find_iso(ref Vector3d p1, ref Vector3d p2, double valp1, double valp2, ref Vector3d pIso)
		{
		}

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x10")]
		public ImplicitFunction3d Implicit;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x18")]
		public double IsoValue;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x20")]
		public AxisAlignedBox3d Bounds;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x50")]
		public double CubeSize;

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x58")]
		public bool ParallelCompute;

		// Token: 0x04000BF2 RID: 3058
		[Token(Token = "0x4000BF2")]
		[FieldOffset(Offset = "0x5C")]
		public MarchingCubes.RootfindingModes RootMode;

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x60")]
		public int RootModeSteps;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x68")]
		public Func<bool> CancelF;

		// Token: 0x04000BF5 RID: 3061
		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x70")]
		public Vector3i CellDimensions;

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x80")]
		public DMesh3 Mesh;

		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<Vector3d, int> VertexHash;

		// Token: 0x04000BF8 RID: 3064
		[Token(Token = "0x4000BF8")]
		[FieldOffset(Offset = "0x90")]
		private bool bParallel;

		// Token: 0x04000BF9 RID: 3065
		[Token(Token = "0x4000BF9")]
		[FieldOffset(Offset = "0x94")]
		private SpinLock hash_lock;

		// Token: 0x04000BFA RID: 3066
		[Token(Token = "0x4000BFA")]
		[FieldOffset(Offset = "0x98")]
		private SpinLock mesh_lock;

		// Token: 0x04000BFB RID: 3067
		[Token(Token = "0x4000BFB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[,] edge_indices;

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] edgeTable;

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[,] triTable;

		// Token: 0x020002B5 RID: 693
		[Token(Token = "0x20002B5")]
		public enum RootfindingModes
		{
			// Token: 0x04000BFF RID: 3071
			[Token(Token = "0x4000BFF")]
			SingleLerp,
			// Token: 0x04000C00 RID: 3072
			[Token(Token = "0x4000C00")]
			LerpSteps,
			// Token: 0x04000C01 RID: 3073
			[Token(Token = "0x4000C01")]
			Bisection
		}

		// Token: 0x020002B6 RID: 694
		[Token(Token = "0x20002B6")]
		private class GridCell
		{
			// Token: 0x060018B1 RID: 6321 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60018B1")]
			[Address(RVA = "0x1EE0A00", Offset = "0x1EDF000", VA = "0x181EE0A00")]
			public GridCell()
			{
			}

			// Token: 0x04000C02 RID: 3074
			[Token(Token = "0x4000C02")]
			[FieldOffset(Offset = "0x10")]
			public Vector3d[] p;

			// Token: 0x04000C03 RID: 3075
			[Token(Token = "0x4000C03")]
			[FieldOffset(Offset = "0x18")]
			public double[] f;
		}
	}
}

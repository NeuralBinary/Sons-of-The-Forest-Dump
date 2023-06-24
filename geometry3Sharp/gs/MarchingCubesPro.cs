using System;
using System.Collections.Generic;
using System.Threading;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class MarchingCubesPro
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1DF7AC0", Offset = "0x1DF60C0", VA = "0x181DF7AC0")]
		public MarchingCubesPro()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1DF7E90", Offset = "0x1DF6490", VA = "0x181DF7E90")]
		public void Generate()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1DF84B0", Offset = "0x1DF6AB0", VA = "0x181DF84B0")]
		public void GenerateContinuation(IEnumerable<Vector3d> seeds)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1DF8BA0", Offset = "0x1DF71A0", VA = "0x181DF8BA0")]
		private void corner_pos(ref Vector3i ijk, ref Vector3d p)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1DF8BF0", Offset = "0x1DF71F0", VA = "0x181DF8BF0")]
		private Vector3d corner_pos(ref Vector3i ijk)
		{
			return default(Vector3d);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1DF8C40", Offset = "0x1DF7240", VA = "0x181DF8C40")]
		private Vector3i cell_index(Vector3d pos)
		{
			return default(Vector3i);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1DF8C90", Offset = "0x1DF7290", VA = "0x181DF8C90")]
		private long corner_hash(ref Vector3i idx)
		{
			return 0L;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1DF8CB0", Offset = "0x1DF72B0", VA = "0x181DF8CB0")]
		private long corner_hash(int x, int y, int z)
		{
			return 0L;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1DF8CD0", Offset = "0x1DF72D0", VA = "0x181DF8CD0")]
		private long edge_hash(ref Vector3i idx1, ref Vector3i idx2)
		{
			return 0L;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1DF8DE0", Offset = "0x1DF73E0", VA = "0x181DF8DE0")]
		private int edge_vertex_id(ref Vector3i idx1, ref Vector3i idx2, double f1, double f2)
		{
			return 0;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1DF93C0", Offset = "0x1DF79C0", VA = "0x181DF93C0")]
		private double corner_value(ref Vector3i idx)
		{
			return 0.0;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1DF95C0", Offset = "0x1DF7BC0", VA = "0x181DF95C0")]
		private void initialize_cell_values(MarchingCubesPro.GridCell cell, bool shift)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1DF9860", Offset = "0x1DF7E60", VA = "0x181DF9860")]
		private double corner_value_grid(ref Vector3i idx)
		{
			return 0.0;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1DF9A60", Offset = "0x1DF8060", VA = "0x181DF9A60")]
		private void initialize_cell_values_grid(MarchingCubesPro.GridCell cell, bool shift)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1DF9C00", Offset = "0x1DF8200", VA = "0x181DF9C00")]
		private double corner_value_nohash(ref Vector3i idx)
		{
			return 0.0;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1DF9D10", Offset = "0x1DF8310", VA = "0x181DF9D10")]
		private void initialize_cell_values_nohash(MarchingCubesPro.GridCell cell, bool shift)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1DF9EB0", Offset = "0x1DF84B0", VA = "0x181DF9EB0")]
		private void initialize_cell(MarchingCubesPro.GridCell cell, ref Vector3i idx)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1DFA110", Offset = "0x1DF8710", VA = "0x181DFA110")]
		private void shift_cell_x(MarchingCubesPro.GridCell cell, int xi)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1DFA2A0", Offset = "0x1DF88A0", VA = "0x181DFA2A0")]
		private void generate_parallel()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1DFA390", Offset = "0x1DF8990", VA = "0x181DFA390")]
		private void generate_basic()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1DFA500", Offset = "0x1DF8B00", VA = "0x181DFA500")]
		private void generate_continuation(IEnumerable<Vector3d> seeds)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1DFABD0", Offset = "0x1DF91D0", VA = "0x181DFABD0")]
		private void generate_continuation_parallel(IEnumerable<Vector3d> seeds)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1DFAE20", Offset = "0x1DF9420", VA = "0x181DFAE20")]
		private bool set_cell_if_not_done(ref Vector3i idx)
		{
			return default(bool);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1DFAF90", Offset = "0x1DF9590", VA = "0x181DFAF90")]
		private bool polygonize_cell(MarchingCubesPro.GridCell cell, int[] vertIndexList)
		{
			return default(bool);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1DFB380", Offset = "0x1DF9980", VA = "0x181DFB380")]
		private int append_vertex(Vector3d v)
		{
			return 0;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1DFB500", Offset = "0x1DF9B00", VA = "0x181DFB500")]
		private int append_triangle(int a, int b, int c)
		{
			return 0;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1DFB640", Offset = "0x1DF9C40", VA = "0x181DFB640")]
		private void find_iso(ref Vector3d p1, ref Vector3d p2, double valp1, double valp2, ref Vector3d pIso)
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x10")]
		public ImplicitFunction3d Implicit;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x18")]
		public double IsoValue;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x20")]
		public AxisAlignedBox3d Bounds;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x50")]
		public double CubeSize;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x58")]
		public bool ParallelCompute;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x5C")]
		public MarchingCubesPro.RootfindingModes RootMode;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x60")]
		public int RootModeSteps;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x68")]
		public Func<bool> CancelF;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x70")]
		public Vector3i CellDimensions;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x80")]
		public DMesh3 Mesh;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x88")]
		private AxisAlignedBox3i GridBounds;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xA0")]
		private AxisAlignedBox3i LastGridBounds;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		private const int EDGE_X = 268435456;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		private const int EDGE_Y = 536870912;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		private const int EDGE_Z = 1073741824;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<long, int> edge_vertices;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xC0")]
		private SpinLock edge_vertices_lock;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<long, double> corner_values;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0xD0")]
		private SpinLock corner_values_lock;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0xD8")]
		private DenseGrid3f corner_values_grid;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0xE0")]
		private bool parallel_mesh_access;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0xE4")]
		private SpinLock mesh_lock;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0xE8")]
		private DenseGrid3i done_cells;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0xF0")]
		private SpinLock done_cells_lock;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[,] edge_indices;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] edgeTable;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[,] triTable;

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		public enum RootfindingModes
		{
			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			SingleLerp,
			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			LerpSteps,
			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			Bisection
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		private class GridCell
		{
			// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1DFC530", Offset = "0x1DFAB30", VA = "0x181DFC530")]
			public GridCell()
			{
			}

			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			[FieldOffset(Offset = "0x10")]
			public Vector3i[] i;

			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			[FieldOffset(Offset = "0x18")]
			public double[] f;
		}
	}
}

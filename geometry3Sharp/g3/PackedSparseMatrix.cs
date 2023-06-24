using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000327")]
	public class PackedSparseMatrix
	{
		// Token: 0x06001B26 RID: 6950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x1F54170", Offset = "0x1F52770", VA = "0x181F54170")]
		public PackedSparseMatrix(PackedSparseMatrix copy)
		{
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x1F54470", Offset = "0x1F52A70", VA = "0x181F54470")]
		public PackedSparseMatrix(SymmetricSparseMatrix m, bool bTranspose = false)
		{
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x1F54C60", Offset = "0x1F53260", VA = "0x181F54C60")]
		public PackedSparseMatrix(DVector<matrix_entry> entries, int numRows, int numCols, bool bSymmetric = true)
		{
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x1F55220", Offset = "0x1F53820", VA = "0x181F55220")]
		public static PackedSparseMatrix FromDense(DenseMatrix m, bool bSymmetric)
		{
			return null;
		}

		// Token: 0x17000410 RID: 1040
		[Token(Token = "0x17000410")]
		public double this[int r, int c]
		{
			[Token(Token = "0x6001B2A")]
			[Address(RVA = "0x1F553D0", Offset = "0x1F539D0", VA = "0x181F553D0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6001B2B")]
			[Address(RVA = "0x1F55440", Offset = "0x1F53A40", VA = "0x181F55440")]
			set
			{
			}
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x1F555E0", Offset = "0x1F53BE0", VA = "0x181F555E0")]
		public void Sort(bool bParallel = true)
		{
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00013874 File Offset: 0x00011A74
		[Token(Token = "0x6001B2D")]
		[Address(RVA = "0x1F558A0", Offset = "0x1F53EA0", VA = "0x181F558A0")]
		public Interval1i NonZerosRange(int r)
		{
			return default(Interval1i);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0x1F55A00", Offset = "0x1F54000", VA = "0x181F55A00")]
		public IEnumerable<Vector2i> NonZeroIndicesByRow(bool bWantSorted = true)
		{
			return null;
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B2F")]
		[Address(RVA = "0x1F55AC0", Offset = "0x1F540C0", VA = "0x181F55AC0")]
		public IEnumerable<Vector2i> NonZeroIndicesForRow(int r, bool bWantSorted = true)
		{
			return null;
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B30")]
		[Address(RVA = "0x1F55B80", Offset = "0x1F54180", VA = "0x181F55B80")]
		public void Multiply(double[] X, double[] Result)
		{
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x1F55CA0", Offset = "0x1F542A0", VA = "0x181F55CA0")]
		public void Multiply_Parallel(double[] X, double[] Result)
		{
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x1F55E70", Offset = "0x1F54470", VA = "0x181F55E70")]
		public void Multiply_Parallel_3(double[][] X, double[][] Result)
		{
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0001388C File Offset: 0x00011A8C
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x1F56040", Offset = "0x1F54640", VA = "0x181F56040")]
		public double DotRowColumn(int r, int c, PackedSparseMatrix MTranspose)
		{
			return 0.0;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000138A4 File Offset: 0x00011AA4
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x1F56240", Offset = "0x1F54840", VA = "0x181F56240")]
		public double DotRowSelf(int r)
		{
			return 0.0;
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x1F562B0", Offset = "0x1F548B0", VA = "0x181F562B0")]
		public void DotRowAllColumns(int r, double[] sums, int[] col_indices, PackedSparseMatrix MTranspose)
		{
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x000138BC File Offset: 0x00011ABC
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x1F56460", Offset = "0x1F54A60", VA = "0x181F56460")]
		public double DotRows(int r1, int r2, int MaxCol = 2147483647)
		{
			return 0.0;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000138D4 File Offset: 0x00011AD4
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x1F56600", Offset = "0x1F54C00", VA = "0x181F56600")]
		public double DotRowVector(int r, double[] vec, int MaxCol = 2147483647)
		{
			return 0.0;
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000138EC File Offset: 0x00011AEC
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x1F56760", Offset = "0x1F54D60", VA = "0x181F56760")]
		public double DotColumnVector(int c, double[] vec, int start_row = 0, int end_row = 2147483647)
		{
			return 0.0;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x1F568A0", Offset = "0x1F54EA0", VA = "0x181F568A0")]
		public PackedSparseMatrix Square()
		{
			return null;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x00013904 File Offset: 0x00011B04
		[Token(Token = "0x17000411")]
		public double FrobeniusNorm
		{
			[Token(Token = "0x6001B3A")]
			[Address(RVA = "0x1F56AF0", Offset = "0x1F550F0", VA = "0x181F56AF0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x0001391C File Offset: 0x00011B1C
		[Token(Token = "0x17000412")]
		public double MaxNorm
		{
			[Token(Token = "0x6001B3B")]
			[Address(RVA = "0x1F56BD0", Offset = "0x1F551D0", VA = "0x181F56BD0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00013934 File Offset: 0x00011B34
		[Token(Token = "0x17000413")]
		public double Trace
		{
			[Token(Token = "0x6001B3C")]
			[Address(RVA = "0x1F56C50", Offset = "0x1F55250", VA = "0x181F56C50")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x1F56CD0", Offset = "0x1F552D0", VA = "0x181F56CD0")]
		public string MatrixInfo(bool bExtended = false)
		{
			return null;
		}

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x10")]
		public PackedSparseMatrix.nonzero[][] Rows;

		// Token: 0x04000E35 RID: 3637
		[Token(Token = "0x4000E35")]
		[FieldOffset(Offset = "0x18")]
		public int Columns;

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x1C")]
		public bool Sorted;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x20")]
		public int NumNonZeros;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x24")]
		public PackedSparseMatrix.StorageModes StorageMode;

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x28")]
		public bool IsSymmetric;

		// Token: 0x02000328 RID: 808
		[Token(Token = "0x2000328")]
		public struct nonzero
		{
			// Token: 0x04000E3A RID: 3642
			[Token(Token = "0x4000E3A")]
			[FieldOffset(Offset = "0x0")]
			public int j;

			// Token: 0x04000E3B RID: 3643
			[Token(Token = "0x4000E3B")]
			[FieldOffset(Offset = "0x8")]
			public double d;
		}

		// Token: 0x02000329 RID: 809
		[Token(Token = "0x2000329")]
		public enum StorageModes
		{
			// Token: 0x04000E3D RID: 3645
			[Token(Token = "0x4000E3D")]
			Full
		}
	}
}

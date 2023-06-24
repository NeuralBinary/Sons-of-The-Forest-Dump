using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000332 RID: 818
	[Token(Token = "0x2000332")]
	public class SymmetricSparseMatrix : IMatrix
	{
		// Token: 0x06001B65 RID: 7013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x1F5AFC0", Offset = "0x1F595C0", VA = "0x181F5AFC0")]
		public SymmetricSparseMatrix(int setN = 0)
		{
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x1F5B080", Offset = "0x1F59680", VA = "0x181F5B080")]
		public SymmetricSparseMatrix(DenseMatrix m)
		{
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x1F5B270", Offset = "0x1F59870", VA = "0x181F5B270")]
		public SymmetricSparseMatrix(SymmetricSparseMatrix m)
		{
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x1F5B3F0", Offset = "0x1F599F0", VA = "0x181F5B3F0", Slot = "7")]
		public void Set(int r, int c, double value)
		{
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x00013A0C File Offset: 0x00011C0C
		[Token(Token = "0x17000418")]
		public int Rows
		{
			[Token(Token = "0x6001B69")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x00013A24 File Offset: 0x00011C24
		[Token(Token = "0x17000419")]
		public int Columns
		{
			[Token(Token = "0x6001B6A")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x00013A3C File Offset: 0x00011C3C
		[Token(Token = "0x1700041A")]
		public Index2i Size
		{
			[Token(Token = "0x6001B6B")]
			[Address(RVA = "0x1F5B4D0", Offset = "0x1F59AD0", VA = "0x181F5B4D0", Slot = "6")]
			get
			{
				return default(Index2i);
			}
		}

		// Token: 0x1700041B RID: 1051
		[Token(Token = "0x1700041B")]
		public double this[int r, int c]
		{
			[Token(Token = "0x6001B6C")]
			[Address(RVA = "0x1F5B4F0", Offset = "0x1F59AF0", VA = "0x181F5B4F0", Slot = "8")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6001B6D")]
			[Address(RVA = "0x1F5B5E0", Offset = "0x1F59BE0", VA = "0x181F5B5E0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x1F5B5F0", Offset = "0x1F59BF0", VA = "0x181F5B5F0")]
		public void Multiply(double[] X, double[] Result)
		{
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x1F5B810", Offset = "0x1F59E10", VA = "0x181F5B810")]
		public SymmetricSparseMatrix Square(bool bParallel = true)
		{
			return null;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x1F5BBA0", Offset = "0x1F5A1A0", VA = "0x181F5BBA0")]
		public PackedSparseMatrix SquarePackedParallel()
		{
			return null;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x1F5BC20", Offset = "0x1F5A220", VA = "0x181F5BC20")]
		public SymmetricSparseMatrix Multiply(SymmetricSparseMatrix M2)
		{
			return null;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x1F5BCB0", Offset = "0x1F5A2B0", VA = "0x181F5BCB0")]
		public void Multiply(SymmetricSparseMatrix M2, ref SymmetricSparseMatrix R, bool bParallel = true)
		{
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x1F5BCC0", Offset = "0x1F5A2C0", VA = "0x181F5BCC0")]
		private void multiply_fast(SymmetricSparseMatrix M2in, ref SymmetricSparseMatrix Rin, bool bParallel)
		{
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x1F5C130", Offset = "0x1F5A730", VA = "0x181F5C130")]
		private void multiply_slow(SymmetricSparseMatrix M2, ref SymmetricSparseMatrix R)
		{
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public IEnumerable<KeyValuePair<Index2i, double>> NonZeros()
		{
			return null;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x1F5C5B0", Offset = "0x1F5ABB0", VA = "0x181F5C5B0")]
		public IEnumerable<Index2i> NonZeroIndices()
		{
			return null;
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00013A6C File Offset: 0x00011C6C
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x1F5C600", Offset = "0x1F5AC00", VA = "0x181F5C600")]
		public bool EpsilonEqual(SymmetricSparseMatrix B, double eps = 2.220446049250313E-16)
		{
			return default(bool);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x1F5C9B0", Offset = "0x1F5AFB0", VA = "0x181F5C9B0")]
		private void get_row_nonzeros(int r, List<SymmetricSparseMatrix.mval> buf)
		{
		}

		// Token: 0x04000E72 RID: 3698
		[Token(Token = "0x4000E72")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Index2i, double> d;

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4000E73")]
		[FieldOffset(Offset = "0x18")]
		private int N;

		// Token: 0x02000333 RID: 819
		[Token(Token = "0x2000333")]
		private struct mval
		{
			// Token: 0x04000E74 RID: 3700
			[Token(Token = "0x4000E74")]
			[FieldOffset(Offset = "0x0")]
			public int k;

			// Token: 0x04000E75 RID: 3701
			[Token(Token = "0x4000E75")]
			[FieldOffset(Offset = "0x8")]
			public double v;
		}
	}
}

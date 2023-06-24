using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000320 RID: 800
	[Token(Token = "0x2000320")]
	public class DenseMatrix : IMatrix
	{
		// Token: 0x06001AE3 RID: 6883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x1F33260", Offset = "0x1F31860", VA = "0x181F33260")]
		public DenseMatrix(int Nrows, int Mcols)
		{
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x1F33330", Offset = "0x1F31930", VA = "0x181F33330")]
		public DenseMatrix(DenseMatrix copy)
		{
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000401")]
		public double[] Buffer
		{
			[Token(Token = "0x6001AE5")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x1F334B0", Offset = "0x1F31AB0", VA = "0x181F334B0", Slot = "7")]
		public void Set(int r, int c, double value)
		{
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x1F334F0", Offset = "0x1F31AF0", VA = "0x181F334F0")]
		public void Set(double[] values)
		{
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x000136AC File Offset: 0x000118AC
		[Token(Token = "0x17000402")]
		public int Rows
		{
			[Token(Token = "0x6001AE8")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x000136C4 File Offset: 0x000118C4
		[Token(Token = "0x17000403")]
		public int Columns
		{
			[Token(Token = "0x6001AE9")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x000136DC File Offset: 0x000118DC
		[Token(Token = "0x17000404")]
		public Index2i Size
		{
			[Token(Token = "0x6001AEA")]
			[Address(RVA = "0x1F335F0", Offset = "0x1F31BF0", VA = "0x181F335F0", Slot = "6")]
			get
			{
				return default(Index2i);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x000136F4 File Offset: 0x000118F4
		[Token(Token = "0x17000405")]
		public int Length
		{
			[Token(Token = "0x6001AEB")]
			[Address(RVA = "0x1F33610", Offset = "0x1F31C10", VA = "0x181F33610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000406 RID: 1030
		[Token(Token = "0x17000406")]
		public double this[int r, int c]
		{
			[Token(Token = "0x6001AEC")]
			[Address(RVA = "0x1F33620", Offset = "0x1F31C20", VA = "0x181F33620", Slot = "8")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6001AED")]
			[Address(RVA = "0x1F334B0", Offset = "0x1F31AB0", VA = "0x181F334B0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000407 RID: 1031
		[Token(Token = "0x17000407")]
		public double this[int i]
		{
			[Token(Token = "0x6001AEE")]
			[Address(RVA = "0x1F04690", Offset = "0x1F02C90", VA = "0x181F04690")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6001AEF")]
			[Address(RVA = "0x1F33660", Offset = "0x1F31C60", VA = "0x181F33660")]
			set
			{
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x1F33690", Offset = "0x1F31C90", VA = "0x181F33690")]
		public DenseVector Row(int r)
		{
			return null;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x1F33760", Offset = "0x1F31D60", VA = "0x181F33760")]
		public DenseVector Column(int c)
		{
			return null;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x1F33830", Offset = "0x1F31E30", VA = "0x181F33830")]
		public DenseVector Diagonal()
		{
			return null;
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x1F33950", Offset = "0x1F31F50", VA = "0x181F33950")]
		public DenseMatrix Transpose()
		{
			return null;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x1F33A40", Offset = "0x1F32040", VA = "0x181F33A40")]
		public void TransposeInPlace()
		{
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0001373C File Offset: 0x0001193C
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x1F33C10", Offset = "0x1F32210", VA = "0x181F33C10")]
		public bool IsSymmetric(double dTolerance = 2.220446049250313E-16)
		{
			return default(bool);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00013754 File Offset: 0x00011954
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x1F33D80", Offset = "0x1F32380", VA = "0x181F33D80")]
		public bool IsPositiveDefinite()
		{
			return default(bool);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0001376C File Offset: 0x0001196C
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x1F33F90", Offset = "0x1F32590", VA = "0x181F33F90")]
		public bool EpsilonEquals(DenseMatrix m2, double epsilon = 1E-08)
		{
			return default(bool);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x1F34120", Offset = "0x1F32720", VA = "0x181F34120")]
		public DenseVector Multiply(DenseVector X)
		{
			return null;
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x1F34250", Offset = "0x1F32850", VA = "0x181F34250")]
		public void Multiply(DenseVector X, DenseVector R)
		{
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x1F34340", Offset = "0x1F32940", VA = "0x181F34340")]
		public void Multiply(double[] X, double[] Result)
		{
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x1F34420", Offset = "0x1F32A20", VA = "0x181F34420")]
		public void Add(DenseMatrix M2)
		{
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x1F34500", Offset = "0x1F32B00", VA = "0x181F34500")]
		public void Add(IMatrix M2)
		{
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x1F34650", Offset = "0x1F32C50", VA = "0x181F34650")]
		public void MulAdd(DenseMatrix M2, double s)
		{
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x1F34730", Offset = "0x1F32D30", VA = "0x181F34730")]
		public void MulAdd(IMatrix M2, double s)
		{
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x1F348A0", Offset = "0x1F32EA0", VA = "0x181F348A0")]
		public DenseMatrix Multiply(DenseMatrix M2, bool bParallel = true)
		{
			return null;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x1F34950", Offset = "0x1F32F50", VA = "0x181F34950")]
		public void Multiply(DenseMatrix M2, ref DenseMatrix R, bool bParallel = true)
		{
		}

		// Token: 0x04000E1D RID: 3613
		[Token(Token = "0x4000E1D")]
		[FieldOffset(Offset = "0x10")]
		private double[] d;

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x18")]
		private int N;

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x1C")]
		private int M;
	}
}

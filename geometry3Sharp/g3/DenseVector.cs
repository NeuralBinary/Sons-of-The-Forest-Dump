using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000322 RID: 802
	[Token(Token = "0x2000322")]
	public class DenseVector
	{
		// Token: 0x06001B03 RID: 6915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x1F51800", Offset = "0x1F4FE00", VA = "0x181F51800")]
		public DenseVector(int N)
		{
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x1F33660", Offset = "0x1F31C60", VA = "0x181F33660")]
		public void Set(int i, double value)
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x00013784 File Offset: 0x00011984
		[Token(Token = "0x17000408")]
		public int Size
		{
			[Token(Token = "0x6001B05")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0001379C File Offset: 0x0001199C
		[Token(Token = "0x17000409")]
		public int Length
		{
			[Token(Token = "0x6001B06")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700040A RID: 1034
		[Token(Token = "0x1700040A")]
		public double this[int i]
		{
			[Token(Token = "0x6001B07")]
			[Address(RVA = "0x1F04690", Offset = "0x1F02C90", VA = "0x181F04690")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6001B08")]
			[Address(RVA = "0x1F33660", Offset = "0x1F31C60", VA = "0x181F33660")]
			set
			{
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700040B")]
		public double[] Buffer
		{
			[Token(Token = "0x6001B09")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000137CC File Offset: 0x000119CC
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x1F518D0", Offset = "0x1F4FED0", VA = "0x181F518D0")]
		public double Dot(DenseVector v2)
		{
			return 0.0;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000137E4 File Offset: 0x000119E4
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x1F51990", Offset = "0x1F4FF90", VA = "0x181F51990")]
		public double Dot(double[] v2)
		{
			return 0.0;
		}

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x10")]
		private double[] d;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x18")]
		private int N;
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace MTAssets.UltimateLODSystem.MeshSimplifier
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public struct SymmetricMatrix
	{
		// Token: 0x17000012 RID: 18
		[Token(Token = "0x17000012")]
		public double this[int index]
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x5F8A40", Offset = "0x5F7040", VA = "0x1805F8A40")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x5F8B40", Offset = "0x5F7140", VA = "0x1805F8B40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SymmetricMatrix(double c)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x5F8B60", Offset = "0x5F7160", VA = "0x1805F8B60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SymmetricMatrix(double m0, double m1, double m2, double m3, double m4, double m5, double m6, double m7, double m8, double m9)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x5F8BC0", Offset = "0x5F71C0", VA = "0x1805F8BC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SymmetricMatrix(double a, double b, double c, double d)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x5F8C40", Offset = "0x5F7240", VA = "0x1805F8C40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SymmetricMatrix operator +(SymmetricMatrix a, SymmetricMatrix b)
		{
			return default(SymmetricMatrix);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x5F8CF0", Offset = "0x5F72F0", VA = "0x1805F8CF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal double Determinant1()
		{
			return 0.0;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x5F8D80", Offset = "0x5F7380", VA = "0x1805F8D80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal double Determinant2()
		{
			return 0.0;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x5F8E20", Offset = "0x5F7420", VA = "0x1805F8E20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal double Determinant3()
		{
			return 0.0;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x5F8EC0", Offset = "0x5F74C0", VA = "0x1805F8EC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal double Determinant4()
		{
			return 0.0;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x5F8F60", Offset = "0x5F7560", VA = "0x1805F8F60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double Determinant(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
		{
			return 0.0;
		}

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x0")]
		public double m0;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x8")]
		public double m1;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x10")]
		public double m2;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x18")]
		public double m3;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x20")]
		public double m4;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x28")]
		public double m5;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x30")]
		public double m6;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x38")]
		public double m7;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x40")]
		public double m8;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x48")]
		public double m9;
	}
}

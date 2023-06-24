using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	public class SingularValueDecomposition
	{
		// Token: 0x06001B59 RID: 7001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B59")]
		[Address(RVA = "0x1F58410", Offset = "0x1F56A10", VA = "0x181F58410")]
		public SingularValueDecomposition(int numRows, int numCols, int maxIterations)
		{
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x000139DC File Offset: 0x00011BDC
		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x1F58670", Offset = "0x1F56C70", VA = "0x181F58670")]
		public uint Solve(double[] input, int sortType = -1)
		{
			return 0U;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B5B")]
		[Address(RVA = "0x1F58AD0", Offset = "0x1F570D0", VA = "0x181F58AD0")]
		public void GetSingularValues(double[] singularValues)
		{
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x1F58B80", Offset = "0x1F57180", VA = "0x181F58B80")]
		public void GetU(double[] uMatrix)
		{
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B5D")]
		[Address(RVA = "0x1F59280", Offset = "0x1F57880", VA = "0x181F59280")]
		public void GetV(double[] vMatrix)
		{
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x1F59A00", Offset = "0x1F58000", VA = "0x181F59A00")]
		private void Bidiagonalize()
		{
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x1F5A2B0", Offset = "0x1F588B0", VA = "0x181F5A2B0")]
		private void GetSinCos(double x, double y, out double cs, out double sn)
		{
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x000139F4 File Offset: 0x00011BF4
		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x1F5A430", Offset = "0x1F58A30", VA = "0x181F5A430")]
		private bool DiagonalEntriesNonzero(int imin, int imax, double threshold)
		{
			return default(bool);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x1F5A6B0", Offset = "0x1F58CB0", VA = "0x181F5A6B0")]
		private void DoGolubKahanStep(int imin, int imax)
		{
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x1F5AC90", Offset = "0x1F59290", VA = "0x181F5AC90")]
		private void EnsureNonnegativeDiagonal()
		{
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x1F5AD30", Offset = "0x1F59330", VA = "0x181F5AD30")]
		private void ComputePermutation(int sortType)
		{
		}

		// Token: 0x04000E5E RID: 3678
		[Token(Token = "0x4000E5E")]
		[FieldOffset(Offset = "0x10")]
		private int mNumRows;

		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000E5F")]
		[FieldOffset(Offset = "0x14")]
		private int mNumCols;

		// Token: 0x04000E60 RID: 3680
		[Token(Token = "0x4000E60")]
		[FieldOffset(Offset = "0x18")]
		private int mMaxIterations;

		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000E61")]
		[FieldOffset(Offset = "0x20")]
		private double[] mMatrix;

		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0x28")]
		private double[] mDiagonal;

		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000E63")]
		[FieldOffset(Offset = "0x30")]
		private double[] mSuperdiagonal;

		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		[FieldOffset(Offset = "0x38")]
		private List<SingularValueDecomposition.GivensRotation> mRGivens;

		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		[FieldOffset(Offset = "0x40")]
		private List<SingularValueDecomposition.GivensRotation> mLGivens;

		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		[FieldOffset(Offset = "0x48")]
		private double[] mFixupDiagonal;

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x50")]
		private int[] mPermutation;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0x58")]
		private int[] mVisited;

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x60")]
		private double[] mTwoInvUTU;

		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		[FieldOffset(Offset = "0x68")]
		private double[] mTwoInvVTV;

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x70")]
		private double[] mUVector;

		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x78")]
		private double[] mVVector;

		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x80")]
		private double[] mWVector;

		// Token: 0x02000331 RID: 817
		[Token(Token = "0x2000331")]
		private struct GivensRotation
		{
			// Token: 0x06001B64 RID: 7012 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001B64")]
			[Address(RVA = "0x1F5AFA0", Offset = "0x1F595A0", VA = "0x181F5AFA0")]
			public GivensRotation(int inIndex0, int inIndex1, double inCs, double inSn)
			{
			}

			// Token: 0x04000E6E RID: 3694
			[Token(Token = "0x4000E6E")]
			[FieldOffset(Offset = "0x0")]
			public int index0;

			// Token: 0x04000E6F RID: 3695
			[Token(Token = "0x4000E6F")]
			[FieldOffset(Offset = "0x4")]
			public int index1;

			// Token: 0x04000E70 RID: 3696
			[Token(Token = "0x4000E70")]
			[FieldOffset(Offset = "0x8")]
			public double cs;

			// Token: 0x04000E71 RID: 3697
			[Token(Token = "0x4000E71")]
			[FieldOffset(Offset = "0x10")]
			public double sn;
		}
	}
}

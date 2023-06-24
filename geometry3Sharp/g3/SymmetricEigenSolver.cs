using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	public class SymmetricEigenSolver
	{
		// Token: 0x06001BA7 RID: 7079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x1F617C0", Offset = "0x1F5FDC0", VA = "0x181F617C0")]
		public SymmetricEigenSolver(int size, int maxIterations)
		{
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00013B44 File Offset: 0x00011D44
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x1F61BD0", Offset = "0x1F601D0", VA = "0x181F61BD0")]
		public int Solve(double[] input, SymmetricEigenSolver.SortType eSort)
		{
			return 0;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x1F61ED0", Offset = "0x1F604D0", VA = "0x181F61ED0")]
		public void GetEigenvalues(double[] eigenvalues)
		{
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x1F62050", Offset = "0x1F60650", VA = "0x181F62050")]
		public double[] GetEigenvalues()
		{
			return null;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00013B5C File Offset: 0x00011D5C
		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0x1F62200", Offset = "0x1F60800", VA = "0x181F62200")]
		public double GetEigenvalue(int c)
		{
			return 0.0;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x1F62280", Offset = "0x1F60880", VA = "0x181F62280")]
		public void GetEigenvectors(double[] eigenvectors)
		{
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x1F62A40", Offset = "0x1F61040", VA = "0x181F62A40")]
		public double[] GetEigenvectors()
		{
			return null;
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00013B74 File Offset: 0x00011D74
		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0x1F62AA0", Offset = "0x1F610A0", VA = "0x181F62AA0")]
		public bool IsRotation()
		{
			return default(bool);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x1F62BE0", Offset = "0x1F611E0", VA = "0x181F62BE0")]
		public void GetEigenvector(int c, double[] eigenvector)
		{
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x1F630E0", Offset = "0x1F616E0", VA = "0x181F630E0")]
		public double[] GetEigenvector(int c)
		{
			return null;
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x1F63150", Offset = "0x1F61750", VA = "0x181F63150")]
		private void Tridiagonalize()
		{
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x1F63870", Offset = "0x1F61E70", VA = "0x181F63870")]
		private void GetSinCos(double x, double y, ref double cs, ref double sn)
		{
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x1F639F0", Offset = "0x1F61FF0", VA = "0x181F639F0")]
		private void DoQRImplicitShift(int imin, int imax)
		{
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x1F63F80", Offset = "0x1F62580", VA = "0x181F63F80")]
		private void ComputePermutation(int sortType)
		{
		}

		// Token: 0x04000EBA RID: 3770
		[Token(Token = "0x4000EBA")]
		public const int NO_CONVERGENCE = 2147483647;

		// Token: 0x04000EBB RID: 3771
		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x10")]
		private int mSize;

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0x14")]
		private int mMaxIterations;

		// Token: 0x04000EBD RID: 3773
		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0x18")]
		private double[] mMatrix;

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x20")]
		private double[] mDiagonal;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0x28")]
		private double[] mSuperdiagonal;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x30")]
		private List<SymmetricEigenSolver.GivensRotation> mGivens;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x38")]
		private int[] mPermutation;

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x40")]
		private int[] mVisited;

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x48")]
		private int mIsRotation;

		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000EC4")]
		[FieldOffset(Offset = "0x50")]
		private double[] mPVector;

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x58")]
		private double[] mVVector;

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x60")]
		private double[] mWVector;

		// Token: 0x02000341 RID: 833
		[Token(Token = "0x2000341")]
		public enum SortType
		{
			// Token: 0x04000EC8 RID: 3784
			[Token(Token = "0x4000EC8")]
			Decreasing = -1,
			// Token: 0x04000EC9 RID: 3785
			[Token(Token = "0x4000EC9")]
			NoSorting,
			// Token: 0x04000ECA RID: 3786
			[Token(Token = "0x4000ECA")]
			Increasing
		}

		// Token: 0x02000342 RID: 834
		[Token(Token = "0x2000342")]
		private struct GivensRotation
		{
			// Token: 0x06001BB5 RID: 7093 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001BB5")]
			[Address(RVA = "0x1F64440", Offset = "0x1F62A40", VA = "0x181F64440")]
			public GivensRotation(int inIndex, double inCs, double inSn)
			{
			}

			// Token: 0x04000ECB RID: 3787
			[Token(Token = "0x4000ECB")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04000ECC RID: 3788
			[Token(Token = "0x4000ECC")]
			[FieldOffset(Offset = "0x8")]
			public double cs;

			// Token: 0x04000ECD RID: 3789
			[Token(Token = "0x4000ECD")]
			[FieldOffset(Offset = "0x10")]
			public double sn;
		}

		// Token: 0x02000343 RID: 835
		[Token(Token = "0x2000343")]
		private struct SortItem
		{
			// Token: 0x04000ECE RID: 3790
			[Token(Token = "0x4000ECE")]
			[FieldOffset(Offset = "0x0")]
			public double eigenvalue;

			// Token: 0x04000ECF RID: 3791
			[Token(Token = "0x4000ECF")]
			[FieldOffset(Offset = "0x8")]
			public int index;
		}
	}
}

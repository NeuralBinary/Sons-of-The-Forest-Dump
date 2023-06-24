using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200033C RID: 828
	[Token(Token = "0x200033C")]
	public class SparseSymmetricCGMultipleRHS
	{
		// Token: 0x06001B95 RID: 7061 RVA: 0x00013B14 File Offset: 0x00011D14
		[Token(Token = "0x6001B95")]
		[Address(RVA = "0x1F5EB10", Offset = "0x1F5D110", VA = "0x181F5EB10")]
		public bool Solve()
		{
			return default(bool);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00013B2C File Offset: 0x00011D2C
		[Token(Token = "0x6001B96")]
		[Address(RVA = "0x1F5FC90", Offset = "0x1F5E290", VA = "0x181F5FC90")]
		public bool SolvePreconditioned()
		{
			return default(bool);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B97")]
		[Address(RVA = "0x1F60BD0", Offset = "0x1F5F1D0", VA = "0x181F60BD0")]
		private void UpdateP(double[][] P, double[] beta, double[][] R, bool[] converged)
		{
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x1F60E50", Offset = "0x1F5F450", VA = "0x181F60E50")]
		private void InitializeR(double[][] R)
		{
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B99")]
		[Address(RVA = "0x1F60F30", Offset = "0x1F5F530", VA = "0x181F60F30")]
		public SparseSymmetricCGMultipleRHS()
		{
		}

		// Token: 0x04000E95 RID: 3733
		[Token(Token = "0x4000E95")]
		[FieldOffset(Offset = "0x10")]
		public Action<double[][], double[][]> MultiplyF;

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0x18")]
		public Action<double[][], double[][]> PreconditionMultiplyF;

		// Token: 0x04000E97 RID: 3735
		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0x20")]
		public double[][] B;

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0x28")]
		public double ConvergeTolerance;

		// Token: 0x04000E99 RID: 3737
		[Token(Token = "0x4000E99")]
		[FieldOffset(Offset = "0x30")]
		public double[][] X;

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x38")]
		public bool UseXAsInitialGuess;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x3C")]
		public int MaxIterations;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x40")]
		public int Iterations;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x48")]
		private double[][] R;

		// Token: 0x04000E9E RID: 3742
		[Token(Token = "0x4000E9E")]
		[FieldOffset(Offset = "0x50")]
		private double[][] P;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x58")]
		private double[][] W;

		// Token: 0x04000EA0 RID: 3744
		[Token(Token = "0x4000EA0")]
		[FieldOffset(Offset = "0x60")]
		private double[][] AP;

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0x68")]
		private double[][] Z;
	}
}

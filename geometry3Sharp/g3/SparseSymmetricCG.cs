using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	public class SparseSymmetricCG
	{
		// Token: 0x06001B86 RID: 7046 RVA: 0x00013AE4 File Offset: 0x00011CE4
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x1F5D1B0", Offset = "0x1F5B7B0", VA = "0x181F5D1B0")]
		public bool Solve()
		{
			return default(bool);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x1F5DBF0", Offset = "0x1F5C1F0", VA = "0x181F5DBF0")]
		private void UpdateP(double[] P, double beta, double[] R)
		{
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x1F5DC50", Offset = "0x1F5C250", VA = "0x181F5DC50")]
		private void InitializeR(double[] R)
		{
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00013AFC File Offset: 0x00011CFC
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x1F5DCF0", Offset = "0x1F5C2F0", VA = "0x181F5DCF0")]
		public bool SolvePreconditioned()
		{
			return default(bool);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x1F5E7D0", Offset = "0x1F5CDD0", VA = "0x181F5E7D0")]
		public SparseSymmetricCG()
		{
		}

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x10")]
		public Action<double[], double[]> MultiplyF;

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x18")]
		public Action<double[], double[]> PreconditionMultiplyF;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0x20")]
		public double[] B;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x28")]
		public double[] X;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0x30")]
		public bool UseXAsInitialGuess;

		// Token: 0x04000E83 RID: 3715
		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0x34")]
		public int MaxIterations;

		// Token: 0x04000E84 RID: 3716
		[Token(Token = "0x4000E84")]
		[FieldOffset(Offset = "0x38")]
		public int Iterations;

		// Token: 0x04000E85 RID: 3717
		[Token(Token = "0x4000E85")]
		[FieldOffset(Offset = "0x40")]
		private double[] R;

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000E86")]
		[FieldOffset(Offset = "0x48")]
		private double[] P;

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x50")]
		private double[] AP;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x58")]
		private double[] Z;
	}
}

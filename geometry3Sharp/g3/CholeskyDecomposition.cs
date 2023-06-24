using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200031C RID: 796
	[Token(Token = "0x200031C")]
	public class CholeskyDecomposition
	{
		// Token: 0x06001AD2 RID: 6866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public CholeskyDecomposition(DenseMatrix m)
		{
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0001364C File Offset: 0x0001184C
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x1F31EB0", Offset = "0x1F304B0", VA = "0x181F31EB0")]
		public bool Compute()
		{
			return default(bool);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00013664 File Offset: 0x00011864
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x1F32380", Offset = "0x1F30980", VA = "0x181F32380")]
		public bool ComputeParallel()
		{
			return default(bool);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x1F32960", Offset = "0x1F30F60", VA = "0x181F32960")]
		private IEnumerable<Vector2i> diag_itr()
		{
			return null;
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x1F32A00", Offset = "0x1F31000", VA = "0x181F32A00")]
		public void Solve(double[] B, double[] X, double[] Y)
		{
		}

		// Token: 0x04000E0E RID: 3598
		[Token(Token = "0x4000E0E")]
		[FieldOffset(Offset = "0x10")]
		public DenseMatrix A;

		// Token: 0x04000E0F RID: 3599
		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x18")]
		public DenseMatrix L;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	public class VectorArray2d : VectorArray2<double>
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1F51220", Offset = "0x1F4F820", VA = "0x181F51220")]
		public VectorArray2d(int nCount)
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1F512F0", Offset = "0x1F4F8F0", VA = "0x181F512F0")]
		public VectorArray2d(double[] data)
		{
		}

		// Token: 0x170000A4 RID: 164
		[Token(Token = "0x170000A4")]
		public Vector2d this[int i]
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x1F51370", Offset = "0x1F4F970", VA = "0x181F51370")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x1F513C0", Offset = "0x1F4F9C0", VA = "0x181F513C0")]
			set
			{
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1F51440", Offset = "0x1F4FA40", VA = "0x181F51440")]
		public IEnumerable<Vector2d> AsVector2d()
		{
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public class DVectorArray3d : DVectorArray3<double>
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1F3E110", Offset = "0x1F3C710", VA = "0x181F3E110")]
		public DVectorArray3d(int nCount = 0)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1F3E220", Offset = "0x1F3C820", VA = "0x181F3E220")]
		public DVectorArray3d(double[] data)
		{
		}

		// Token: 0x17000034 RID: 52
		[Token(Token = "0x17000034")]
		public Vector3d this[int i]
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1F3E320", Offset = "0x1F3C920", VA = "0x181F3E320")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x1F3E490", Offset = "0x1F3CA90", VA = "0x181F3E490")]
			set
			{
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1F3E570", Offset = "0x1F3CB70", VA = "0x181F3E570")]
		public IEnumerable<Vector3d> AsVector3d()
		{
			return null;
		}

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		private const double invalid_value = -99999999.0;
	}
}

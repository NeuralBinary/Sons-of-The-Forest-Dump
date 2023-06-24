using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public class VectorArray3d : VectorArray3<double>
	{
		// Token: 0x06000479 RID: 1145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1F4FF10", Offset = "0x1F4E510", VA = "0x181F4FF10")]
		public VectorArray3d(int nCount, bool debug = false)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1F4FFE0", Offset = "0x1F4E5E0", VA = "0x181F4FFE0")]
		public VectorArray3d(double[] data)
		{
		}

		// Token: 0x17000095 RID: 149
		[Token(Token = "0x17000095")]
		public Vector3d this[int i]
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x1F50060", Offset = "0x1F4E660", VA = "0x181F50060")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1F500C0", Offset = "0x1F4E6C0", VA = "0x181F500C0")]
			set
			{
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1F50160", Offset = "0x1F4E760", VA = "0x181F50160")]
		public IEnumerable<Vector3d> AsVector3d()
		{
			return null;
		}

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		private const double invalid_value = -99999999.0;
	}
}

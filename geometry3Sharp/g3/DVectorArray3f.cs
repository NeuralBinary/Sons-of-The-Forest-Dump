using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public class DVectorArray3f : DVectorArray3<float>
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1F3E980", Offset = "0x1F3CF80", VA = "0x181F3E980")]
		public DVectorArray3f(int nCount = 0)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1F3EA90", Offset = "0x1F3D090", VA = "0x181F3EA90")]
		public DVectorArray3f(float[] data)
		{
		}

		// Token: 0x17000037 RID: 55
		[Token(Token = "0x17000037")]
		public Vector3f this[int i]
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1F3EB90", Offset = "0x1F3D190", VA = "0x181F3EB90")]
			get
			{
				return default(Vector3f);
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x1F3ED00", Offset = "0x1F3D300", VA = "0x181F3ED00")]
			set
			{
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1F3EDE0", Offset = "0x1F3D3E0", VA = "0x181F3EDE0")]
		public IEnumerable<Vector3f> AsVector3f()
		{
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public class DIndexArray3i : DVectorArray3<int>
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1F3F930", Offset = "0x1F3DF30", VA = "0x181F3F930")]
		public DIndexArray3i(int nCount = 0)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1F3F970", Offset = "0x1F3DF70", VA = "0x181F3F970")]
		public DIndexArray3i(int[] data)
		{
		}

		// Token: 0x1700003D RID: 61
		[Token(Token = "0x1700003D")]
		public Index3i this[int i]
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x1F3F9C0", Offset = "0x1F3DFC0", VA = "0x181F3F9C0")]
			get
			{
				return default(Index3i);
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x1F3FB30", Offset = "0x1F3E130", VA = "0x181F3FB30")]
			set
			{
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1F3FB60", Offset = "0x1F3E160", VA = "0x181F3FB60")]
		public void Set(int i, int a, int b, int c, bool bCycle = false)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1F3FDC0", Offset = "0x1F3E3C0", VA = "0x181F3FDC0")]
		public IEnumerable<Index3i> AsIndex3i()
		{
			return null;
		}
	}
}

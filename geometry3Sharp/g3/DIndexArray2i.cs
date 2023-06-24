using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public class DIndexArray2i : DVectorArray2<int>
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1F40FD0", Offset = "0x1F3F5D0", VA = "0x181F40FD0")]
		public DIndexArray2i(int nCount = 0)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1F410E0", Offset = "0x1F3F6E0", VA = "0x181F410E0")]
		public DIndexArray2i(int[] data)
		{
		}

		// Token: 0x17000049 RID: 73
		[Token(Token = "0x17000049")]
		public Index2i this[int i]
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x1F411E0", Offset = "0x1F3F7E0", VA = "0x181F411E0")]
			get
			{
				return default(Index2i);
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x1F412D0", Offset = "0x1F3F8D0", VA = "0x181F412D0")]
			set
			{
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1F41380", Offset = "0x1F3F980", VA = "0x181F41380")]
		public IEnumerable<Index2i> AsIndex2i()
		{
			return null;
		}
	}
}

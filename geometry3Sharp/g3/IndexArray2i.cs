using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	public class IndexArray2i : VectorArray2<int>
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1F906A0", Offset = "0x1F8ECA0", VA = "0x181F906A0")]
		public IndexArray2i(int nCount)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1F90770", Offset = "0x1F8ED70", VA = "0x181F90770")]
		public IndexArray2i(int[] data)
		{
		}

		// Token: 0x170000AA RID: 170
		[Token(Token = "0x170000AA")]
		public Index2i this[int i]
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x1F907F0", Offset = "0x1F8EDF0", VA = "0x181F907F0")]
			get
			{
				return default(Index2i);
			}
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1F90840", Offset = "0x1F8EE40", VA = "0x181F90840")]
			set
			{
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1F908D0", Offset = "0x1F8EED0", VA = "0x181F908D0")]
		public IEnumerable<Index2i> AsIndex2i()
		{
			return null;
		}
	}
}

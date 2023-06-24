using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	public class IndexArray4i : VectorArray4<int>
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1F90B90", Offset = "0x1F8F190", VA = "0x181F90B90")]
		public IndexArray4i(int nCount)
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1F90C60", Offset = "0x1F8F260", VA = "0x181F90C60")]
		public IndexArray4i(int[] data)
		{
		}

		// Token: 0x170000B0 RID: 176
		[Token(Token = "0x170000B0")]
		public Index4i this[int i]
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1F90CE0", Offset = "0x1F8F2E0", VA = "0x181F90CE0")]
			get
			{
				return default(Index4i);
			}
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1F90D50", Offset = "0x1F8F350", VA = "0x181F90D50")]
			set
			{
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1F90DC0", Offset = "0x1F8F3C0", VA = "0x181F90DC0")]
		public IEnumerable<Index4i> AsIndex4i()
		{
			return null;
		}
	}
}

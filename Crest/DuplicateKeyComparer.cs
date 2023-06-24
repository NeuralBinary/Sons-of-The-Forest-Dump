using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Crest
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000F9")]
		public int Compare(TKey x, TKey y)
		{
			return 0;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		public DuplicateKeyComparer()
		{
		}
	}
}

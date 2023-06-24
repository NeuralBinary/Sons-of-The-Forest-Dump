using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	public class SparseObjectList<T> where T : class
	{
		// Token: 0x06000422 RID: 1058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000422")]
		public SparseObjectList(int MaxIndex, int SubsetCountEst)
		{
		}

		// Token: 0x1700008C RID: 140
		[Token(Token = "0x1700008C")]
		public T this[int idx]
		{
			[Token(Token = "0x6000423")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000424")]
			set
			{
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00003FA4 File Offset: 0x000021A4
		[Token(Token = "0x6000425")]
		public int Count(Func<T, bool> CountF)
		{
			return 0;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000426")]
		public IEnumerable<KeyValuePair<int, T>> Values()
		{
			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000427")]
		public IEnumerable<KeyValuePair<int, T>> NonZeroValues()
		{
			return null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000428")]
		public void Clear()
		{
		}

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x0")]
		private T[] dense;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, T> sparse;
	}
}

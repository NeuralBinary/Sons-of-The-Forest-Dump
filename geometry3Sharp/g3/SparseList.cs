using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	public class SparseList<T> where T : IEquatable<T>
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040A")]
		public SparseList(int MaxIndex, int SubsetCountEst, T ZeroValue)
		{
		}

		// Token: 0x17000087 RID: 135
		[Token(Token = "0x17000087")]
		public T this[int idx]
		{
			[Token(Token = "0x600040B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040C")]
			set
			{
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x600040D")]
		public int Count(Func<T, bool> CountF)
		{
			return 0;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600040E")]
		public IEnumerable<KeyValuePair<int, T>> Values()
		{
			return null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600040F")]
		public IEnumerable<KeyValuePair<int, T>> NonZeroValues()
		{
			return null;
		}

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x0")]
		private T[] dense;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, T> sparse;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x0")]
		private T zeroValue;
	}
}

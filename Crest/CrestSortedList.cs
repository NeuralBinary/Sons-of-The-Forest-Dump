using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Crest
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class CrestSortedList<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x1700000B")]
		public int Count
		{
			[Token(Token = "0x600005F")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		public CrestSortedList(IComparer<TKey> comparer)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000062")]
		public bool Remove(TValue value)
		{
			return default(bool);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		public void Clear()
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000064")]
		public List<KeyValuePair<TKey, TValue>>.Enumerator GetEnumerator()
		{
			return default(List<KeyValuePair<TKey, TValue>>.Enumerator);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000065")]
		private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000066")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		private void ResortArrays()
		{
		}

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		private List<KeyValuePair<TKey, TValue>> _backingList;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x0")]
		private IComparer<KeyValuePair<TKey, TValue>> _comparer;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		private bool _needsSorting;

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x200001B")]
		private class InternalComparer : IComparer<KeyValuePair<TKey, TValue>>
		{
			// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000068")]
			public InternalComparer(IComparer<TKey> comparer)
			{
			}

			// Token: 0x06000069 RID: 105 RVA: 0x000022B0 File Offset: 0x000004B0
			[Token(Token = "0x6000069")]
			public int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
			{
				return 0;
			}

			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			[FieldOffset(Offset = "0x0")]
			private IComparer<TKey> _comparer;
		}
	}
}

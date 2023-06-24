using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	public class ObiList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000792")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000793")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000794")]
		public void Add(T item)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000795")]
		public void Clear()
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000470C File Offset: 0x0000290C
		[Token(Token = "0x6000796")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000797")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00004724 File Offset: 0x00002924
		[Token(Token = "0x6000798")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x170000FF")]
		public int Count
		{
			[Token(Token = "0x6000799")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x17000100")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600079A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x600079B")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600079C")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600079D")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x17000101 RID: 257
		[Token(Token = "0x17000101")]
		public T this[int index]
		{
			[Token(Token = "0x600079E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079F")]
			set
			{
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000102")]
		public T[] Data
		{
			[Token(Token = "0x60007A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007A1")]
		public void SetCount(int count)
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007A2")]
		public void EnsureCapacity(int capacity)
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007A3")]
		public ObiList()
		{
		}

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x0")]
		private T[] data;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x0")]
		private int count;
	}
}

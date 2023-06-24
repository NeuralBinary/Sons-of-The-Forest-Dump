using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class KeyValueList<K, V> : IList, ICollection, IEnumerable
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	public KeyValueList()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	public KeyValueList(ref List<K> keyListRef, ref List<V> valListRef)
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	public KeyValueList(KeyValueList<K, V> otherKeyValueList)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000004")]
	public bool TryGetValue(K key, out V value)
	{
		return default(bool);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x6000005")]
	public int Add(object value)
	{
		return 0;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	public void Clear()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002084 File Offset: 0x00000284
	[Token(Token = "0x6000007")]
	public bool Contains(V value)
	{
		return default(bool);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000209C File Offset: 0x0000029C
	[Token(Token = "0x6000008")]
	public bool ContainsKey(K key)
	{
		return default(bool);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000020B4 File Offset: 0x000002B4
	[Token(Token = "0x6000009")]
	public int IndexOf(K key)
	{
		return 0;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	public void Insert(int index, K key, V value)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	public void Insert(int index, KeyValuePair<K, V> kvp)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	public void Insert(int index, object value)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	public void Remove(K key)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	public void Remove(object value)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	public void RemoveAt(int index)
	{
	}

	// Token: 0x17000001 RID: 1
	[Token(Token = "0x17000001")]
	public V this[K key]
	{
		[Token(Token = "0x6000010")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000011")]
		set
		{
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000012")]
	public V GetAt(int index)
	{
		return null;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	public void SetAt(int index, V value)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	public void CopyTo(V[] array, int index)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	public void CopyTo(KeyValueList<K, V> otherKeyValueList, int index)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	public void AddRange(KeyValueList<K, V> otherKeyValueList)
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000017 RID: 23 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x17000002")]
	public int Count
	{
		[Token(Token = "0x6000017")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000018")]
	public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
	{
		return null;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000019")]
	private IEnumerator GetEnumerator()
	{
		return null;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x600001A")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600001B RID: 27 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x17000003")]
	public bool IsFixedSize
	{
		[Token(Token = "0x600001B")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600001C RID: 28 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x17000004")]
	public bool IsReadOnly
	{
		[Token(Token = "0x600001C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001D RID: 29 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x17000005")]
	public bool IsSynchronized
	{
		[Token(Token = "0x600001D")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600001E RID: 30 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x17000006")]
	public object SyncRoot
	{
		[Token(Token = "0x600001E")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x600001F")]
	public bool Contains(object value)
	{
		return default(bool);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000020")]
	public int IndexOf(object value)
	{
		return 0;
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000021 RID: 33 RVA: 0x000020CA File Offset: 0x000002CA
	// (set) Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000007")]
	private object Item
	{
		[Token(Token = "0x6000021")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000022")]
		set
		{
		}
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	public void CopyTo(Array array, int index)
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private List<K> keyList;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x0")]
	private List<V> valList;
}

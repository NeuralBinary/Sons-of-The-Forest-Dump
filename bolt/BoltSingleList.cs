using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000041 RID: 65
[Token(Token = "0x2000041")]
[Documentation(Ignore = true)]
public class BoltSingleList<T> : IEnumerable<T>, IEnumerable where T : class, IBoltListNode
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060002D3 RID: 723 RVA: 0x00002F40 File Offset: 0x00001140
	[Token(Token = "0x17000093")]
	public int count
	{
		[Token(Token = "0x60002D3")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060002D4 RID: 724 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000094")]
	public T first
	{
		[Token(Token = "0x60002D4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000095")]
	public T last
	{
		[Token(Token = "0x60002D5")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00002F58 File Offset: 0x00001158
	[Token(Token = "0x60002D6")]
	public BoltIterator<T> GetIterator()
	{
		return default(BoltIterator<T>);
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D7")]
	public void AddFirst(T item)
	{
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D8")]
	public void AddLast(T item)
	{
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002D9")]
	public T PeekFirst()
	{
		return null;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002DA")]
	public T RemoveFirst()
	{
		return null;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DB")]
	public void Clear()
	{
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002DC")]
	public T Next(T item)
	{
		return null;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002DD")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DE")]
	private void VerifyNotEmpty()
	{
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DF")]
	private void VerifyCanInsert(T node)
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E0")]
	private void VerifyInList(T node)
	{
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002E1")]
	private IEnumerator GetEnumerator()
	{
		return null;
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x60002E2")]
	public static implicit operator bool(BoltSingleList<T> list)
	{
		return default(bool);
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E3")]
	public BoltSingleList()
	{
	}

	// Token: 0x0400013D RID: 317
	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x0")]
	private T _head;

	// Token: 0x0400013E RID: 318
	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x0")]
	private T _tail;

	// Token: 0x0400013F RID: 319
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x0")]
	private int _count;
}

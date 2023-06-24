using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200003D RID: 61
[Token(Token = "0x200003D")]
[Documentation(Ignore = true)]
public class BoltDoubleList<T> : IEnumerable<T>, IEnumerable where T : class, IBoltListNode
{
	// Token: 0x1700008B RID: 139
	// (get) Token: 0x0600025F RID: 607 RVA: 0x00002C28 File Offset: 0x00000E28
	[Token(Token = "0x1700008B")]
	public int count
	{
		[Token(Token = "0x600025F")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000260 RID: 608 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700008C")]
	public T first
	{
		[Token(Token = "0x6000260")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000261 RID: 609 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700008D")]
	public T firstOrDefault
	{
		[Token(Token = "0x6000261")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000262 RID: 610 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700008E")]
	public T last
	{
		[Token(Token = "0x6000262")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000263 RID: 611 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700008F")]
	public T lastOrDefault
	{
		[Token(Token = "0x6000263")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002C40 File Offset: 0x00000E40
	[Token(Token = "0x6000264")]
	public BoltIterator<T> GetIterator()
	{
		return default(BoltIterator<T>);
	}

	// Token: 0x17000090 RID: 144
	[Token(Token = "0x17000090")]
	public T this[int index]
	{
		[Token(Token = "0x6000265")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00002C58 File Offset: 0x00000E58
	[Token(Token = "0x6000266")]
	public bool Contains(T node)
	{
		return default(bool);
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00002C70 File Offset: 0x00000E70
	[Token(Token = "0x6000267")]
	public bool IsFirst(T node)
	{
		return default(bool);
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000268")]
	public void AddLast(T node)
	{
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000269")]
	public void AddFirst(T node)
	{
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600026A")]
	public T Remove(T node)
	{
		return null;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600026B")]
	public T RemoveFirst()
	{
		return null;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600026C")]
	public T RemoveLast()
	{
		return null;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026D")]
	public void Clear()
	{
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600026E")]
	public T Prev(T node)
	{
		return null;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600026F")]
	public T Next(T node)
	{
		return null;
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000270")]
	public void Replace(T node, T newNode)
	{
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000271")]
	private void VerifyCanInsert(T node)
	{
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000272")]
	private void VerifyInList(T node)
	{
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000273")]
	private void InsertBefore(T node, T before)
	{
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000274")]
	private void InsertEmpty(T node)
	{
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000275")]
	private void RemoveNode(T node)
	{
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000276")]
	private void VerifyNotEmpty()
	{
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000277")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000278")]
	private IEnumerator GetEnumerator()
	{
		return null;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00002C88 File Offset: 0x00000E88
	[Token(Token = "0x6000279")]
	public static implicit operator bool(BoltDoubleList<T> list)
	{
		return default(bool);
	}

	// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027A")]
	public BoltDoubleList()
	{
	}

	// Token: 0x04000134 RID: 308
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x0")]
	private T _first;

	// Token: 0x04000135 RID: 309
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x0")]
	private int _count;
}

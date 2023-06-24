using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000043 RID: 67
[Token(Token = "0x2000043")]
[Documentation(Ignore = true)]
public class BoltRingBuffer<T> : IEnumerable<T>, IEnumerable
{
	// Token: 0x17000098 RID: 152
	// (get) Token: 0x060002EA RID: 746 RVA: 0x00002FA0 File Offset: 0x000011A0
	[Token(Token = "0x17000098")]
	public bool full
	{
		[Token(Token = "0x60002EA")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060002EB RID: 747 RVA: 0x00002FB8 File Offset: 0x000011B8
	[Token(Token = "0x17000099")]
	public bool empty
	{
		[Token(Token = "0x60002EB")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x060002EC RID: 748 RVA: 0x00002FD0 File Offset: 0x000011D0
	// (set) Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700009A")]
	public bool autofree
	{
		[Token(Token = "0x60002EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002ED")]
		set
		{
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060002EE RID: 750 RVA: 0x00002FE8 File Offset: 0x000011E8
	[Token(Token = "0x1700009B")]
	public int count
	{
		[Token(Token = "0x60002EE")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x060002EF RID: 751 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700009C")]
	public T last
	{
		[Token(Token = "0x60002EF")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002F0")]
		set
		{
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x060002F1 RID: 753 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700009D")]
	public T first
	{
		[Token(Token = "0x60002F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002F2")]
		set
		{
		}
	}

	// Token: 0x1700009E RID: 158
	[Token(Token = "0x1700009E")]
	public T this[int index]
	{
		[Token(Token = "0x60002F3")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002F4")]
		set
		{
		}
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F5")]
	public BoltRingBuffer(int size)
	{
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F6")]
	public void Enqueue(T item)
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002F7")]
	public T Dequeue()
	{
		return null;
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002F8")]
	public T Peek()
	{
		return null;
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F9")]
	public void Clear()
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FA")]
	public void CopyTo(BoltRingBuffer<T> other)
	{
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FB")]
	private void VerifyNotEmpty()
	{
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002FC")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002FD")]
	private IEnumerator GetEnumerator()
	{
		return null;
	}

	// Token: 0x04000144 RID: 324
	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x0")]
	private int _head;

	// Token: 0x04000145 RID: 325
	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x0")]
	private int _tail;

	// Token: 0x04000146 RID: 326
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x0")]
	private int _count;

	// Token: 0x04000147 RID: 327
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x0")]
	private bool _autofree;

	// Token: 0x04000148 RID: 328
	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x0")]
	private readonly T[] array;
}

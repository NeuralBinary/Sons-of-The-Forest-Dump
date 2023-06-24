using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace NGUI.Internal
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public class BetterList<T>
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600033D")]
		[DebuggerStepThrough]
		[DebuggerHidden]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x170000D3 RID: 211
		[Token(Token = "0x170000D3")]
		[DebuggerHidden]
		public T this[int i]
		{
			[Token(Token = "0x600033E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600033F")]
			set
			{
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		private void AllocateMore()
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		private void Trim()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		public void Clear()
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		public void Release()
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		public void Add(T item)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x6000346")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x6000347")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x6000348")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600034A")]
		public T Pop()
		{
			return null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600034B")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public void Sort(BetterList<T>.CompareFunc comparer)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		public BetterList()
		{
		}

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x0")]
		public T[] buffer;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x0")]
		public int size;

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600034F RID: 847
		[Token(Token = "0x2000061")]
		public delegate int CompareFunc(T left, T right);
	}
}

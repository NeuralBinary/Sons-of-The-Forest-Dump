using System;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal class SimpleList<T>
	{
		// Token: 0x17000060 RID: 96
		[Token(Token = "0x17000060")]
		public T this[int i]
		{
			[Token(Token = "0x60001A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A5")]
			set
			{
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A6")]
		private void EnsureCapacity()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A7")]
		public void Add(T item)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A8")]
		public void Push(T item)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x60001A9")]
		public T Pop()
		{
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AA")]
		public void Clear()
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AB")]
		public SimpleList()
		{
		}

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x0")]
		public int Count;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x0")]
		private int capacity;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x0")]
		private T[] items;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	public class GridLookup<T> where T : class
	{
		// Token: 0x060009EA RID: 2538 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009EA")]
		public GridLookup(Int2 size)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		public GridLookup<T>.Root AllItems
		{
			[Token(Token = "0x60009EB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009EC")]
		public void Clear()
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009ED")]
		public GridLookup<T>.Root GetRoot(T item)
		{
			return null;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EE")]
		public GridLookup<T>.Root Add(T item, IntRect bounds)
		{
			return null;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009EF")]
		public void Remove(T item)
		{
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009F0")]
		public void Move(T item, IntRect bounds)
		{
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F1")]
		public List<U> QueryRect<U>(IntRect r) where U : class, T
		{
			return null;
		}

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x0")]
		private Int2 size;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x0")]
		private GridLookup<T>.Item[] cells;

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x0")]
		private GridLookup<T>.Root all;

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, GridLookup<T>.Root> rootLookup;

		// Token: 0x040006BA RID: 1722
		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x0")]
		private Stack<GridLookup<T>.Item> itemPool;

		// Token: 0x0200013B RID: 315
		[Token(Token = "0x200013B")]
		internal class Item
		{
			// Token: 0x060009F2 RID: 2546 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60009F2")]
			public Item()
			{
			}

			// Token: 0x040006BB RID: 1723
			[Token(Token = "0x40006BB")]
			[FieldOffset(Offset = "0x0")]
			public GridLookup<T>.Root root;

			// Token: 0x040006BC RID: 1724
			[Token(Token = "0x40006BC")]
			[FieldOffset(Offset = "0x0")]
			public GridLookup<T>.Item prev;

			// Token: 0x040006BD RID: 1725
			[Token(Token = "0x40006BD")]
			[FieldOffset(Offset = "0x0")]
			public GridLookup<T>.Item next;
		}

		// Token: 0x0200013C RID: 316
		[Token(Token = "0x200013C")]
		public class Root
		{
			// Token: 0x060009F3 RID: 2547 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60009F3")]
			public Root()
			{
			}

			// Token: 0x040006BE RID: 1726
			[Token(Token = "0x40006BE")]
			[FieldOffset(Offset = "0x0")]
			public T obj;

			// Token: 0x040006BF RID: 1727
			[Token(Token = "0x40006BF")]
			[FieldOffset(Offset = "0x0")]
			public GridLookup<T>.Root next;

			// Token: 0x040006C0 RID: 1728
			[Token(Token = "0x40006C0")]
			[FieldOffset(Offset = "0x0")]
			internal GridLookup<T>.Root prev;

			// Token: 0x040006C1 RID: 1729
			[Token(Token = "0x40006C1")]
			[FieldOffset(Offset = "0x0")]
			internal IntRect previousBounds;

			// Token: 0x040006C2 RID: 1730
			[Token(Token = "0x40006C2")]
			[FieldOffset(Offset = "0x0")]
			internal List<GridLookup<T>.Item> items;

			// Token: 0x040006C3 RID: 1731
			[Token(Token = "0x40006C3")]
			[FieldOffset(Offset = "0x0")]
			internal bool flag;
		}
	}
}

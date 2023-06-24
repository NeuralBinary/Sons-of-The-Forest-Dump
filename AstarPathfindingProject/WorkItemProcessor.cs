using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	internal class WorkItemProcessor : IWorkItemContext
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000401C File Offset: 0x0000221C
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C0")]
		public bool workItemsInProgressRightNow
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x170000C1")]
		public bool anyQueued
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x66E870", Offset = "0x66CE70", VA = "0x18066E870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0000404C File Offset: 0x0000224C
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C2")]
		public bool workItemsInProgress
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x66E8C0", Offset = "0x66CEC0", VA = "0x18066E8C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x66E8D0", Offset = "0x66CED0", VA = "0x18066E8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x66E8E0", Offset = "0x66CEE0", VA = "0x18066E8E0", Slot = "4")]
		private void QueueFloodFill()
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x66E8F0", Offset = "0x66CEF0", VA = "0x18066E8F0", Slot = "6")]
		private void SetGraphDirty(NavGraph graph)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x66E900", Offset = "0x66CF00", VA = "0x18066E900", Slot = "5")]
		public void EnsureValidFloodFill()
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x66E950", Offset = "0x66CF50", VA = "0x18066E950")]
		public WorkItemProcessor(AstarPath astar)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x66EAE0", Offset = "0x66D0E0", VA = "0x18066EAE0")]
		public void OnFloodFill()
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x66EAF0", Offset = "0x66D0F0", VA = "0x18066EAF0")]
		public void AddWorkItem(AstarWorkItem item)
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x66EB60", Offset = "0x66D160", VA = "0x18066EB60")]
		public bool ProcessWorkItems(bool force)
		{
			return default(bool);
		}

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x18")]
		private readonly AstarPath astar;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x20")]
		private readonly WorkItemProcessor.IndexedQueue<AstarWorkItem> workItems;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x28")]
		private bool queuedWorkItemFloodFill;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x29")]
		private bool anyGraphsDirty;

		// Token: 0x02000070 RID: 112
		[Token(Token = "0x2000070")]
		private class IndexedQueue<T>
		{
			// Token: 0x170000C3 RID: 195
			[Token(Token = "0x170000C3")]
			public T this[int index]
			{
				[Token(Token = "0x60003F6")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003F7")]
				set
				{
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000407C File Offset: 0x0000227C
			// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x170000C4")]
			public int Count
			{
				[Token(Token = "0x60003F8")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60003F9")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60003FA")]
			public void Enqueue(T item)
			{
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003FB")]
			public T Dequeue()
			{
				return null;
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60003FC")]
			public IndexedQueue()
			{
			}

			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			[FieldOffset(Offset = "0x0")]
			private T[] buffer;

			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			[FieldOffset(Offset = "0x0")]
			private int start;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	public class IndexPriorityQueue : IEnumerable<int>, IEnumerable
	{
		// Token: 0x06000383 RID: 899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1F449E0", Offset = "0x1F42FE0", VA = "0x181F449E0")]
		public IndexPriorityQueue(int maxID)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x17000073")]
		public int Count
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1F44B60", Offset = "0x1F43160", VA = "0x181F44B60")]
		public void Clear(bool bFreeMemory = true)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x17000074")]
		public int First
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x1F44C30", Offset = "0x1F43230", VA = "0x181F44C30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00003B6C File Offset: 0x00001D6C
		[Token(Token = "0x17000075")]
		public float FirstPriority
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x1F44CC0", Offset = "0x1F432C0", VA = "0x181F44CC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003B84 File Offset: 0x00001D84
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1F44D40", Offset = "0x1F43340", VA = "0x181F44D40")]
		public bool Contains(int id)
		{
			return default(bool);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1F44E10", Offset = "0x1F43410", VA = "0x181F44E10")]
		public void Insert(int id, float priority)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1F450A0", Offset = "0x1F436A0", VA = "0x181F450A0")]
		public void Enqueue(int id, float priority)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00003B9C File Offset: 0x00001D9C
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1F450B0", Offset = "0x1F436B0", VA = "0x181F450B0")]
		public int Dequeue()
		{
			return 0;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1F451A0", Offset = "0x1F437A0", VA = "0x181F451A0")]
		public void Remove(int id)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1F45240", Offset = "0x1F43840", VA = "0x181F45240")]
		public void Update(int id, float priority)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1F45440", Offset = "0x1F43A40", VA = "0x181F45440")]
		public float GetPriority(int id)
		{
			return 0f;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1F45560", Offset = "0x1F43B60", VA = "0x181F45560", Slot = "4")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1F45560", Offset = "0x1F43B60", VA = "0x181F45560", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1F455F0", Offset = "0x1F43BF0", VA = "0x181F455F0")]
		private void remove_at_index(int iNode)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1F45790", Offset = "0x1F43D90", VA = "0x181F45790")]
		private void swap_nodes_at_indices(int i1, int i2)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1F459A0", Offset = "0x1F43FA0", VA = "0x181F459A0")]
		private void move(int iFrom, int iTo)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1F45AD0", Offset = "0x1F440D0", VA = "0x181F45AD0")]
		private void set(int iTo, ref IndexPriorityQueue.QueueNode n)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1F45BA0", Offset = "0x1F441A0", VA = "0x181F45BA0")]
		private void move_up(int iNode)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1F45DA0", Offset = "0x1F443A0", VA = "0x181F45DA0")]
		private void move_down(int iNode)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1F45FD0", Offset = "0x1F445D0", VA = "0x181F45FD0")]
		private void on_node_updated(int iNode)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00003BCC File Offset: 0x00001DCC
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1F46030", Offset = "0x1F44630", VA = "0x181F46030")]
		private bool has_higher_priority(int iHigher, int iLower)
		{
			return default(bool);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1F46140", Offset = "0x1F44740", VA = "0x181F46140")]
		public bool IsValidQueue()
		{
			return default(bool);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1F461D0", Offset = "0x1F447D0", VA = "0x181F461D0")]
		public void DebugPrint()
		{
		}

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x10")]
		public bool EnableDebugChecks;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x18")]
		private DVector<IndexPriorityQueue.QueueNode> nodes;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x20")]
		private int num_nodes;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x28")]
		private int[] id_to_index;

		// Token: 0x020000A6 RID: 166
		[Token(Token = "0x20000A6")]
		private struct QueueNode
		{
			// Token: 0x040002A7 RID: 679
			[Token(Token = "0x40002A7")]
			[FieldOffset(Offset = "0x0")]
			public int id;

			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			[FieldOffset(Offset = "0x4")]
			public float priority;

			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			[FieldOffset(Offset = "0x8")]
			public int index;
		}
	}
}

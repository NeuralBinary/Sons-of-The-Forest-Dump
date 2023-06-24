using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public class DynamicPriorityQueue<T> : IEnumerable<T>, IEnumerable where T : DynamicPriorityQueueNode
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C2")]
		public DynamicPriorityQueue()
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x1700004E")]
		public int Count
		{
			[Token(Token = "0x60002C3")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C4")]
		public void Clear(bool bFreeMemory = true)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700004F")]
		public T First
		{
			[Token(Token = "0x60002C5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x17000050")]
		public float FirstPriority
		{
			[Token(Token = "0x60002C6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x60002C7")]
		public bool Contains(T node)
		{
			return default(bool);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C8")]
		public void Enqueue(T node, float priority)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C9")]
		public T Dequeue()
		{
			return null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CA")]
		public void Remove(T node)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CB")]
		public void Update(T node, float priority)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002CC")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002CD")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CE")]
		private void swap_nodes(T node1, T node2)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CF")]
		private void move_up(T node)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D0")]
		private void move_down(T node)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D1")]
		private void on_node_updated(T node)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000362C File Offset: 0x0000182C
		[Token(Token = "0x60002D2")]
		private bool has_higher_priority(T higher, T lower)
		{
			return default(bool);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00003644 File Offset: 0x00001844
		[Token(Token = "0x60002D3")]
		public bool IsValidQueue()
		{
			return default(bool);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D4")]
		public void DebugPrint()
		{
		}

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x0")]
		public bool EnableDebugChecks;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x0")]
		private DVector<T> nodes;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x0")]
		private int num_nodes;
	}
}

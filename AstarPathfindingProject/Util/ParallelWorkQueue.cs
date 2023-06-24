using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public class ParallelWorkQueue<T>
	{
		// Token: 0x06000A1F RID: 2591 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A1F")]
		public ParallelWorkQueue(Queue<T> queue)
		{
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A20")]
		public IEnumerable<int> Run(int progressTimeoutMillis)
		{
			return null;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A21")]
		private void RunTask(int threadIndex)
		{
		}

		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		[FieldOffset(Offset = "0x0")]
		public Action<T, int> action;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x0")]
		public readonly int threadCount;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x0")]
		private readonly Queue<T> queue;

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x0")]
		private readonly int initialCount;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x0")]
		private ManualResetEvent[] waitEvents;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x0")]
		private Exception innerException;
	}
}

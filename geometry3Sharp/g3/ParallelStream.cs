using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public class ParallelStream<V, T>
	{
		// Token: 0x06000330 RID: 816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000330")]
		public void Run_NoThreads(IEnumerable<V> sourceIn)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000331")]
		public void Run(IEnumerable<V> sourceIn)
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000332")]
		private void ProducerThreadFunc()
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000333")]
		private void ConsumerThreadFunc()
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000334")]
		public ParallelStream()
		{
		}

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x0")]
		public Func<V, T> ProducerF;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x0")]
		public Action<T> ConsumerF;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x0")]
		private LockingQueue<T> store0;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<V> source;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x0")]
		private bool producer_done;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x0")]
		private AutoResetEvent consumer_done_event;
	}
}

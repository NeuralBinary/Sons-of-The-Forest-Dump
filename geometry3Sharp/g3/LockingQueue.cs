using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public class LockingQueue<T>
	{
		// Token: 0x06000335 RID: 821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000335")]
		public LockingQueue()
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000038FC File Offset: 0x00001AFC
		[Token(Token = "0x6000336")]
		public bool Remove(ref T val)
		{
			return default(bool);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000337")]
		public void Add(T obj)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00003914 File Offset: 0x00001B14
		[Token(Token = "0x1700005F")]
		public int Count
		{
			[Token(Token = "0x6000338")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x0")]
		private Queue<T> queue;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x0")]
		private object queue_lock;
	}
}

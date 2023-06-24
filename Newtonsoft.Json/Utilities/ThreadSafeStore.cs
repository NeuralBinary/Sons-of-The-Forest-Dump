using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class ThreadSafeStore<TKey, TValue>
	{
		// Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071E")]
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600071F")]
		public TValue Get(TKey key)
		{
			return null;
		}

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x0")]
		private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<TKey, TValue> _creator;
	}
}

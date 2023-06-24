using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	internal static class ObjectPool<T> where T : new()
	{
		// Token: 0x06000BE2 RID: 3042 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000BE2")]
		public static T Alloc()
		{
			return null;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BE3")]
		public static void Free(T obj)
		{
		}

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<T> pool;
	}
}

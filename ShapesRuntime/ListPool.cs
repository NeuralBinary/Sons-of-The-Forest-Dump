using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	internal static class ListPool<T> where T : new()
	{
		// Token: 0x06000BE5 RID: 3045 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000BE5")]
		public static List<T> Alloc()
		{
			return null;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BE6")]
		public static void Free(List<T> list)
		{
		}

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<List<T>> pool;
	}
}

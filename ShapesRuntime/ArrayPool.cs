using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	internal static class ArrayPool<T>
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000BDF")]
		public static T[] Alloc(int maxCount)
		{
			return null;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BE0")]
		public static void Free(T[] obj)
		{
		}

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<T[]> pool;
	}
}

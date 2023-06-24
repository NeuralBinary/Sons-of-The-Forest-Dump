using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	public static class ArrayPool<T>
	{
		// Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000998")]
		public static T[] Claim(int minimumLength)
		{
			return null;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000999")]
		public static T[] ClaimWithExactLength(int length)
		{
			return null;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600099A")]
		public static void Release(ref T[] array, bool allowNonPowerOfTwo = false)
		{
		}

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		private const int MaximumExactArrayLength = 256;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<T[]>[] pool;

		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<T[]>[] exactPool;
	}
}

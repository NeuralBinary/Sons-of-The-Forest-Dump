using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	public static class StackPool<T>
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CE")]
		public static Stack<T> Claim()
		{
			return null;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009CF")]
		public static void Warmup(int count)
		{
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009D0")]
		public static void Release(Stack<T> stack)
		{
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009D1")]
		public static void Clear()
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0000644C File Offset: 0x0000464C
		[Token(Token = "0x60009D2")]
		public static int GetSize()
		{
			return 0;
		}

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Stack<T>> pool;
	}
}

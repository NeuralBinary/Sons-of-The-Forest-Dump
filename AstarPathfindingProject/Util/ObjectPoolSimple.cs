using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	public static class ObjectPoolSimple<T> where T : class, new()
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B5")]
		public static T Claim()
		{
			return null;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009B6")]
		public static void Release(ref T obj)
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009B7")]
		public static void Clear()
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0000638C File Offset: 0x0000458C
		[Token(Token = "0x60009B8")]
		public static int GetSize()
		{
			return 0;
		}

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0x0")]
		private static List<T> pool;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<T> inPool;
	}
}

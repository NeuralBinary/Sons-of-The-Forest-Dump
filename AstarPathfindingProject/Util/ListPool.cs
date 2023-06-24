using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	public static class ListPool<T>
	{
		// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A7")]
		public static List<T> Claim()
		{
			return null;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0000632C File Offset: 0x0000452C
		[Token(Token = "0x60009A8")]
		private static int FindCandidate(List<List<T>> pool, int capacity)
		{
			return 0;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A9")]
		public static List<T> Claim(int capacity)
		{
			return null;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009AA")]
		public static void Warmup(int count, int size)
		{
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009AB")]
		public static void Release(ref List<T> list)
		{
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009AC")]
		public static void Release(List<T> list)
		{
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009AD")]
		public static void Clear()
		{
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00006344 File Offset: 0x00004544
		[Token(Token = "0x60009AE")]
		public static int GetSize()
		{
			return 0;
		}

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<List<T>> pool;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<List<T>> largePool;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<List<T>> inPool;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		private const int MaxCapacitySearchLength = 8;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		private const int LargeThreshold = 5000;

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		private const int MaxLargePoolSize = 8;
	}
}

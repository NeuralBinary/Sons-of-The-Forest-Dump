using System;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public static class Memory
	{
		// Token: 0x06000A1B RID: 2587 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A1B")]
		public static void MemSet<T>(T[] array, T value, int byteSize) where T : struct
		{
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A1C")]
		public static void MemSet<T>(T[] array, T value, int totalSize, int byteSize) where T : struct
		{
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1D")]
		public static T[] ShrinkArray<T>(T[] arr, int newLength)
		{
			return null;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A1E")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}
	}
}

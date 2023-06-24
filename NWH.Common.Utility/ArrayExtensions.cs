using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace NWH.Common.Utility
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public static class ArrayExtensions
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		public static void Fill<T>(this T[] destinationArray, params T[] value)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		public static void FastCopyFrom<T>(this NativeArray<T> destination, T[] source) where T : struct
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		public static void FastCopyTo<T>(this NativeArray<T> source, T[] destination) where T : struct
		{
		}
	}
}

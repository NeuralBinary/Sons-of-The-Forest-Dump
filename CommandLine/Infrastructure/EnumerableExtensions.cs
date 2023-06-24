using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Infrastructure
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	internal static class EnumerableExtensions
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x60003E9")]
		public static int IndexOf<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return 0;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x9A2110", Offset = "0x9A0710", VA = "0x1809A2110")]
		public static object ToUntypedArray(this IEnumerable<object> value, Type type)
		{
			return null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x60003EB")]
		public static bool Empty<TSource>(this IEnumerable<TSource> source)
		{
			return default(bool);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EC")]
		public static IEnumerable<T[]> Group<T>(this IEnumerable<T> source, int groupSize)
		{
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	internal static class PartitionExtensions
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C6")]
		public static Tuple<IEnumerable<T>, IEnumerable<T>> PartitionByPredicate<T>(this IEnumerable<T> items, Func<T, bool> pred)
		{
			return null;
		}
	}
}

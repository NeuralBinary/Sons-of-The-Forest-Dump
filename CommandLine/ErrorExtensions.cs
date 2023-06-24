using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	internal static class ErrorExtensions
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		public static ParserResult<T> ToParserResult<T>(this IEnumerable<Error> errors, T instance)
		{
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x990AC0", Offset = "0x98F0C0", VA = "0x180990AC0")]
		public static IEnumerable<Error> OnlyMeaningfulOnes(this IEnumerable<Error> errors)
		{
			return null;
		}
	}
}

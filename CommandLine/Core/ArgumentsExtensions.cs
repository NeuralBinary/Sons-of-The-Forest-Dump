using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	internal static class ArgumentsExtensions
	{
		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x9A4830", Offset = "0x9A2E30", VA = "0x1809A4830")]
		public static IEnumerable<Error> Preprocess(this IEnumerable<string> arguments, IEnumerable<Func<IEnumerable<string>, IEnumerable<Error>>> preprocessorLookup)
		{
			return null;
		}
	}
}

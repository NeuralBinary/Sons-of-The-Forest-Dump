using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	internal static class OptionMapper
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x9AA2B0", Offset = "0x9A88B0", VA = "0x1809AA2B0")]
		public static Result<IEnumerable<SpecificationProperty>, Error> MapValues(IEnumerable<SpecificationProperty> propertyTuples, IEnumerable<KeyValuePair<string, IEnumerable<string>>> options, Func<IEnumerable<string>, Type, bool, bool, Maybe<object>> converter, StringComparer comparer)
		{
			return null;
		}
	}
}

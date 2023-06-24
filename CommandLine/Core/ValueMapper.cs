using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	internal static class ValueMapper
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x9C3710", Offset = "0x9C1D10", VA = "0x1809C3710")]
		public static Result<IEnumerable<SpecificationProperty>, Error> MapValues(IEnumerable<SpecificationProperty> specProps, IEnumerable<string> values, Func<IEnumerable<string>, Type, bool, Maybe<object>> converter)
		{
			return null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x9C3B30", Offset = "0x9C2130", VA = "0x1809C3B30")]
		private static IEnumerable<Tuple<SpecificationProperty, Maybe<Error>>> MapValuesImpl(IEnumerable<SpecificationProperty> specProps, IEnumerable<string> values, Func<IEnumerable<string>, Type, bool, Maybe<object>> converter)
		{
			return null;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x9C3CA0", Offset = "0x9C22A0", VA = "0x1809C3CA0")]
		private static Maybe<int> CountOfMaxNumberOfValues(this Specification specification)
		{
			return null;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x9C3DA0", Offset = "0x9C23A0", VA = "0x1809C3DA0")]
		private static Maybe<Error> MakeErrorInCaseOfMinConstraint(this Specification specification)
		{
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	internal static class SpecificationPropertyExtensions
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x9B15C0", Offset = "0x9AFBC0", VA = "0x1809B15C0")]
		public static SpecificationProperty WithSpecification(this SpecificationProperty specProp, Specification newSpecification)
		{
			return null;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x9B1640", Offset = "0x9AFC40", VA = "0x1809B1640")]
		public static SpecificationProperty WithValue(this SpecificationProperty specProp, Maybe<object> newValue)
		{
			return null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x9B16C0", Offset = "0x9AFCC0", VA = "0x1809B16C0")]
		public static Type GetConversionType(this SpecificationProperty specProp)
		{
			return null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x9B1900", Offset = "0x9AFF00", VA = "0x1809B1900")]
		public static IEnumerable<Error> Validate(this IEnumerable<SpecificationProperty> specProps, IEnumerable<Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>>> rules)
		{
			return null;
		}
	}
}

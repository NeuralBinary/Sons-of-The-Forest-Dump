using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	internal static class SpecificationPropertyRules
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x9B1A30", Offset = "0x9B0030", VA = "0x1809B1A30")]
		public static IEnumerable<Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>>> Lookup(IEnumerable<Token> tokens)
		{
			return null;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x9B1A40", Offset = "0x9B0040", VA = "0x1809B1A40")]
		public static IEnumerable<Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>>> Lookup(IEnumerable<Token> tokens, bool allowMultiInstance)
		{
			return null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x9B2310", Offset = "0x9B0910", VA = "0x1809B2310")]
		private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceMutuallyExclusiveSetAndGroupAreNotUsedTogether()
		{
			return null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x9B2440", Offset = "0x9B0A40", VA = "0x1809B2440")]
		private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceGroup()
		{
			return null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x9B2580", Offset = "0x9B0B80", VA = "0x1809B2580")]
		private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceMutuallyExclusiveSet()
		{
			return null;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x9B26C0", Offset = "0x9B0CC0", VA = "0x1809B26C0")]
		private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceRequired()
		{
			return null;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x9B2800", Offset = "0x9B0E00", VA = "0x1809B2800")]
		private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceRange()
		{
			return null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x9B2940", Offset = "0x9B0F40", VA = "0x1809B2940")]
		private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceSingle(IEnumerable<Token> tokens, bool allowMultiInstance)
		{
			return null;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x600053A")]
		private static bool ContainsIfNotEmpty<T>(this IEnumerable<T> sequence, T value)
		{
			return default(bool);
		}
	}
}

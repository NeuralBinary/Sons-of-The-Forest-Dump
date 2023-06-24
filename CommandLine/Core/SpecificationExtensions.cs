using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	internal static class SpecificationExtensions
	{
		// Token: 0x0600050F RID: 1295 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x9AF8B0", Offset = "0x9ADEB0", VA = "0x1809AF8B0")]
		public static bool IsOption(this Specification specification)
		{
			return default(bool);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x9AF8D0", Offset = "0x9ADED0", VA = "0x1809AF8D0")]
		public static bool IsValue(this Specification specification)
		{
			return default(bool);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x9AF8F0", Offset = "0x9ADEF0", VA = "0x1809AF8F0")]
		public static OptionSpecification WithLongName(this OptionSpecification specification, string newLongName)
		{
			return null;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x9AFAD0", Offset = "0x9AE0D0", VA = "0x1809AFAD0")]
		public static string UniqueName(this OptionSpecification specification)
		{
			return null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x9AFB00", Offset = "0x9AE100", VA = "0x1809AFB00")]
		public static IEnumerable<Specification> ThrowingValidate(this IEnumerable<Specification> specifications, IEnumerable<Tuple<Func<Specification, bool>, string>> guardsLookup)
		{
			return null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x9AFE10", Offset = "0x9AE410", VA = "0x1809AFE10")]
		public static bool HavingRange(this Specification specification, Func<int, int, bool> predicate)
		{
			return default(bool);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x9AFED0", Offset = "0x9AE4D0", VA = "0x1809AFED0")]
		public static bool HavingMin(this Specification specification, Func<int, bool> predicate)
		{
			return default(bool);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x9AFF60", Offset = "0x9AE560", VA = "0x1809AFF60")]
		public static bool HavingMax(this Specification specification, Func<int, bool> predicate)
		{
			return default(bool);
		}
	}
}

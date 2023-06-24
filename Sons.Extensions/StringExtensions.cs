using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Sons.Extensions
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public static class StringExtensions
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2FCC5E0", Offset = "0x2FCABE0", VA = "0x182FCC5E0")]
		public static bool Matches([CanBeNull] this IEnumerable<string> labels, string search, StringComparison comparisonType = StringComparison.InvariantCultureIgnoreCase)
		{
			return default(bool);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2FCC700", Offset = "0x2FCAD00", VA = "0x182FCC700")]
		public static string ToPascalCase(this string str)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2FCC860", Offset = "0x2FCAE60", VA = "0x182FCC860")]
		public static string SanitizeFilename(this string str)
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2FCCA10", Offset = "0x2FCB010", VA = "0x182FCCA10")]
		public static int IndexOf(this StringBuilder sb, string value, int startIndex, bool ignoreCase)
		{
			return 0;
		}
	}
}

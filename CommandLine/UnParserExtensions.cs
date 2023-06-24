using System;
using CommandLine.Core;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public static class UnParserExtensions
	{
		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		public static string FormatCommandLine<T>(this Parser parser, T options)
		{
			return null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		public static string[] FormatCommandLineArgs<T>(this Parser parser, T options)
		{
			return null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		public static string FormatCommandLine<T>(this Parser parser, T options, Action<UnParserSettings> configuration)
		{
			return null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		public static string[] FormatCommandLineArgs<T>(this Parser parser, T options, Action<UnParserSettings> configuration)
		{
			return null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x9944F0", Offset = "0x992AF0", VA = "0x1809944F0")]
		private static string FormatValue(Specification spec, object value)
		{
			return null;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x9948E0", Offset = "0x992EE0", VA = "0x1809948E0")]
		private static object FormatWithQuotesIfString(object value)
		{
			return null;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x994C80", Offset = "0x993280", VA = "0x180994C80")]
		private static char SeperatorOrSpace(this Specification spec)
		{
			return '\0';
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x994EF0", Offset = "0x9934F0", VA = "0x180994EF0")]
		private static string FormatOption(OptionSpecification spec, object value, UnParserSettings settings)
		{
			return null;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x995010", Offset = "0x993610", VA = "0x180995010")]
		private static string FormatName(this OptionSpecification optionSpec, object value, UnParserSettings settings)
		{
			return null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		private static object NormalizeValue(this object value)
		{
			return null;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x9952A0", Offset = "0x9938A0", VA = "0x1809952A0")]
		private static bool IsEmpty(this object value, Specification specification, bool skipDefault)
		{
			return default(bool);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x995540", Offset = "0x993B40", VA = "0x180995540")]
		public static string[] SplitArgs(this string command, bool keepQuote = false)
		{
			return null;
		}
	}
}

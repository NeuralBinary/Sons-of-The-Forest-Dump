using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	internal static class GetoptTokenizer
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x9A4BC0", Offset = "0x9A31C0", VA = "0x1809A4BC0")]
		public static Result<IEnumerable<Token>, Error> Tokenize(IEnumerable<string> arguments, Func<string, NameLookupResult> nameLookup)
		{
			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x9A4BF0", Offset = "0x9A31F0", VA = "0x1809A4BF0")]
		public static Result<IEnumerable<Token>, Error> Tokenize(IEnumerable<string> arguments, Func<string, NameLookupResult> nameLookup, bool ignoreUnknownArguments, bool allowDashDash, bool posixlyCorrect)
		{
			return null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x9A5330", Offset = "0x9A3930", VA = "0x1809A5330")]
		public static Result<IEnumerable<Token>, Error> ExplodeOptionList(Result<IEnumerable<Token>, Error> tokenizerResult, Func<string, Maybe<char>> optionSequenceWithSeparatorLookup)
		{
			return null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x9A58B0", Offset = "0x9A3EB0", VA = "0x1809A58B0")]
		public static Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> ConfigureTokenizer(StringComparer nameComparer, bool ignoreUnknownArguments, bool enableDashDash, bool posixlyCorrect)
		{
			return null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x9A59D0", Offset = "0x9A3FD0", VA = "0x1809A59D0")]
		private static IEnumerable<Token> TokenizeShortName(string arg, Func<string, NameLookupResult> nameLookup, Action<string> onUnknownOption, Action<int> onConsumeNext)
		{
			return null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x9A5BA0", Offset = "0x9A41A0", VA = "0x1809A5BA0")]
		private static IEnumerable<Token> TokenizeLongName(string arg, Func<string, NameLookupResult> nameLookup, Action<string> onBadFormatToken, Action<string> onUnknownOption, Action<int> onConsumeNext)
		{
			return null;
		}
	}
}

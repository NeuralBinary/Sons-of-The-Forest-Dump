using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	internal static class Tokenizer
	{
		// Token: 0x060005AF RID: 1455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x9BB7C0", Offset = "0x9B9DC0", VA = "0x1809BB7C0")]
		public static Result<IEnumerable<Token>, Error> Tokenize(IEnumerable<string> arguments, Func<string, NameLookupResult> nameLookup)
		{
			return null;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x9BB920", Offset = "0x9B9F20", VA = "0x1809BB920")]
		public static Result<IEnumerable<Token>, Error> Tokenize(IEnumerable<string> arguments, Func<string, NameLookupResult> nameLookup, Func<IEnumerable<Token>, IEnumerable<Token>> normalize)
		{
			return null;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x9BBF10", Offset = "0x9BA510", VA = "0x1809BBF10")]
		public static Result<IEnumerable<Token>, Error> PreprocessDashDash(IEnumerable<string> arguments, Func<IEnumerable<string>, Result<IEnumerable<Token>, Error>> tokenizer)
		{
			return null;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x9BC5A0", Offset = "0x9BABA0", VA = "0x1809BC5A0")]
		public static Result<IEnumerable<Token>, Error> ExplodeOptionList(Result<IEnumerable<Token>, Error> tokenizerResult, Func<string, Maybe<char>> optionSequenceWithSeparatorLookup)
		{
			return null;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x9BCB20", Offset = "0x9BB120", VA = "0x1809BCB20")]
		public static IEnumerable<Token> Normalize(IEnumerable<Token> tokens, Func<string, bool> nameLookup)
		{
			return null;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x9BD0E0", Offset = "0x9BB6E0", VA = "0x1809BD0E0")]
		public static Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> ConfigureTokenizer(StringComparer nameComparer, bool ignoreUnknownArguments, bool enableDashDash)
		{
			return null;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x9BD1E0", Offset = "0x9BB7E0", VA = "0x1809BD1E0")]
		private static IEnumerable<Token> TokenizeShortName(string value, Func<string, NameLookupResult> nameLookup)
		{
			return null;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x9BD2F0", Offset = "0x9BB8F0", VA = "0x1809BD2F0")]
		private static IEnumerable<Token> TokenizeLongName(string value, Action<Error> onError)
		{
			return null;
		}
	}
}

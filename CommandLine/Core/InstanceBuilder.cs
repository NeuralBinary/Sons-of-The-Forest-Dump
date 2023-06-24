using System;
using System.Collections.Generic;
using System.Globalization;
using CSharpx;
using Il2CppDummyDll;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	internal static class InstanceBuilder
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000450")]
		public static ParserResult<T> Build<T>(Maybe<Func<T>> factory, Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> tokenizer, IEnumerable<string> arguments, StringComparer nameComparer, bool ignoreValueCase, CultureInfo parsingCulture, bool autoHelp, bool autoVersion, IEnumerable<ErrorType> nonFatalErrors)
		{
			return null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000451")]
		public static ParserResult<T> Build<T>(Maybe<Func<T>> factory, Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> tokenizer, IEnumerable<string> arguments, StringComparer nameComparer, bool ignoreValueCase, CultureInfo parsingCulture, bool autoHelp, bool autoVersion, bool allowMultiInstance, IEnumerable<ErrorType> nonFatalErrors)
		{
			return null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000452")]
		private static T BuildMutable<T>(Maybe<Func<T>> factory, IEnumerable<SpecificationProperty> specPropsWithValue, List<Error> setPropertyErrors)
		{
			return null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000453")]
		private static T BuildImmutable<T>(Type typeInfo, Maybe<Func<T>> factory, IEnumerable<SpecificationProperty> specProps, IEnumerable<SpecificationProperty> specPropsWithValue, List<Error> setPropertyErrors)
		{
			return null;
		}
	}
}

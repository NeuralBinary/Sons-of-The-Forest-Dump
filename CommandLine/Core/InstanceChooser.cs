using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	internal static class InstanceChooser
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x9A6DF0", Offset = "0x9A53F0", VA = "0x1809A6DF0")]
		public static ParserResult<object> Choose(Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> tokenizer, IEnumerable<Type> types, IEnumerable<string> arguments, StringComparer nameComparer, bool ignoreValueCase, CultureInfo parsingCulture, bool autoHelp, bool autoVersion, IEnumerable<ErrorType> nonFatalErrors)
		{
			return null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x9A6E50", Offset = "0x9A5450", VA = "0x1809A6E50")]
		public static ParserResult<object> Choose(Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> tokenizer, IEnumerable<Type> types, IEnumerable<string> arguments, StringComparer nameComparer, bool ignoreValueCase, CultureInfo parsingCulture, bool autoHelp, bool autoVersion, bool allowMultiInstance, IEnumerable<ErrorType> nonFatalErrors)
		{
			return null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x9A7490", Offset = "0x9A5A90", VA = "0x1809A7490")]
		private static ParserResult<object> MatchDefaultVerb(Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> tokenizer, IEnumerable<Tuple<Verb, Type>> verbs, Tuple<Verb, Type> defaultVerb, IEnumerable<string> arguments, StringComparer nameComparer, bool ignoreValueCase, CultureInfo parsingCulture, bool autoHelp, bool autoVersion, IEnumerable<ErrorType> nonFatalErrors)
		{
			return null;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x9A78D0", Offset = "0x9A5ED0", VA = "0x1809A78D0")]
		private static ParserResult<object> MatchVerb(Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> tokenizer, IEnumerable<Tuple<Verb, Type>> verbs, Tuple<Verb, Type> defaultVerb, IEnumerable<string> arguments, StringComparer nameComparer, bool ignoreValueCase, CultureInfo parsingCulture, bool autoHelp, bool autoVersion, bool allowMultiInstance, IEnumerable<ErrorType> nonFatalErrors)
		{
			return null;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x9A7C50", Offset = "0x9A6250", VA = "0x1809A7C50")]
		private static HelpVerbRequestedError MakeHelpVerbRequestedError(IEnumerable<Tuple<Verb, Type>> verbs, string verb, StringComparer nameComparer)
		{
			return null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x9A8030", Offset = "0x9A6630", VA = "0x1809A8030")]
		private static NotParsed<object> MakeNotParsed(IEnumerable<Type> types, params Error[] errors)
		{
			return null;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x9A8170", Offset = "0x9A6770", VA = "0x1809A8170")]
		[CompilerGenerated]
		internal static ParserResult<object> <Choose>g__choose|1_1(ref InstanceChooser.<>c__DisplayClass1_0 A_0)
		{
			return null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x9A8490", Offset = "0x9A6A90", VA = "0x1809A8490")]
		[CompilerGenerated]
		internal static bool <Choose>g__preprocCompare|1_2(string command, ref InstanceChooser.<>c__DisplayClass1_0 A_1, ref InstanceChooser.<>c__DisplayClass1_1 A_2)
		{
			return default(bool);
		}
	}
}

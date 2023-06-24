using System;
using System.Collections.Generic;
using System.IO;
using CommandLine.Core;
using Il2CppDummyDll;
using RailwaySharp.ErrorHandling;

namespace CommandLine
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public class Parser : IDisposable
	{
		// Token: 0x06000209 RID: 521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x9921B0", Offset = "0x9907B0", VA = "0x1809921B0")]
		public Parser()
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x992260", Offset = "0x990860", VA = "0x180992260")]
		public Parser(Action<ParserSettings> configuration)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x992380", Offset = "0x990980", VA = "0x180992380")]
		internal Parser(ParserSettings settings)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x9923F0", Offset = "0x9909F0", VA = "0x1809923F0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public static Parser Default
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x992410", Offset = "0x990A10", VA = "0x180992410")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		public ParserSettings Settings
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		public ParserResult<T> ParseArguments<T>(IEnumerable<string> args)
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		public ParserResult<T> ParseArguments<T>(Func<T> factory, IEnumerable<string> args)
		{
			return null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x9924B0", Offset = "0x990AB0", VA = "0x1809924B0")]
		public ParserResult<object> ParseArguments(IEnumerable<string> args, params Type[] types)
		{
			return null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x992750", Offset = "0x990D50", VA = "0x180992750", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x992830", Offset = "0x990E30", VA = "0x180992830")]
		private static Result<IEnumerable<Token>, Error> Tokenize(IEnumerable<string> arguments, IEnumerable<OptionSpecification> optionSpecs, ParserSettings settings)
		{
			return null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		private static ParserResult<T> MakeParserResult<T>(ParserResult<T> parserResult, ParserSettings settings)
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		private static ParserResult<T> DisplayHelp<T>(ParserResult<T> parserResult, TextWriter helpWriter, int maxDisplayWidth)
		{
			return null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x992AC0", Offset = "0x9910C0", VA = "0x180992AC0")]
		private static IEnumerable<ErrorType> HandleUnknownArguments(bool ignoreUnknownArguments)
		{
			return null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x992B40", Offset = "0x991140", VA = "0x180992B40")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x10")]
		private bool disposed;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x18")]
		private readonly ParserSettings settings;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Lazy<Parser> DefaultParser;
	}
}

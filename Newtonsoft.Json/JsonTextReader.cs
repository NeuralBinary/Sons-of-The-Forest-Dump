using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[Nullable(0)]
	[NullableContext(1)]
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2501380", Offset = "0x24FF980", VA = "0x182501380", Slot = "5")]
		public override Task<bool> ReadAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2501510", Offset = "0x24FFB10", VA = "0x182501510")]
		internal Task<bool> DoReadAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2501740", Offset = "0x24FFD40", VA = "0x182501740")]
		private Task<bool> DoReadAsync(Task<bool> task, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2501980", Offset = "0x24FFF80", VA = "0x182501980")]
		private Task<bool> ParsePostValueAsync(bool ignoreComments, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2501B80", Offset = "0x2500180", VA = "0x182501B80")]
		private Task<bool> ReadFromFinishedAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2501D70", Offset = "0x2500370", VA = "0x182501D70")]
		private Task<int> ReadDataAsync(bool append, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2501D90", Offset = "0x2500390", VA = "0x182501D90")]
		private Task<int> ReadDataAsync(bool append, int charsRequired, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2501FA0", Offset = "0x25005A0", VA = "0x182501FA0")]
		private Task<bool> ParseValueAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2502190", Offset = "0x2500790", VA = "0x182502190")]
		private Task ReadStringIntoBufferAsync(char quote, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x25023B0", Offset = "0x25009B0", VA = "0x1825023B0")]
		private Task ProcessCarriageReturnAsync(bool append, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2502510", Offset = "0x2500B10", VA = "0x182502510")]
		private Task ProcessCarriageReturnAsync(Task<bool> task)
		{
			return null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x25026F0", Offset = "0x2500CF0", VA = "0x1825026F0")]
		private Task<char> ParseUnicodeAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x25028D0", Offset = "0x2500ED0", VA = "0x1825028D0")]
		private Task<bool> EnsureCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x25029B0", Offset = "0x2500FB0", VA = "0x1825029B0")]
		private Task<bool> ReadCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2502BC0", Offset = "0x25011C0", VA = "0x182502BC0")]
		private Task<bool> ParseObjectAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2502DB0", Offset = "0x25013B0", VA = "0x182502DB0")]
		private Task ParseCommentAsync(bool setToken, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2502FC0", Offset = "0x25015C0", VA = "0x182502FC0")]
		private Task EatWhitespaceAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x25031B0", Offset = "0x25017B0", VA = "0x1825031B0")]
		private Task ParseStringAsync(char quote, ReadType readType, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x25033C0", Offset = "0x25019C0", VA = "0x1825033C0")]
		private Task<bool> MatchValueAsync(string value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2503600", Offset = "0x2501C00", VA = "0x182503600")]
		private Task<bool> MatchValueWithTrailingSeparatorAsync(string value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2503840", Offset = "0x2501E40", VA = "0x182503840")]
		private Task MatchAndSetAsync(string value, JsonToken newToken, [Nullable(2)] object tokenValue, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2503AE0", Offset = "0x25020E0", VA = "0x182503AE0")]
		private Task ParseTrueAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2503B90", Offset = "0x2502190", VA = "0x182503B90")]
		private Task ParseFalseAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2503CD0", Offset = "0x25022D0", VA = "0x182503CD0")]
		private Task ParseNullAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2503D50", Offset = "0x2502350", VA = "0x182503D50")]
		private Task ParseConstructorAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2503F50", Offset = "0x2502550", VA = "0x182503F50")]
		private Task<object> ParseNumberNaNAsync(ReadType readType, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2504140", Offset = "0x2502740", VA = "0x182504140")]
		private Task<object> ParseNumberPositiveInfinityAsync(ReadType readType, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2504330", Offset = "0x2502930", VA = "0x182504330")]
		private Task<object> ParseNumberNegativeInfinityAsync(ReadType readType, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2504520", Offset = "0x2502B20", VA = "0x182504520")]
		private Task ParseNumberAsync(ReadType readType, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2504720", Offset = "0x2502D20", VA = "0x182504720")]
		private Task ParseUndefinedAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x25047A0", Offset = "0x2502DA0", VA = "0x1825047A0")]
		private Task<bool> ParsePropertyAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2504990", Offset = "0x2502F90", VA = "0x182504990")]
		private Task ReadNumberIntoBufferAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2504B80", Offset = "0x2503180", VA = "0x182504B80")]
		private Task ParseUnquotedPropertyAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2504D70", Offset = "0x2503370", VA = "0x182504D70")]
		private Task<bool> ReadNullCharAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2504F50", Offset = "0x2503550", VA = "0x182504F50")]
		private Task HandleNullAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2505140", Offset = "0x2503740", VA = "0x182505140")]
		private Task ReadFinishedAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2505330", Offset = "0x2503930", VA = "0x182505330")]
		private Task<object> ReadStringValueAsync(ReadType readType, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2505530", Offset = "0x2503B30", VA = "0x182505530")]
		private Task<object> ReadNumberValueAsync(ReadType readType, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2505730", Offset = "0x2503D30", VA = "0x182505730", Slot = "6")]
		public override Task<bool?> ReadAsBooleanAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x25058A0", Offset = "0x2503EA0", VA = "0x1825058A0")]
		internal Task<bool?> DoReadAsBooleanAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2505A90", Offset = "0x2504090", VA = "0x182505A90", Slot = "7")]
		public override Task<byte[]> ReadAsBytesAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2505BB0", Offset = "0x25041B0", VA = "0x182505BB0")]
		internal Task<byte[]> DoReadAsBytesAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2505DA0", Offset = "0x25043A0", VA = "0x182505DA0")]
		private Task ReadIntoWrappedTypeObjectAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2505F80", Offset = "0x2504580", VA = "0x182505F80", Slot = "8")]
		public override Task<DateTime?> ReadAsDateTimeAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2505FA0", Offset = "0x25045A0", VA = "0x182505FA0")]
		internal Task<DateTime?> DoReadAsDateTimeAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2506180", Offset = "0x2504780", VA = "0x182506180", Slot = "9")]
		public override Task<DateTimeOffset?> ReadAsDateTimeOffsetAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x25061A0", Offset = "0x25047A0", VA = "0x1825061A0")]
		internal Task<DateTimeOffset?> DoReadAsDateTimeOffsetAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2506380", Offset = "0x2504980", VA = "0x182506380", Slot = "10")]
		public override Task<decimal?> ReadAsDecimalAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x25063A0", Offset = "0x25049A0", VA = "0x1825063A0")]
		internal Task<decimal?> DoReadAsDecimalAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2506580", Offset = "0x2504B80", VA = "0x182506580", Slot = "11")]
		public override Task<double?> ReadAsDoubleAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x25066B0", Offset = "0x2504CB0", VA = "0x1825066B0")]
		internal Task<double?> DoReadAsDoubleAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2506890", Offset = "0x2504E90", VA = "0x182506890", Slot = "12")]
		public override Task<int?> ReadAsInt32Async([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2506A00", Offset = "0x2505000", VA = "0x182506A00")]
		internal Task<int?> DoReadAsInt32Async(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2506BE0", Offset = "0x25051E0", VA = "0x182506BE0", Slot = "13")]
		public override Task<string> ReadAsStringAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2506D00", Offset = "0x2505300", VA = "0x182506D00")]
		internal Task<string> DoReadAsStringAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2506EE0", Offset = "0x25054E0", VA = "0x182506EE0")]
		public JsonTextReader(TextReader reader)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000080")]
		[Nullable(2)]
		public JsonNameTable PropertyNameTable
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x784A40", Offset = "0x783040", VA = "0x180784A40")]
			[NullableContext(2)]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000081")]
		[Nullable(2)]
		public IArrayPool<char> ArrayPool
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x2507070", Offset = "0x2505670", VA = "0x182507070")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2507120", Offset = "0x2505720", VA = "0x182507120")]
		private void EnsureBufferNotEmpty()
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2507260", Offset = "0x2505860", VA = "0x182507260")]
		private void SetNewLine(bool hasNextChar)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x25072C0", Offset = "0x25058C0", VA = "0x1825072C0")]
		private void OnNewLine(int pos)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x25072D0", Offset = "0x25058D0", VA = "0x1825072D0")]
		private void ParseString(char quote, ReadType readType)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2507330", Offset = "0x2505930", VA = "0x182507330")]
		private void ParseReadString(char quote, ReadType readType)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2507930", Offset = "0x2505F30", VA = "0x182507930")]
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2507950", Offset = "0x2505F50", VA = "0x182507950")]
		private void ShiftBufferIfNeeded()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2507A20", Offset = "0x2506020", VA = "0x182507A20")]
		private int ReadData(bool append)
		{
			return 0;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2507A30", Offset = "0x2506030", VA = "0x182507A30")]
		private void PrepareBufferForReadData(bool append, int charsRequired)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2507D30", Offset = "0x2506330", VA = "0x182507D30")]
		private int ReadData(bool append, int charsRequired)
		{
			return 0;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2507DF0", Offset = "0x25063F0", VA = "0x182507DF0")]
		private bool EnsureChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2507F30", Offset = "0x2506530", VA = "0x182507F30")]
		private bool ReadChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2508060", Offset = "0x2506660", VA = "0x182508060", Slot = "21")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x25083E0", Offset = "0x25069E0", VA = "0x1825083E0", Slot = "22")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x25084C0", Offset = "0x2506AC0", VA = "0x1825084C0", Slot = "28")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x25085A0", Offset = "0x2506BA0", VA = "0x1825085A0", Slot = "23")]
		[NullableContext(2)]
		public override string ReadAsString()
		{
			return null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2508600", Offset = "0x2506C00", VA = "0x182508600", Slot = "24")]
		[NullableContext(2)]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2508EA0", Offset = "0x25074A0", VA = "0x182508EA0")]
		[NullableContext(2)]
		private object ReadStringValue(ReadType readType)
		{
			return null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2509890", Offset = "0x2507E90", VA = "0x182509890")]
		[NullableContext(2)]
		private object FinishReadQuotedStringValue(ReadType readType)
		{
			return null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2509B50", Offset = "0x2508150", VA = "0x182509B50")]
		private JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			return null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2509C40", Offset = "0x2508240", VA = "0x182509C40", Slot = "26")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x250A520", Offset = "0x2508B20", VA = "0x18250A520")]
		private void ProcessValueComma()
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x250A5A0", Offset = "0x2508BA0", VA = "0x18250A5A0")]
		[NullableContext(2)]
		private object ReadNumberValue(ReadType readType)
		{
			return null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x250AD80", Offset = "0x2509380", VA = "0x18250AD80")]
		[NullableContext(2)]
		private object FinishReadQuotedNumber(ReadType readType)
		{
			return null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x250AF20", Offset = "0x2509520", VA = "0x18250AF20", Slot = "29")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x250B010", Offset = "0x2509610", VA = "0x18250B010", Slot = "27")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x250B100", Offset = "0x2509700", VA = "0x18250B100", Slot = "25")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x250B1E0", Offset = "0x25097E0", VA = "0x18250B1E0")]
		private void HandleNull()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x250B2E0", Offset = "0x25098E0", VA = "0x18250B2E0")]
		private void ReadFinished()
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x250B490", Offset = "0x2509A90", VA = "0x18250B490")]
		private bool ReadNullChar()
		{
			return default(bool);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x250B4E0", Offset = "0x2509AE0", VA = "0x18250B4E0")]
		private void EnsureBuffer()
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x250B5D0", Offset = "0x2509BD0", VA = "0x18250B5D0")]
		private void ReadStringIntoBuffer(char quote)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x250BB70", Offset = "0x250A170", VA = "0x18250BB70")]
		private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x250BDA0", Offset = "0x250A3A0", VA = "0x18250BDA0")]
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x250BE50", Offset = "0x250A450", VA = "0x18250BE50")]
		private char ConvertUnicode(bool enoughChars)
		{
			return '\0';
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x250C070", Offset = "0x250A670", VA = "0x18250C070")]
		private char ParseUnicode()
		{
			return '\0';
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x250C0A0", Offset = "0x250A6A0", VA = "0x18250C0A0")]
		private void ReadNumberIntoBuffer()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x250C120", Offset = "0x250A720", VA = "0x18250C120")]
		private bool ReadNumberCharIntoBuffer(char currentChar, int charPos)
		{
			return default(bool);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x250C2E0", Offset = "0x250A8E0", VA = "0x18250C2E0")]
		private void ClearRecentString()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x250C300", Offset = "0x250A900", VA = "0x18250C300")]
		private bool ParsePostValue(bool ignoreComments)
		{
			return default(bool);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x250C7C0", Offset = "0x250ADC0", VA = "0x18250C7C0")]
		private bool ParseObject()
		{
			return default(bool);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x250CA20", Offset = "0x250B020", VA = "0x18250CA20")]
		private bool ParseProperty()
		{
			return default(bool);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x250CF30", Offset = "0x250B530", VA = "0x18250CF30")]
		private bool ValidIdentifierChar(char value)
		{
			return default(bool);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x250CFA0", Offset = "0x250B5A0", VA = "0x18250CFA0")]
		private void ParseUnquotedProperty()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x250D150", Offset = "0x250B750", VA = "0x18250D150")]
		private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition)
		{
			return default(bool);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x250D390", Offset = "0x250B990", VA = "0x18250D390")]
		private bool ParseValue()
		{
			return default(bool);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x250DF60", Offset = "0x250C560", VA = "0x18250DF60")]
		private void ProcessLineFeed()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x250DF80", Offset = "0x250C580", VA = "0x18250DF80")]
		private void ProcessCarriageReturn(bool append)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x250DFF0", Offset = "0x250C5F0", VA = "0x18250DFF0")]
		private void EatWhitespace()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x250E160", Offset = "0x250C760", VA = "0x18250E160")]
		private void ParseConstructor()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x250E6D0", Offset = "0x250CCD0", VA = "0x18250E6D0")]
		private void ParseNumber(ReadType readType)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x250E7C0", Offset = "0x250CDC0", VA = "0x18250E7C0")]
		private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition)
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x25101D0", Offset = "0x250E7D0", VA = "0x1825101D0")]
		private JsonReaderException ThrowReaderError(string message, [Nullable(2)] [Optional] Exception ex)
		{
			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x25102A0", Offset = "0x250E8A0", VA = "0x1825102A0")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object BigIntegerParse(string number, CultureInfo culture)
		{
			return null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2510320", Offset = "0x250E920", VA = "0x182510320")]
		private void ParseComment(bool setToken)
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x25106C0", Offset = "0x250ECC0", VA = "0x1825106C0")]
		private void EndComment(bool setToken, int initialPosition, int endPosition)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2510780", Offset = "0x250ED80", VA = "0x182510780")]
		private bool MatchValue(string value)
		{
			return default(bool);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x25107D0", Offset = "0x250EDD0", VA = "0x1825107D0")]
		private bool MatchValue(bool enoughChars, string value)
		{
			return default(bool);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x25108A0", Offset = "0x250EEA0", VA = "0x1825108A0")]
		private bool MatchValueWithTrailingSeparator(string value)
		{
			return default(bool);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2510970", Offset = "0x250EF70", VA = "0x182510970")]
		private bool IsSeparator(char c)
		{
			return default(bool);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2510AB0", Offset = "0x250F0B0", VA = "0x182510AB0")]
		private void ParseTrue()
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2510C20", Offset = "0x250F220", VA = "0x182510C20")]
		private void ParseNull()
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2510D50", Offset = "0x250F350", VA = "0x182510D50")]
		private void ParseUndefined()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2510E80", Offset = "0x250F480", VA = "0x182510E80")]
		private void ParseFalse()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2510FF0", Offset = "0x250F5F0", VA = "0x182510FF0")]
		private object ParseNumberNegativeInfinity(ReadType readType)
		{
			return null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2511070", Offset = "0x250F670", VA = "0x182511070")]
		private object ParseNumberNegativeInfinity(ReadType readType, bool matched)
		{
			return null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2511340", Offset = "0x250F940", VA = "0x182511340")]
		private object ParseNumberPositiveInfinity(ReadType readType)
		{
			return null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x25113C0", Offset = "0x250F9C0", VA = "0x1825113C0")]
		private object ParseNumberPositiveInfinity(ReadType readType, bool matched)
		{
			return null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2511690", Offset = "0x250FC90", VA = "0x182511690")]
		private object ParseNumberNaN(ReadType readType)
		{
			return null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2511710", Offset = "0x250FD10", VA = "0x182511710")]
		private object ParseNumberNaN(ReadType readType, bool matched)
		{
			return null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x25119E0", Offset = "0x250FFE0", VA = "0x1825119E0", Slot = "31")]
		public override void Close()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "32")]
		public bool HasLineInfo()
		{
			return default(bool);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x17000082")]
		public int LineNumber
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2511B50", Offset = "0x2510150", VA = "0x182511B50", Slot = "33")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x17000083")]
		public int LinePosition
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2511BA0", Offset = "0x25101A0", VA = "0x182511BA0", Slot = "34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly bool _safeAsync;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		private const char UnicodeReplacementChar = '�';

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		private const int MaximumJavascriptIntegerCharacterLength = 380;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		private const int LargeBufferLength = 1073741823;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly TextReader _reader;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Nullable(2)]
		private char[] _chars;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _charsUsed;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _charPos;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _lineStartPos;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _lineNumber;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _isEndOfFile;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private StringBuffer _stringBuffer;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private StringReference _stringReference;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Nullable(2)]
		private IArrayPool<char> _arrayPool;
	}
}

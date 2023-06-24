using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class JsonReader : IDisposable
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x24F33A0", Offset = "0x24F19A0", VA = "0x1824F33A0", Slot = "5")]
		[NullableContext(1)]
		public virtual Task<bool> ReadAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x24F3520", Offset = "0x24F1B20", VA = "0x1824F3520")]
		[NullableContext(1)]
		public Task SkipAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x24F3710", Offset = "0x24F1D10", VA = "0x1824F3710")]
		[NullableContext(1)]
		internal Task ReaderReadAndAssertAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x24F38F0", Offset = "0x24F1EF0", VA = "0x1824F38F0", Slot = "6")]
		[NullableContext(1)]
		public virtual Task<bool?> ReadAsBooleanAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x24F3A50", Offset = "0x24F2050", VA = "0x1824F3A50", Slot = "7")]
		public virtual Task<byte[]> ReadAsBytesAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x24F3B50", Offset = "0x24F2150", VA = "0x1824F3B50")]
		internal Task<byte[]> ReadArrayIntoByteArrayAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x24F3D30", Offset = "0x24F2330", VA = "0x1824F3D30", Slot = "8")]
		[NullableContext(1)]
		public virtual Task<DateTime?> ReadAsDateTimeAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x24F3EF0", Offset = "0x24F24F0", VA = "0x1824F3EF0", Slot = "9")]
		[NullableContext(1)]
		public virtual Task<DateTimeOffset?> ReadAsDateTimeOffsetAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x24F40C0", Offset = "0x24F26C0", VA = "0x1824F40C0", Slot = "10")]
		[NullableContext(1)]
		public virtual Task<decimal?> ReadAsDecimalAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x24F4290", Offset = "0x24F2890", VA = "0x1824F4290", Slot = "11")]
		[NullableContext(1)]
		public virtual Task<double?> ReadAsDoubleAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x24F43A0", Offset = "0x24F29A0", VA = "0x1824F43A0", Slot = "12")]
		[NullableContext(1)]
		public virtual Task<int?> ReadAsInt32Async([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x24F4500", Offset = "0x24F2B00", VA = "0x1824F4500", Slot = "13")]
		public virtual Task<string> ReadAsStringAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x24F4600", Offset = "0x24F2C00", VA = "0x1824F4600")]
		[NullableContext(1)]
		internal Task<bool> ReadAndMoveToContentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x24F47E0", Offset = "0x24F2DE0", VA = "0x1824F47E0")]
		[NullableContext(1)]
		internal Task<bool> MoveToContentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x24F4880", Offset = "0x24F2E80", VA = "0x1824F4880")]
		[NullableContext(1)]
		private Task<bool> MoveToContentFromNonContentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x1700002D")]
		protected JsonReader.State CurrentState
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return JsonReader.State.Start;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public bool CloseInput
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x671160", Offset = "0x66F760", VA = "0x180671160")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public bool SupportMultipleContent
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x24F4A60", Offset = "0x24F3060", VA = "0x1824F4A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x24F4A70", Offset = "0x24F3070", VA = "0x1824F4A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		public virtual char QuoteChar
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x24F4A80", Offset = "0x24F3080", VA = "0x1824F4A80", Slot = "14")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x24F4A90", Offset = "0x24F3090", VA = "0x1824F4A90", Slot = "15")]
			protected internal set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x24F4AA0", Offset = "0x24F30A0", VA = "0x1824F4AA0")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public DateParseHandling DateParseHandling
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
			get
			{
				return DateParseHandling.None;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x24F4B10", Offset = "0x24F3110", VA = "0x1824F4B10")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x784B50", Offset = "0x783150", VA = "0x180784B50")]
			get
			{
				return FloatParseHandling.Double;
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x24F4B80", Offset = "0x24F3180", VA = "0x1824F4B80")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public string DateFormatString
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public int? MaxDepth
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x24F4BF0", Offset = "0x24F31F0", VA = "0x1824F4BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x24F4C00", Offset = "0x24F3200", VA = "0x1824F4C00")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000036")]
		public virtual JsonToken TokenType
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "16")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000037")]
		public virtual object Value
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000038")]
		public virtual Type ValueType
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x24F4CC0", Offset = "0x24F32C0", VA = "0x1824F4CC0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x17000039")]
		public virtual int Depth
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x24F4CE0", Offset = "0x24F32E0", VA = "0x1824F4CE0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700003A")]
		[Nullable(1)]
		public virtual string Path
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x24F4D50", Offset = "0x24F3350", VA = "0x1824F4D50", Slot = "20")]
			[NullableContext(1)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		[Nullable(1)]
		public CultureInfo Culture
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x24F4E90", Offset = "0x24F3490", VA = "0x1824F4E90")]
			[NullableContext(1)]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[NullableContext(1)]
			set
			{
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x24F4F20", Offset = "0x24F3520", VA = "0x1824F4F20")]
		internal JsonPosition GetPosition(int depth)
		{
			return default(JsonPosition);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x24F4FD0", Offset = "0x24F35D0", VA = "0x1824F4FD0")]
		protected JsonReader()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x24F5030", Offset = "0x24F3630", VA = "0x1824F5030")]
		private void Push(JsonContainerType value)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x24F5380", Offset = "0x24F3980", VA = "0x1824F5380")]
		private JsonContainerType Pop()
		{
			return JsonContainerType.None;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
		private JsonContainerType Peek()
		{
			return JsonContainerType.None;
		}

		// Token: 0x06000102 RID: 258
		[Token(Token = "0x6000102")]
		public abstract bool Read();

		// Token: 0x06000103 RID: 259 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x24F5510", Offset = "0x24F3B10", VA = "0x1824F5510", Slot = "22")]
		public virtual int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x24F5940", Offset = "0x24F3F40", VA = "0x1824F5940")]
		internal int? ReadInt32String(string s)
		{
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x24F5D00", Offset = "0x24F4300", VA = "0x1824F5D00", Slot = "23")]
		public virtual string ReadAsString()
		{
			return null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x24F5FA0", Offset = "0x24F45A0", VA = "0x1824F5FA0", Slot = "24")]
		public virtual byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x24F66D0", Offset = "0x24F4CD0", VA = "0x1824F66D0")]
		[NullableContext(1)]
		internal byte[] ReadArrayIntoByteArray()
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x24F68B0", Offset = "0x24F4EB0", VA = "0x1824F68B0")]
		[NullableContext(1)]
		private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer)
		{
			return default(bool);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x24F6AA0", Offset = "0x24F50A0", VA = "0x1824F6AA0", Slot = "25")]
		public virtual double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x24F6E30", Offset = "0x24F5430", VA = "0x1824F6E30")]
		internal double? ReadDoubleString(string s)
		{
			return null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x24F7140", Offset = "0x24F5740", VA = "0x1824F7140", Slot = "26")]
		public virtual bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x24F7520", Offset = "0x24F5B20", VA = "0x1824F7520")]
		internal bool? ReadBooleanString(string s)
		{
			return null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x24F78E0", Offset = "0x24F5EE0", VA = "0x1824F78E0", Slot = "27")]
		public virtual decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x24F7D70", Offset = "0x24F6370", VA = "0x1824F7D70")]
		internal decimal? ReadDecimalString(string s)
		{
			return null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x24F8160", Offset = "0x24F6760", VA = "0x1824F8160", Slot = "28")]
		public virtual DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x24F8460", Offset = "0x24F6A60", VA = "0x1824F8460")]
		internal DateTime? ReadDateTimeString(string s)
		{
			return null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x24F8870", Offset = "0x24F6E70", VA = "0x1824F8870", Slot = "29")]
		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x24F8BA0", Offset = "0x24F71A0", VA = "0x1824F8BA0")]
		internal DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			return null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x24F8F90", Offset = "0x24F7590", VA = "0x1824F8F90")]
		internal void ReaderReadAndAssert()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x24F8FE0", Offset = "0x24F75E0", VA = "0x1824F8FE0")]
		[NullableContext(1)]
		internal JsonReaderException CreateUnexpectedEndException()
		{
			return null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x24F9020", Offset = "0x24F7620", VA = "0x1824F9020")]
		internal void ReadIntoWrappedTypeObject()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x24F93D0", Offset = "0x24F79D0", VA = "0x1824F93D0")]
		public void Skip()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x24F9480", Offset = "0x24F7A80", VA = "0x1824F9480")]
		protected void SetToken(JsonToken newToken)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x24F94A0", Offset = "0x24F7AA0", VA = "0x1824F94A0")]
		protected void SetToken(JsonToken newToken, object value)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x24F94C0", Offset = "0x24F7AC0", VA = "0x1824F94C0")]
		protected void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x24F96E0", Offset = "0x24F7CE0", VA = "0x1824F96E0")]
		internal void SetPostValueState(bool updateIndex)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x24F9710", Offset = "0x24F7D10", VA = "0x1824F9710")]
		private void UpdateScopeWithFinishedValue()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x24F9720", Offset = "0x24F7D20", VA = "0x1824F9720")]
		private void ValidateEnd(JsonToken endToken)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x24F98E0", Offset = "0x24F7EE0", VA = "0x1824F98E0")]
		protected void SetStateBasedOnCurrent()
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x24F99F0", Offset = "0x24F7FF0", VA = "0x1824F99F0")]
		private void SetFinished()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x24F9A10", Offset = "0x24F8010", VA = "0x1824F9A10")]
		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			return JsonContainerType.None;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x24F9AF0", Offset = "0x24F80F0", VA = "0x1824F9AF0", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x24F9B80", Offset = "0x24F8180", VA = "0x1824F9B80", Slot = "30")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x24F9BB0", Offset = "0x24F81B0", VA = "0x1824F9BB0", Slot = "31")]
		public virtual void Close()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x24F9C10", Offset = "0x24F8210", VA = "0x1824F9C10")]
		internal void ReadAndAssert()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x24F9C70", Offset = "0x24F8270", VA = "0x1824F9C70")]
		internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x24F9CC0", Offset = "0x24F82C0", VA = "0x1824F9CC0")]
		internal bool ReadForType(JsonContract contract, bool hasConverter)
		{
			return default(bool);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x24F9F80", Offset = "0x24F8580", VA = "0x1824F9F80")]
		internal bool ReadAndMoveToContent()
		{
			return default(bool);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x24F9FE0", Offset = "0x24F85E0", VA = "0x1824F9FE0")]
		internal bool MoveToContent()
		{
			return default(bool);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x24FA040", Offset = "0x24F8640", VA = "0x1824FA040")]
		private JsonToken GetContentToken()
		{
			return JsonToken.None;
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JsonToken _tokenType;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _value;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal char _quoteChar;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal JsonReader.State _currentState;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private JsonPosition _currentPosition;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CultureInfo _culture;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int? _maxDepth;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _hasExceededMaxDepth;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal DateParseHandling _dateParseHandling;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal FloatParseHandling _floatParseHandling;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _dateFormatString;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<JsonPosition> _stack;

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		[NullableContext(0)]
		protected internal enum State
		{
			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			Start,
			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			Complete,
			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			Property,
			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			ObjectStart,
			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			Object,
			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			ArrayStart,
			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			Array,
			// Token: 0x04000078 RID: 120
			[Token(Token = "0x4000078")]
			Closed,
			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			PostValue,
			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			ConstructorStart,
			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			Constructor,
			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			Error,
			// Token: 0x0400007D RID: 125
			[Token(Token = "0x400007D")]
			Finished
		}
	}
}

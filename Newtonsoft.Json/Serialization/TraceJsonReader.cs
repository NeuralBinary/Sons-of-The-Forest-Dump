using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x25A3A60", Offset = "0x25A2060", VA = "0x1825A3A60")]
		public TraceJsonReader(JsonReader innerReader)
		{
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x25A3D30", Offset = "0x25A2330", VA = "0x1825A3D30")]
		public string GetDeserializedJsonMessage()
		{
			return null;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x25A3D60", Offset = "0x25A2360", VA = "0x1825A3D60", Slot = "21")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x25A3DE0", Offset = "0x25A23E0", VA = "0x1825A3DE0", Slot = "22")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x25A3E60", Offset = "0x25A2460", VA = "0x1825A3E60", Slot = "23")]
		[NullableContext(2)]
		public override string ReadAsString()
		{
			return null;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x25A3EE0", Offset = "0x25A24E0", VA = "0x1825A3EE0", Slot = "24")]
		[NullableContext(2)]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x25A3F60", Offset = "0x25A2560", VA = "0x1825A3F60", Slot = "27")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x25A3FF0", Offset = "0x25A25F0", VA = "0x1825A3FF0", Slot = "25")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x25A4070", Offset = "0x25A2670", VA = "0x1825A4070", Slot = "26")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x25A40F0", Offset = "0x25A26F0", VA = "0x1825A40F0", Slot = "28")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x25A4170", Offset = "0x25A2770", VA = "0x1825A4170", Slot = "29")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x25A4200", Offset = "0x25A2800", VA = "0x1825A4200")]
		public void WriteCurrentToken()
		{
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x17000173")]
		public override int Depth
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x2538400", Offset = "0x2536A00", VA = "0x182538400", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000174")]
		public override string Path
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x2538430", Offset = "0x2536A30", VA = "0x182538430", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000052F8 File Offset: 0x000034F8
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000175")]
		public override char QuoteChar
		{
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x2538460", Offset = "0x2536A60", VA = "0x182538460", Slot = "14")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x25A4250", Offset = "0x25A2850", VA = "0x1825A4250", Slot = "15")]
			protected internal set
			{
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x17000176")]
		public override JsonToken TokenType
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x2538490", Offset = "0x2536A90", VA = "0x182538490", Slot = "16")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000177")]
		[Nullable(2)]
		public override object Value
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x25383D0", Offset = "0x25369D0", VA = "0x1825383D0", Slot = "17")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000178")]
		[Nullable(2)]
		public override Type ValueType
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x25384C0", Offset = "0x2536AC0", VA = "0x1825384C0", Slot = "18")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x25A4280", Offset = "0x25A2880", VA = "0x1825A4280", Slot = "31")]
		public override void Close()
		{
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x25A42B0", Offset = "0x25A28B0", VA = "0x1825A42B0", Slot = "32")]
		private bool HasLineInfo()
		{
			return default(bool);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x17000179")]
		private int LineNumber
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x25A4310", Offset = "0x25A2910", VA = "0x1825A4310", Slot = "33")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x1700017A")]
		private int LinePosition
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x25A4370", Offset = "0x25A2970", VA = "0x1825A4370", Slot = "34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x78")]
		private readonly JsonReader _innerReader;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x80")]
		private readonly JsonTextWriter _textWriter;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x88")]
		private readonly StringWriter _sw;
	}
}

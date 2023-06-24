using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[NullableContext(1)]
	[Nullable(0)]
	public class JsonSerializer
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual event EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x24FBCD0", Offset = "0x24FA2D0", VA = "0x1824FBCD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x24FBE40", Offset = "0x24FA440", VA = "0x1824FBE40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		[Nullable(2)]
		public virtual IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x24FBFB0", Offset = "0x24FA5B0", VA = "0x1824FBFB0", Slot = "6")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x24FBFC0", Offset = "0x24FA5C0", VA = "0x1824FBFC0", Slot = "7")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public virtual SerializationBinder Binder
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x24FC090", Offset = "0x24FA690", VA = "0x1824FC090", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x24FC180", Offset = "0x24FA780", VA = "0x1824FC180", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public virtual ISerializationBinder SerializationBinder
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x24FC2D0", Offset = "0x24FA8D0", VA = "0x1824FC2D0", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		[Nullable(2)]
		public virtual ITraceWriter TraceWriter
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "12")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0", Slot = "13")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		[Nullable(2)]
		public virtual IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070", Slot = "14")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080", Slot = "15")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public virtual TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "16")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x24FC3A0", Offset = "0x24FA9A0", VA = "0x1824FC3A0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002688 File Offset: 0x00000888
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500", Slot = "18")]
			get
			{
				return FormatterAssemblyStyle.Simple;
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x24FC410", Offset = "0x24FAA10", VA = "0x1824FC410", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000026A0 File Offset: 0x000008A0
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500", Slot = "20")]
			get
			{
				return TypeNameAssemblyFormatHandling.Simple;
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x24FC480", Offset = "0x24FAA80", VA = "0x1824FC480", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "22")]
			get
			{
				return PreserveReferencesHandling.None;
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x24FC4F0", Offset = "0x24FAAF0", VA = "0x1824FC4F0", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000026D0 File Offset: 0x000008D0
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0", Slot = "24")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x24FC560", Offset = "0x24FAB60", VA = "0x1824FC560", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000026E8 File Offset: 0x000008E8
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public virtual MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "26")]
			get
			{
				return MissingMemberHandling.Ignore;
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x24FC5D0", Offset = "0x24FABD0", VA = "0x1824FC5D0", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		public virtual NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "28")]
			get
			{
				return NullValueHandling.Include;
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x24FC640", Offset = "0x24FAC40", VA = "0x1824FC640", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		public virtual DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020", Slot = "30")]
			get
			{
				return DefaultValueHandling.Include;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x24FC6B0", Offset = "0x24FACB0", VA = "0x1824FC6B0", Slot = "31")]
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002730 File Offset: 0x00000930
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0", Slot = "32")]
			get
			{
				return ObjectCreationHandling.Auto;
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x24FC720", Offset = "0x24FAD20", VA = "0x1824FC720", Slot = "33")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002748 File Offset: 0x00000948
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		public virtual ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0", Slot = "34")]
			get
			{
				return ConstructorHandling.Default;
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x24FC790", Offset = "0x24FAD90", VA = "0x1824FC790", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00002760 File Offset: 0x00000960
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0", Slot = "36")]
			get
			{
				return MetadataPropertyHandling.Default;
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x24FC800", Offset = "0x24FAE00", VA = "0x1824FC800", Slot = "37")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000052")]
		public virtual JsonConverterCollection Converters
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x24FC870", Offset = "0x24FAE70", VA = "0x1824FC870", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public virtual IContractResolver ContractResolver
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "39")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x24FC940", Offset = "0x24FAF40", VA = "0x1824FC940", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002778 File Offset: 0x00000978
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		public virtual StreamingContext Context
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x24FCA30", Offset = "0x24FB030", VA = "0x1824FCA30", Slot = "41")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x24FCA40", Offset = "0x24FB040", VA = "0x1824FCA40", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002790 File Offset: 0x00000990
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public virtual Formatting Formatting
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x24FCAA0", Offset = "0x24FB0A0", VA = "0x1824FCAA0", Slot = "43")]
			get
			{
				return Formatting.None;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x24FCAE0", Offset = "0x24FB0E0", VA = "0x1824FCAE0", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000027A8 File Offset: 0x000009A8
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public virtual DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x24FCB40", Offset = "0x24FB140", VA = "0x1824FCB40", Slot = "45")]
			get
			{
				return DateFormatHandling.IsoDateFormat;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x24FCB80", Offset = "0x24FB180", VA = "0x1824FCB80", Slot = "46")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000027C0 File Offset: 0x000009C0
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public virtual DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x24FCBE0", Offset = "0x24FB1E0", VA = "0x1824FCBE0", Slot = "47")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x24FCC40", Offset = "0x24FB240", VA = "0x1824FCC40", Slot = "48")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000027D8 File Offset: 0x000009D8
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public virtual DateParseHandling DateParseHandling
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x24FCCA0", Offset = "0x24FB2A0", VA = "0x1824FCCA0", Slot = "49")]
			get
			{
				return DateParseHandling.None;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x24FCD00", Offset = "0x24FB300", VA = "0x1824FCD00", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public virtual FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x24FCD60", Offset = "0x24FB360", VA = "0x1824FCD60", Slot = "51")]
			get
			{
				return FloatParseHandling.Double;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x24FCDA0", Offset = "0x24FB3A0", VA = "0x1824FCDA0", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public virtual FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x24FCE00", Offset = "0x24FB400", VA = "0x1824FCE00", Slot = "53")]
			get
			{
				return FloatFormatHandling.String;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x24FCE40", Offset = "0x24FB440", VA = "0x1824FCE40", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public virtual StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x24FCEA0", Offset = "0x24FB4A0", VA = "0x1824FCEA0", Slot = "55")]
			get
			{
				return StringEscapeHandling.Default;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x24FCEE0", Offset = "0x24FB4E0", VA = "0x1824FCEE0", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		public virtual string DateFormatString
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x24FCF40", Offset = "0x24FB540", VA = "0x1824FCF40", Slot = "57")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x24FCF80", Offset = "0x24FB580", VA = "0x1824FCF80", Slot = "58")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public virtual CultureInfo Culture
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x24FCFF0", Offset = "0x24FB5F0", VA = "0x1824FCFF0", Slot = "59")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x135A8E0", Offset = "0x1358EE0", VA = "0x18135A8E0", Slot = "60")]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public virtual int? MaxDepth
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190", Slot = "61")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x24FD060", Offset = "0x24FB660", VA = "0x1824FD060", Slot = "62")]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00002850 File Offset: 0x00000A50
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		public virtual bool CheckAdditionalContent
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x24FD120", Offset = "0x24FB720", VA = "0x1824FD120", Slot = "63")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x24FD160", Offset = "0x24FB760", VA = "0x1824FD160", Slot = "64")]
			set
			{
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x24FD1B0", Offset = "0x24FB7B0", VA = "0x1824FD1B0")]
		internal bool IsCheckAdditionalContentSet()
		{
			return default(bool);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x24FD1F0", Offset = "0x24FB7F0", VA = "0x1824FD1F0")]
		public JsonSerializer()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x24FD460", Offset = "0x24FBA60", VA = "0x1824FD460")]
		public static JsonSerializer Create()
		{
			return null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x24FD4B0", Offset = "0x24FBAB0", VA = "0x1824FD4B0")]
		public static JsonSerializer Create([Nullable(2)] JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x24FD520", Offset = "0x24FBB20", VA = "0x1824FD520")]
		public static JsonSerializer CreateDefault()
		{
			return null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x24FD610", Offset = "0x24FBC10", VA = "0x1824FD610")]
		public static JsonSerializer CreateDefault([Nullable(2)] JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x24FD650", Offset = "0x24FBC50", VA = "0x1824FD650")]
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x24FDFF0", Offset = "0x24FC5F0", VA = "0x1824FDFF0")]
		[DebuggerStepThrough]
		public void Populate(TextReader reader, object target)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x24FE080", Offset = "0x24FC680", VA = "0x1824FE080")]
		[DebuggerStepThrough]
		public void Populate(JsonReader reader, object target)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x24FE0A0", Offset = "0x24FC6A0", VA = "0x1824FE0A0", Slot = "65")]
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x24FE3B0", Offset = "0x24FC9B0", VA = "0x1824FE3B0")]
		[DebuggerStepThrough]
		public object Deserialize(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x24FE3D0", Offset = "0x24FC9D0", VA = "0x1824FE3D0")]
		[DebuggerStepThrough]
		public object Deserialize(TextReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000193")]
		[DebuggerStepThrough]
		[NullableContext(2)]
		public T Deserialize<T>([Nullable(1)] JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x24FE460", Offset = "0x24FCA60", VA = "0x1824FE460")]
		[DebuggerStepThrough]
		[NullableContext(2)]
		public object Deserialize([Nullable(1)] JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x24FE480", Offset = "0x24FCA80", VA = "0x1824FE480", Slot = "66")]
		[NullableContext(2)]
		internal virtual object DeserializeInternal([Nullable(1)] JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x24FE750", Offset = "0x24FCD50", VA = "0x1824FE750")]
		[NullableContext(2)]
		internal void SetupReader([Nullable(1)] JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x24FEC60", Offset = "0x24FD260", VA = "0x1824FEC60")]
		[NullableContext(2)]
		private void ResetReader([Nullable(1)] JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x24FEEF0", Offset = "0x24FD4F0", VA = "0x1824FEEF0")]
		public void Serialize(TextWriter textWriter, [Nullable(2)] object value)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x24FEF80", Offset = "0x24FD580", VA = "0x1824FEF80")]
		[NullableContext(2)]
		public void Serialize([Nullable(1)] JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x24FEFA0", Offset = "0x24FD5A0", VA = "0x1824FEFA0")]
		public void Serialize(TextWriter textWriter, [Nullable(2)] object value, Type objectType)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x24FF040", Offset = "0x24FD640", VA = "0x1824FF040")]
		public void Serialize(JsonWriter jsonWriter, [Nullable(2)] object value)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x24FF070", Offset = "0x24FD670", VA = "0x1824FF070")]
		private TraceJsonReader CreateTraceJsonReader(JsonReader reader)
		{
			return null;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x24FF120", Offset = "0x24FD720", VA = "0x1824FF120", Slot = "67")]
		[NullableContext(2)]
		internal virtual void SerializeInternal([Nullable(1)] JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x24FF810", Offset = "0x24FDE10", VA = "0x1824FF810")]
		internal IReferenceResolver GetReferenceResolver()
		{
			return null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x24FF8A0", Offset = "0x24FDEA0", VA = "0x1824FF8A0")]
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x24FF8B0", Offset = "0x24FDEB0", VA = "0x1824FF8B0")]
		internal static JsonConverter GetMatchingConverter([Nullable(new byte[]
		{
			2,
			1
		})] IList<JsonConverter> converters, Type objectType)
		{
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x24FF970", Offset = "0x24FDF70", VA = "0x1824FF970")]
		internal void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e)
		{
		}

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x10")]
		internal TypeNameHandling _typeNameHandling;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x14")]
		internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x18")]
		internal PreserveReferencesHandling _preserveReferencesHandling;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x1C")]
		internal ReferenceLoopHandling _referenceLoopHandling;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x20")]
		internal MissingMemberHandling _missingMemberHandling;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x24")]
		internal ObjectCreationHandling _objectCreationHandling;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x28")]
		internal NullValueHandling _nullValueHandling;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x2C")]
		internal DefaultValueHandling _defaultValueHandling;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x30")]
		internal ConstructorHandling _constructorHandling;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x34")]
		internal MetadataPropertyHandling _metadataPropertyHandling;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x38")]
		[Nullable(2)]
		internal JsonConverterCollection _converters;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x40")]
		internal IContractResolver _contractResolver;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x48")]
		[Nullable(2)]
		internal ITraceWriter _traceWriter;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x50")]
		[Nullable(2)]
		internal IEqualityComparer _equalityComparer;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x58")]
		internal ISerializationBinder _serializationBinder;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x60")]
		internal StreamingContext _context;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x70")]
		[Nullable(2)]
		private IReferenceResolver _referenceResolver;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x78")]
		private Formatting? _formatting;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x80")]
		private DateFormatHandling? _dateFormatHandling;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x88")]
		private DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x90")]
		private DateParseHandling? _dateParseHandling;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x98")]
		private FloatFormatHandling? _floatFormatHandling;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0xA0")]
		private FloatParseHandling? _floatParseHandling;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0xA8")]
		private StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0xB0")]
		private CultureInfo _culture;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0xB8")]
		private int? _maxDepth;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0xC0")]
		private bool _maxDepthSet;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xC1")]
		private bool? _checkAdditionalContent;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xC8")]
		[Nullable(2)]
		private string _dateFormatString;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xD0")]
		private bool _dateFormatStringSet;
	}
}

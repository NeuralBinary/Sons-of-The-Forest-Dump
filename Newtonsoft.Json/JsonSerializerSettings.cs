using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonSerializerSettings
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002880 File Offset: 0x00000A80
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x24FF990", Offset = "0x24FDF90", VA = "0x1824FF990")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x24FF9D0", Offset = "0x24FDFD0", VA = "0x1824FF9D0")]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00002898 File Offset: 0x00000A98
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x24FFA30", Offset = "0x24FE030", VA = "0x1824FFA30")]
			get
			{
				return MissingMemberHandling.Ignore;
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x24FFA70", Offset = "0x24FE070", VA = "0x1824FFA70")]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000028B0 File Offset: 0x00000AB0
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x24FFAD0", Offset = "0x24FE0D0", VA = "0x1824FFAD0")]
			get
			{
				return ObjectCreationHandling.Auto;
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x24FFB10", Offset = "0x24FE110", VA = "0x1824FFB10")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000028C8 File Offset: 0x00000AC8
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x24FFB70", Offset = "0x24FE170", VA = "0x1824FFB70")]
			get
			{
				return NullValueHandling.Include;
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x24FFBB0", Offset = "0x24FE1B0", VA = "0x1824FFBB0")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x24FFC10", Offset = "0x24FE210", VA = "0x1824FFC10")]
			get
			{
				return DefaultValueHandling.Include;
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x24FFC50", Offset = "0x24FE250", VA = "0x1824FFC50")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		[Nullable(1)]
		public IList<JsonConverter> Converters
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
			[CompilerGenerated]
			[NullableContext(1)]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x784AB0", Offset = "0x7830B0", VA = "0x180784AB0")]
			[NullableContext(1)]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x24FFCB0", Offset = "0x24FE2B0", VA = "0x1824FFCB0")]
			get
			{
				return PreserveReferencesHandling.None;
			}
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x24FFCF0", Offset = "0x24FE2F0", VA = "0x1824FFCF0")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		public TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x24FFD50", Offset = "0x24FE350", VA = "0x1824FFD50")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x24FFD90", Offset = "0x24FE390", VA = "0x1824FFD90")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00002928 File Offset: 0x00000B28
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x24FFDF0", Offset = "0x24FE3F0", VA = "0x1824FFDF0")]
			get
			{
				return MetadataPropertyHandling.Default;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x24FFE30", Offset = "0x24FE430", VA = "0x1824FFE30")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x24FFE90", Offset = "0x24FE490", VA = "0x1824FFE90")]
			get
			{
				return FormatterAssemblyStyle.Simple;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x24FFED0", Offset = "0x24FE4D0", VA = "0x1824FFED0")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002958 File Offset: 0x00000B58
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x24FFE90", Offset = "0x24FE490", VA = "0x1824FFE90")]
			get
			{
				return TypeNameAssemblyFormatHandling.Simple;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x24FFED0", Offset = "0x24FE4D0", VA = "0x1824FFED0")]
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		public ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x24FFF30", Offset = "0x24FE530", VA = "0x1824FFF30")]
			get
			{
				return ConstructorHandling.Default;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x24FFF70", Offset = "0x24FE570", VA = "0x1824FFF70")]
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public IContractResolver ContractResolver
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x784BB0", Offset = "0x7831B0", VA = "0x180784BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x691530", Offset = "0x68FB30", VA = "0x180691530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xA2FF40", Offset = "0xA2E540", VA = "0x180A2FF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006E")]
		[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
		public IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x24FFFD0", Offset = "0x24FE5D0", VA = "0x1824FFFD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x24FFFF0", Offset = "0x24FE5F0", VA = "0x1824FFFF0")]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006F")]
		public Func<IReferenceResolver> ReferenceResolverProvider
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xA3F1B0", Offset = "0xA3D7B0", VA = "0x180A3F1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xA3F1C0", Offset = "0xA3D7C0", VA = "0x180A3F1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public ITraceWriter TraceWriter
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xA3F220", Offset = "0xA3D820", VA = "0x180A3F220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xA3F230", Offset = "0xA3D830", VA = "0x180A3F230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000071")]
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public SerializationBinder Binder
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x2500170", Offset = "0x24FE770", VA = "0x182500170")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x2500230", Offset = "0x24FE830", VA = "0x182500230")]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		public ISerializationBinder SerializationBinder
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x8DF490", Offset = "0x8DDA90", VA = "0x1808DF490")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x8DF500", Offset = "0x8DDB00", VA = "0x1808DF500")]
			[CompilerGenerated]
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		public StreamingContext Context
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x2500350", Offset = "0x24FE950", VA = "0x182500350")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x2500410", Offset = "0x24FEA10", VA = "0x182500410")]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000075")]
		[Nullable(1)]
		public string DateFormatString
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2500530", Offset = "0x24FEB30", VA = "0x182500530")]
			[NullableContext(1)]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2500570", Offset = "0x24FEB70", VA = "0x182500570")]
			[NullableContext(1)]
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000029A0 File Offset: 0x00000BA0
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		public int? MaxDepth
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x25005D0", Offset = "0x24FEBD0", VA = "0x1825005D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2500630", Offset = "0x24FEC30", VA = "0x182500630")]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000029B8 File Offset: 0x00000BB8
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		public Formatting Formatting
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x25006F0", Offset = "0x24FECF0", VA = "0x1825006F0")]
			get
			{
				return Formatting.None;
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x2500730", Offset = "0x24FED30", VA = "0x182500730")]
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000029D0 File Offset: 0x00000BD0
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000078")]
		public DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x2500790", Offset = "0x24FED90", VA = "0x182500790")]
			get
			{
				return DateFormatHandling.IsoDateFormat;
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x25007D0", Offset = "0x24FEDD0", VA = "0x1825007D0")]
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000029E8 File Offset: 0x00000BE8
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x2500830", Offset = "0x24FEE30", VA = "0x182500830")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x2500880", Offset = "0x24FEE80", VA = "0x182500880")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002A00 File Offset: 0x00000C00
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		public DateParseHandling DateParseHandling
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x25008E0", Offset = "0x24FEEE0", VA = "0x1825008E0")]
			get
			{
				return DateParseHandling.None;
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x2500930", Offset = "0x24FEF30", VA = "0x182500930")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002A18 File Offset: 0x00000C18
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		public FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x2500990", Offset = "0x24FEF90", VA = "0x182500990")]
			get
			{
				return FloatFormatHandling.String;
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x25009D0", Offset = "0x24FEFD0", VA = "0x1825009D0")]
			set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00002A30 File Offset: 0x00000C30
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007C")]
		public FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x2500A30", Offset = "0x24FF030", VA = "0x182500A30")]
			get
			{
				return FloatParseHandling.Double;
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x2500A70", Offset = "0x24FF070", VA = "0x182500A70")]
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00002A48 File Offset: 0x00000C48
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		public StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x2500AD0", Offset = "0x24FF0D0", VA = "0x182500AD0")]
			get
			{
				return StringEscapeHandling.Default;
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x2500B10", Offset = "0x24FF110", VA = "0x182500B10")]
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		[Nullable(1)]
		public CultureInfo Culture
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x2500B70", Offset = "0x24FF170", VA = "0x182500B70")]
			[NullableContext(1)]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[NullableContext(1)]
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00002A60 File Offset: 0x00000C60
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		public bool CheckAdditionalContent
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x2500BD0", Offset = "0x24FF1D0", VA = "0x182500BD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x2500C10", Offset = "0x24FF210", VA = "0x182500C10")]
			set
			{
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2500D70", Offset = "0x24FF370", VA = "0x182500D70")]
		[DebuggerStepThrough]
		public JsonSerializerSettings()
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2500E20", Offset = "0x24FF420", VA = "0x182500E20")]
		[NullableContext(1)]
		public JsonSerializerSettings(JsonSerializerSettings original)
		{
		}

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly StreamingContext DefaultContext;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		internal const Formatting DefaultFormatting = Formatting.None;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		[Nullable(1)]
		internal static readonly CultureInfo DefaultCulture;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		internal const bool DefaultCheckAdditionalContent = false;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[Nullable(1)]
		internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		internal const int DefaultMaxDepth = 64;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x10")]
		internal Formatting? _formatting;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x18")]
		internal DateFormatHandling? _dateFormatHandling;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x20")]
		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x28")]
		internal DateParseHandling? _dateParseHandling;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x30")]
		internal FloatFormatHandling? _floatFormatHandling;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x38")]
		internal FloatParseHandling? _floatParseHandling;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x40")]
		internal StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x48")]
		internal CultureInfo _culture;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x50")]
		internal bool? _checkAdditionalContent;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x54")]
		internal int? _maxDepth;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x5C")]
		internal bool _maxDepthSet;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x60")]
		internal string _dateFormatString;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x68")]
		internal bool _dateFormatStringSet;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x6C")]
		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x74")]
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x7C")]
		internal PreserveReferencesHandling? _preserveReferencesHandling;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x84")]
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x8C")]
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x94")]
		internal MissingMemberHandling? _missingMemberHandling;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x9C")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0xA8")]
		internal StreamingContext? _context;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0xC0")]
		internal ConstructorHandling? _constructorHandling;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0xC8")]
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0xD0")]
		internal MetadataPropertyHandling? _metadataPropertyHandling;
	}
}

using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class JsonSerializerProxy : JsonSerializer
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000913 RID: 2323 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000914 RID: 2324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override event EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x259F710", Offset = "0x259DD10", VA = "0x18259F710", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x259F740", Offset = "0x259DD40", VA = "0x18259F740", Slot = "5")]
			remove
			{
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014E")]
		[Nullable(2)]
		public override IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x259F770", Offset = "0x259DD70", VA = "0x18259F770", Slot = "6")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x259F7A0", Offset = "0x259DDA0", VA = "0x18259F7A0", Slot = "7")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		[Nullable(2)]
		public override ITraceWriter TraceWriter
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x259F7D0", Offset = "0x259DDD0", VA = "0x18259F7D0", Slot = "12")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x259F800", Offset = "0x259DE00", VA = "0x18259F800", Slot = "13")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000150")]
		[Nullable(2)]
		public override IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x259F830", Offset = "0x259DE30", VA = "0x18259F830", Slot = "14")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x259F860", Offset = "0x259DE60", VA = "0x18259F860", Slot = "15")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000151")]
		public override JsonConverterCollection Converters
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x259F890", Offset = "0x259DE90", VA = "0x18259F890", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00004F08 File Offset: 0x00003108
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000152")]
		public override DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x259F8C0", Offset = "0x259DEC0", VA = "0x18259F8C0", Slot = "30")]
			get
			{
				return DefaultValueHandling.Include;
			}
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x259F8F0", Offset = "0x259DEF0", VA = "0x18259F8F0", Slot = "31")]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000153")]
		public override IContractResolver ContractResolver
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x259F920", Offset = "0x259DF20", VA = "0x18259F920", Slot = "39")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x259F950", Offset = "0x259DF50", VA = "0x18259F950", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00004F20 File Offset: 0x00003120
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000154")]
		public override MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x259F980", Offset = "0x259DF80", VA = "0x18259F980", Slot = "26")]
			get
			{
				return MissingMemberHandling.Ignore;
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x259F9B0", Offset = "0x259DFB0", VA = "0x18259F9B0", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00004F38 File Offset: 0x00003138
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000155")]
		public override NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x259F9E0", Offset = "0x259DFE0", VA = "0x18259F9E0", Slot = "28")]
			get
			{
				return NullValueHandling.Include;
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x259FA10", Offset = "0x259E010", VA = "0x18259FA10", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00004F50 File Offset: 0x00003150
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000156")]
		public override ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x259FA40", Offset = "0x259E040", VA = "0x18259FA40", Slot = "32")]
			get
			{
				return ObjectCreationHandling.Auto;
			}
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x259FA70", Offset = "0x259E070", VA = "0x18259FA70", Slot = "33")]
			set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00004F68 File Offset: 0x00003168
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000157")]
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x259FAA0", Offset = "0x259E0A0", VA = "0x18259FAA0", Slot = "24")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x259FAD0", Offset = "0x259E0D0", VA = "0x18259FAD0", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00004F80 File Offset: 0x00003180
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000158")]
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x259FB00", Offset = "0x259E100", VA = "0x18259FB00", Slot = "22")]
			get
			{
				return PreserveReferencesHandling.None;
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x259FB30", Offset = "0x259E130", VA = "0x18259FB30", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00004F98 File Offset: 0x00003198
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000159")]
		public override TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x259FB60", Offset = "0x259E160", VA = "0x18259FB60", Slot = "16")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x259FB90", Offset = "0x259E190", VA = "0x18259FB90", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00004FB0 File Offset: 0x000031B0
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015A")]
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x259FBC0", Offset = "0x259E1C0", VA = "0x18259FBC0", Slot = "36")]
			get
			{
				return MetadataPropertyHandling.Default;
			}
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x259FBF0", Offset = "0x259E1F0", VA = "0x18259FBF0", Slot = "37")]
			set
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00004FC8 File Offset: 0x000031C8
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015B")]
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x259FC20", Offset = "0x259E220", VA = "0x18259FC20", Slot = "18")]
			get
			{
				return FormatterAssemblyStyle.Simple;
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x259FC50", Offset = "0x259E250", VA = "0x18259FC50", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00004FE0 File Offset: 0x000031E0
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015C")]
		public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x259FC80", Offset = "0x259E280", VA = "0x18259FC80", Slot = "20")]
			get
			{
				return TypeNameAssemblyFormatHandling.Simple;
			}
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x259FCB0", Offset = "0x259E2B0", VA = "0x18259FCB0", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015D")]
		public override ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x259FCE0", Offset = "0x259E2E0", VA = "0x18259FCE0", Slot = "34")]
			get
			{
				return ConstructorHandling.Default;
			}
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x259FD10", Offset = "0x259E310", VA = "0x18259FD10", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015E")]
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public override SerializationBinder Binder
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x259FD40", Offset = "0x259E340", VA = "0x18259FD40", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x259FD70", Offset = "0x259E370", VA = "0x18259FD70", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015F")]
		public override ISerializationBinder SerializationBinder
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x259FDA0", Offset = "0x259E3A0", VA = "0x18259FDA0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x259FDD0", Offset = "0x259E3D0", VA = "0x18259FDD0", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00005010 File Offset: 0x00003210
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000160")]
		public override StreamingContext Context
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x259FE00", Offset = "0x259E400", VA = "0x18259FE00", Slot = "41")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x259FE50", Offset = "0x259E450", VA = "0x18259FE50", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00005028 File Offset: 0x00003228
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000161")]
		public override Formatting Formatting
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x259FE90", Offset = "0x259E490", VA = "0x18259FE90", Slot = "43")]
			get
			{
				return Formatting.None;
			}
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x259FEC0", Offset = "0x259E4C0", VA = "0x18259FEC0", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00005040 File Offset: 0x00003240
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000162")]
		public override DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x259FEF0", Offset = "0x259E4F0", VA = "0x18259FEF0", Slot = "45")]
			get
			{
				return DateFormatHandling.IsoDateFormat;
			}
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x259FF20", Offset = "0x259E520", VA = "0x18259FF20", Slot = "46")]
			set
			{
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00005058 File Offset: 0x00003258
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000163")]
		public override DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x259FF50", Offset = "0x259E550", VA = "0x18259FF50", Slot = "47")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x259FF80", Offset = "0x259E580", VA = "0x18259FF80", Slot = "48")]
			set
			{
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00005070 File Offset: 0x00003270
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000164")]
		public override DateParseHandling DateParseHandling
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x259FFB0", Offset = "0x259E5B0", VA = "0x18259FFB0", Slot = "49")]
			get
			{
				return DateParseHandling.None;
			}
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x259FFE0", Offset = "0x259E5E0", VA = "0x18259FFE0", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00005088 File Offset: 0x00003288
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000165")]
		public override FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x25A0010", Offset = "0x259E610", VA = "0x1825A0010", Slot = "53")]
			get
			{
				return FloatFormatHandling.String;
			}
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x25A0040", Offset = "0x259E640", VA = "0x1825A0040", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x000050A0 File Offset: 0x000032A0
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000166")]
		public override FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x25A0070", Offset = "0x259E670", VA = "0x1825A0070", Slot = "51")]
			get
			{
				return FloatParseHandling.Double;
			}
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x25A00A0", Offset = "0x259E6A0", VA = "0x1825A00A0", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x000050B8 File Offset: 0x000032B8
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000167")]
		public override StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x25A00D0", Offset = "0x259E6D0", VA = "0x1825A00D0", Slot = "55")]
			get
			{
				return StringEscapeHandling.Default;
			}
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x25A0100", Offset = "0x259E700", VA = "0x1825A0100", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000168")]
		public override string DateFormatString
		{
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x25A0130", Offset = "0x259E730", VA = "0x1825A0130", Slot = "57")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x25A0160", Offset = "0x259E760", VA = "0x1825A0160", Slot = "58")]
			set
			{
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000169")]
		public override CultureInfo Culture
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x25A0190", Offset = "0x259E790", VA = "0x1825A0190", Slot = "59")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x25A01C0", Offset = "0x259E7C0", VA = "0x1825A01C0", Slot = "60")]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x000050D0 File Offset: 0x000032D0
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016A")]
		public override int? MaxDepth
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x25A01F0", Offset = "0x259E7F0", VA = "0x1825A01F0", Slot = "61")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x25A0220", Offset = "0x259E820", VA = "0x1825A0220", Slot = "62")]
			set
			{
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x000050E8 File Offset: 0x000032E8
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016B")]
		public override bool CheckAdditionalContent
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x25A0250", Offset = "0x259E850", VA = "0x1825A0250", Slot = "63")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x25A0280", Offset = "0x259E880", VA = "0x1825A0280", Slot = "64")]
			set
			{
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x25A02B0", Offset = "0x259E8B0", VA = "0x1825A02B0")]
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x25A02D0", Offset = "0x259E8D0", VA = "0x1825A02D0")]
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x25A0420", Offset = "0x259EA20", VA = "0x1825A0420")]
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x25A0570", Offset = "0x259EB70", VA = "0x1825A0570", Slot = "66")]
		[NullableContext(2)]
		internal override object DeserializeInternal([Nullable(1)] JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x25A05D0", Offset = "0x259EBD0", VA = "0x1825A05D0", Slot = "65")]
		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x25A0620", Offset = "0x259EC20", VA = "0x1825A0620", Slot = "67")]
		[NullableContext(2)]
		internal override void SerializeInternal([Nullable(1)] JsonWriter jsonWriter, object value, Type rootType)
		{
		}

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0xE0")]
		[Nullable(2)]
		private readonly JsonSerializerInternalReader _serializerReader;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0xE8")]
		[Nullable(2)]
		private readonly JsonSerializerInternalWriter _serializerWriter;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0xF0")]
		internal readonly JsonSerializer _serializer;
	}
}

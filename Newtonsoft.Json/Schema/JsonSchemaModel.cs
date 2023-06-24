using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaModel
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00005688 File Offset: 0x00003888
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A9")]
		public bool Required
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000056A0 File Offset: 0x000038A0
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AA")]
		public JsonSchemaType Type
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			[CompilerGenerated]
			get
			{
				return JsonSchemaType.None;
			}
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x000056B8 File Offset: 0x000038B8
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AB")]
		public int? MinimumLength
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x16755D0", Offset = "0x1673BD0", VA = "0x1816755D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000056D0 File Offset: 0x000038D0
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AC")]
		public int? MaximumLength
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0xA7FE00", Offset = "0xA7E400", VA = "0x180A7FE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x000056E8 File Offset: 0x000038E8
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AD")]
		public double? DivisibleBy
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0xFAFF70", Offset = "0xFAE570", VA = "0x180FAFF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x22CD900", Offset = "0x22CBF00", VA = "0x1822CD900")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00005700 File Offset: 0x00003900
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AE")]
		public double? Minimum
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x25AEE50", Offset = "0x25AD450", VA = "0x1825AEE50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x25AEE60", Offset = "0x25AD460", VA = "0x1825AEE60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00005718 File Offset: 0x00003918
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AF")]
		public double? Maximum
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x25AEE70", Offset = "0x25AD470", VA = "0x1825AEE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x25AEE80", Offset = "0x25AD480", VA = "0x1825AEE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00005730 File Offset: 0x00003930
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B0")]
		public bool ExclusiveMinimum
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00005748 File Offset: 0x00003948
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B1")]
		public bool ExclusiveMaximum
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x998F20", Offset = "0x997520", VA = "0x180998F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x998F30", Offset = "0x997530", VA = "0x180998F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00005760 File Offset: 0x00003960
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B2")]
		public int? MinimumItems
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x20C00D0", Offset = "0x20BE6D0", VA = "0x1820C00D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x20C00E0", Offset = "0x20BE6E0", VA = "0x1820C00E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00005778 File Offset: 0x00003978
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B3")]
		public int? MaximumItems
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0xAE11D0", Offset = "0xADF7D0", VA = "0x180AE11D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x25AEE90", Offset = "0x25AD490", VA = "0x1825AEE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B4")]
		public IList<string> Patterns
		{
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B5")]
		public IList<JsonSchemaModel> Items
		{
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B6")]
		public IDictionary<string, JsonSchemaModel> Properties
		{
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B7")]
		public IDictionary<string, JsonSchemaModel> PatternProperties
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B8")]
		public JsonSchemaModel AdditionalProperties
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x8DD110", Offset = "0x8DB710", VA = "0x1808DD110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B9")]
		public JsonSchemaModel AdditionalItems
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x1D4F140", Offset = "0x1D4D740", VA = "0x181D4F140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00005790 File Offset: 0x00003990
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BA")]
		public bool PositionalItemsValidation
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x6124F0", Offset = "0x610AF0", VA = "0x1806124F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x000057A8 File Offset: 0x000039A8
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BB")]
		public bool AllowAdditionalProperties
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x25AEEA0", Offset = "0x25AD4A0", VA = "0x1825AEEA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x25AEEB0", Offset = "0x25AD4B0", VA = "0x1825AEEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000057C0 File Offset: 0x000039C0
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BC")]
		public bool AllowAdditionalItems
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x25AEEC0", Offset = "0x25AD4C0", VA = "0x1825AEEC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x25AEED0", Offset = "0x25AD4D0", VA = "0x1825AEED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000057D8 File Offset: 0x000039D8
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BD")]
		public bool UniqueItems
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x25AEEE0", Offset = "0x25AD4E0", VA = "0x1825AEEE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x25AEEF0", Offset = "0x25AD4F0", VA = "0x1825AEEF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BE")]
		public IList<JToken> Enum
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x13428C0", Offset = "0x1340EC0", VA = "0x1813428C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000057F0 File Offset: 0x000039F0
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BF")]
		public JsonSchemaType Disallow
		{
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x7283D0", Offset = "0x7269D0", VA = "0x1807283D0")]
			[CompilerGenerated]
			get
			{
				return JsonSchemaType.None;
			}
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x7283E0", Offset = "0x7269E0", VA = "0x1807283E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x25AEF00", Offset = "0x25AD500", VA = "0x1825AEF00")]
		public JsonSchemaModel()
		{
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x25AEF20", Offset = "0x25AD520", VA = "0x1825AEF20")]
		public static JsonSchemaModel Create(IList<JsonSchema> schemata)
		{
			return null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x25AF110", Offset = "0x25AD710", VA = "0x1825AF110")]
		private static void Combine(JsonSchemaModel model, JsonSchema schema)
		{
		}
	}
}

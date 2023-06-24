using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		// Token: 0x060008A3 RID: 2211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x2586AE0", Offset = "0x25850E0", VA = "0x182586AE0")]
		public JsonPropertyCollection(Type type)
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x2586D40", Offset = "0x2585340", VA = "0x182586D40", Slot = "39")]
		protected override string GetKeyForItem(JsonProperty item)
		{
			return null;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2586D60", Offset = "0x2585360", VA = "0x182586D60")]
		public void AddProperty(JsonProperty property)
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x2587040", Offset = "0x2585640", VA = "0x182587040")]
		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			return null;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x2587080", Offset = "0x2585680", VA = "0x182587080")]
		private bool TryGetProperty(string key, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] [Nullable(2)] out JsonProperty item)
		{
			return default(bool);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x25871C0", Offset = "0x25857C0", VA = "0x1825871C0")]
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			return null;
		}

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x30")]
		private readonly Type _type;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<JsonProperty> _list;
	}
}

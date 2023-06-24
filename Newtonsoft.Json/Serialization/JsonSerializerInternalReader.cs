using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x2587E50", Offset = "0x2586450", VA = "0x182587E50")]
		public JsonSerializerInternalReader(JsonSerializer serializer)
		{
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x2587E60", Offset = "0x2586460", VA = "0x182587E60")]
		public void Populate(JsonReader reader, object target)
		{
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x25884F0", Offset = "0x2586AF0", VA = "0x1825884F0")]
		[NullableContext(2)]
		private JsonContract GetContractSafe(Type type)
		{
			return null;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x2588590", Offset = "0x2586B90", VA = "0x182588590")]
		private JsonContract GetContract(Type type)
		{
			return null;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x25885F0", Offset = "0x2586BF0", VA = "0x1825885F0")]
		[NullableContext(2)]
		public object Deserialize([Nullable(1)] JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			return null;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x2588950", Offset = "0x2586F50", VA = "0x182588950")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x2588AE0", Offset = "0x25870E0", VA = "0x182588AE0")]
		[NullableContext(2)]
		private JToken CreateJToken([Nullable(1)] JsonReader reader, JsonContract contract)
		{
			return null;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x2588EE0", Offset = "0x25874E0", VA = "0x182588EE0")]
		private JToken CreateJObject(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x2589400", Offset = "0x2587A00", VA = "0x182589400")]
		[NullableContext(2)]
		private object CreateValueInternal([Nullable(1)] JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x25899B0", Offset = "0x2587FB0", VA = "0x1825899B0")]
		[NullableContext(2)]
		private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, [Nullable(1)] string s)
		{
			return default(bool);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x2589AB0", Offset = "0x25880B0", VA = "0x182589AB0")]
		internal string GetExpectedDescription(JsonContract contract)
		{
			return null;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x2589BB0", Offset = "0x25881B0", VA = "0x182589BB0")]
		[NullableContext(2)]
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return null;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x2589C50", Offset = "0x2588250", VA = "0x182589C50")]
		[NullableContext(2)]
		private object CreateObject([Nullable(1)] JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x258ABE0", Offset = "0x25891E0", VA = "0x18258ABE0")]
		[NullableContext(2)]
		private bool ReadMetadataPropertiesToken([Nullable(1)] JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			return default(bool);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x258B670", Offset = "0x2589C70", VA = "0x18258B670")]
		[NullableContext(2)]
		private bool ReadMetadataProperties([Nullable(1)] JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			return default(bool);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x258C0D0", Offset = "0x258A6D0", VA = "0x18258C0D0")]
		[NullableContext(2)]
		private void ResolveTypeName([Nullable(1)] JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, [Nullable(1)] string qualifiedTypeName)
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x258C6C0", Offset = "0x258ACC0", VA = "0x18258C6C0")]
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			return null;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x258C880", Offset = "0x258AE80", VA = "0x18258C880")]
		[NullableContext(2)]
		private object CreateList([Nullable(1)] JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id)
		{
			return null;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x258D120", Offset = "0x258B720", VA = "0x18258D120")]
		[NullableContext(2)]
		private bool HasNoDefinedType(JsonContract contract)
		{
			return default(bool);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x258D1F0", Offset = "0x258B7F0", VA = "0x18258D1F0")]
		[NullableContext(2)]
		private object EnsureType([Nullable(1)] JsonReader reader, object value, [Nullable(1)] CultureInfo culture, JsonContract contract, Type targetType)
		{
			return null;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x258DAF0", Offset = "0x258C0F0", VA = "0x18258DAF0")]
		private bool SetPropertyValue(JsonProperty property, [Nullable(2)] JsonConverter propertyConverter, [Nullable(2)] JsonContainerContract containerContract, [Nullable(2)] JsonProperty containerProperty, JsonReader reader, object target)
		{
			return default(bool);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x258DEC0", Offset = "0x258C4C0", VA = "0x18258DEC0")]
		[NullableContext(2)]
		private bool CalculatePropertyDetails([Nullable(1)] JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, [Nullable(1)] JsonReader reader, [Nullable(1)] object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue)
		{
			return default(bool);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x258E4F0", Offset = "0x258CAF0", VA = "0x18258E4F0")]
		private void AddReference(JsonReader reader, string id, object value)
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x21D8E50", Offset = "0x21D7450", VA = "0x1821D8E50")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x258E760", Offset = "0x258CD60", VA = "0x18258E760")]
		[NullableContext(2)]
		private bool ShouldSetPropertyValue([Nullable(1)] JsonProperty property, JsonObjectContract contract, object value)
		{
			return default(bool);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x258E8A0", Offset = "0x258CEA0", VA = "0x18258E8A0")]
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x258EC00", Offset = "0x258D200", VA = "0x18258EC00")]
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x258EEA0", Offset = "0x258D4A0", VA = "0x18258EEA0")]
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x258F050", Offset = "0x258D650", VA = "0x18258F050")]
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value)
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x258F200", Offset = "0x258D800", VA = "0x18258F200")]
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id)
		{
			return null;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x258FD50", Offset = "0x258E350", VA = "0x18258FD50")]
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id)
		{
			return null;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x25906A0", Offset = "0x258ECA0", VA = "0x1825906A0")]
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, [Nullable(2)] object currentObject, string message)
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x25907B0", Offset = "0x258EDB0", VA = "0x1825907B0")]
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id)
		{
			return null;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x2590D90", Offset = "0x258F390", VA = "0x182590D90")]
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] string id)
		{
			return null;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x25916F0", Offset = "0x258FCF0", VA = "0x1825916F0")]
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, [Nullable(2)] JsonProperty member)
		{
			return null;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x2591970", Offset = "0x258FF70", VA = "0x182591970")]
		private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] string id)
		{
			return null;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x25923F0", Offset = "0x25909F0", VA = "0x1825923F0")]
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, [Nullable(2)] JsonProperty containerProperty, ObjectConstructor<object> creator, [Nullable(2)] string id)
		{
			return null;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x2593D00", Offset = "0x2592300", VA = "0x182593D00")]
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, [Nullable(2)] object existingValue)
		{
			return null;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x2594130", Offset = "0x2592730", VA = "0x182594130")]
		private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, [Nullable(2)] JsonProperty containerProperty, JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x2594CD0", Offset = "0x25932D0", VA = "0x182594CD0")]
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, [Nullable(2)] JsonProperty containerMember, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x2594F90", Offset = "0x2593590", VA = "0x182594F90")]
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] string id)
		{
			return null;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x2595D70", Offset = "0x2594370", VA = "0x182595D70")]
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target)
		{
			return default(bool);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x2595F30", Offset = "0x2594530", VA = "0x182595F30")]
		private bool CheckPropertyName(JsonReader reader, string memberName)
		{
			return default(bool);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x25960E0", Offset = "0x25946E0", VA = "0x1825960E0")]
		private void SetExtensionData(JsonObjectContract contract, [Nullable(2)] JsonProperty member, JsonReader reader, string memberName, object o)
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x2596210", Offset = "0x2594810", VA = "0x182596210")]
		private object ReadExtensionDataValue(JsonObjectContract contract, [Nullable(2)] JsonProperty member, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x2596300", Offset = "0x2594900", VA = "0x182596300")]
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue)
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x2596790", Offset = "0x2594D90", VA = "0x182596790")]
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, [Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties)
		{
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x25968D0", Offset = "0x2594ED0", VA = "0x1825968D0")]
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
		}

		// Token: 0x02000128 RID: 296
		[Token(Token = "0x2000128")]
		[NullableContext(0)]
		internal enum PropertyPresence
		{
			// Token: 0x04000590 RID: 1424
			[Token(Token = "0x4000590")]
			None,
			// Token: 0x04000591 RID: 1425
			[Token(Token = "0x4000591")]
			Null,
			// Token: 0x04000592 RID: 1426
			[Token(Token = "0x4000592")]
			Value
		}

		// Token: 0x02000129 RID: 297
		[Token(Token = "0x2000129")]
		[NullableContext(2)]
		[Nullable(0)]
		internal class CreatorPropertyContext
		{
			// Token: 0x060008E2 RID: 2274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[NullableContext(1)]
			public CreatorPropertyContext(string name)
			{
			}

			// Token: 0x04000593 RID: 1427
			[Token(Token = "0x4000593")]
			[FieldOffset(Offset = "0x10")]
			[Nullable(1)]
			public readonly string Name;

			// Token: 0x04000594 RID: 1428
			[Token(Token = "0x4000594")]
			[FieldOffset(Offset = "0x18")]
			public JsonProperty Property;

			// Token: 0x04000595 RID: 1429
			[Token(Token = "0x4000595")]
			[FieldOffset(Offset = "0x20")]
			public JsonProperty ConstructorProperty;

			// Token: 0x04000596 RID: 1430
			[Token(Token = "0x4000596")]
			[FieldOffset(Offset = "0x28")]
			public JsonSerializerInternalReader.PropertyPresence? Presence;

			// Token: 0x04000597 RID: 1431
			[Token(Token = "0x4000597")]
			[FieldOffset(Offset = "0x30")]
			public object Value;

			// Token: 0x04000598 RID: 1432
			[Token(Token = "0x4000598")]
			[FieldOffset(Offset = "0x38")]
			public bool Used;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x2596A60", Offset = "0x2595060", VA = "0x182596A60")]
		public JsonSerializerInternalWriter(JsonSerializer serializer)
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x2596B20", Offset = "0x2595120", VA = "0x182596B20")]
		[NullableContext(2)]
		public void Serialize([Nullable(1)] JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x2596F70", Offset = "0x2595570", VA = "0x182596F70")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x2597100", Offset = "0x2595700", VA = "0x182597100")]
		[NullableContext(2)]
		private JsonContract GetContractSafe(object value)
		{
			return null;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x2597180", Offset = "0x2595780", VA = "0x182597180")]
		private JsonContract GetContract(object value)
		{
			return null;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x25971F0", Offset = "0x25957F0", VA = "0x1825971F0")]
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract containerContract, [Nullable(2)] JsonProperty containerProperty)
		{
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x25974C0", Offset = "0x2595AC0", VA = "0x1825974C0")]
		[NullableContext(2)]
		private void SerializeValue([Nullable(1)] JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x2597C60", Offset = "0x2596260", VA = "0x182597C60")]
		[NullableContext(2)]
		private bool? ResolveIsReference([Nullable(1)] JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return null;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x2597CF0", Offset = "0x25962F0", VA = "0x182597CF0")]
		[NullableContext(2)]
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x2597E60", Offset = "0x2596460", VA = "0x182597E60")]
		[NullableContext(2)]
		private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, [Nullable(1)] JsonProperty property)
		{
			return default(bool);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x2597F70", Offset = "0x2596570", VA = "0x182597F70")]
		[NullableContext(2)]
		private bool CheckForCircularReference([Nullable(1)] JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x2598420", Offset = "0x2596A20", VA = "0x182598420")]
		private void WriteReference(JsonWriter writer, object value)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x2598610", Offset = "0x2596C10", VA = "0x182598610")]
		private string GetReference(JsonWriter writer, object value)
		{
			return null;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x2598760", Offset = "0x2596D60", VA = "0x182598760")]
		internal static bool TryConvertToString(object value, Type type, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string s)
		{
			return default(bool);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x2598C50", Offset = "0x2597250", VA = "0x182598C50")]
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x2598D00", Offset = "0x2597300", VA = "0x182598D00")]
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value)
		{
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x2598E80", Offset = "0x2597480", VA = "0x182598E80")]
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value)
		{
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x2599000", Offset = "0x2597600", VA = "0x182599000")]
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x2599BD0", Offset = "0x25981D0", VA = "0x182599BD0")]
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, [Nullable(2)] JsonProperty member, JsonProperty property, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out JsonContract memberContract, [Nullable(2)] out object memberValue)
		{
			return default(bool);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x259A480", Offset = "0x2598A80", VA = "0x18259A480")]
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x259A830", Offset = "0x2598E30", VA = "0x18259A830")]
		private bool HasCreatorParameter([Nullable(2)] JsonContainerContract contract, JsonProperty property)
		{
			return default(bool);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x259A8E0", Offset = "0x2598EE0", VA = "0x18259A8E0")]
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value)
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x259AA90", Offset = "0x2599090", VA = "0x18259AA90")]
		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x21D8E50", Offset = "0x21D7450", VA = "0x1821D8E50")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x21D8E50", Offset = "0x21D7450", VA = "0x1821D8E50")]
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return default(bool);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x21D8E50", Offset = "0x21D7450", VA = "0x1821D8E50")]
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return default(bool);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x259AD10", Offset = "0x2599310", VA = "0x18259AD10")]
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x259B2F0", Offset = "0x25998F0", VA = "0x18259B2F0")]
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x259B840", Offset = "0x2599E40", VA = "0x18259B840")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x259BA40", Offset = "0x259A040", VA = "0x18259BA40")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, [Nullable(2)] JsonProperty member, int initialDepth, int[] indices)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x259BE70", Offset = "0x259A470", VA = "0x18259BE70")]
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract containerContract, [Nullable(2)] JsonProperty containerProperty)
		{
			return default(bool);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x259C310", Offset = "0x259A910", VA = "0x18259C310")]
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x259CCA0", Offset = "0x259B2A0", VA = "0x18259CCA0")]
		private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x259E020", Offset = "0x259C620", VA = "0x18259E020")]
		[NullableContext(2)]
		private bool ShouldWriteDynamicProperty(object memberValue)
		{
			return default(bool);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x259E0D0", Offset = "0x259C6D0", VA = "0x18259E0D0")]
		[NullableContext(2)]
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, [Nullable(1)] JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x259E2C0", Offset = "0x259C8C0", VA = "0x18259E2C0")]
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x259ED10", Offset = "0x259D310", VA = "0x18259ED10")]
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape)
		{
			return null;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x259F250", Offset = "0x259D850", VA = "0x18259F250")]
		private void HandleError(JsonWriter writer, int initialDepth)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x259F3B0", Offset = "0x259D9B0", VA = "0x18259F3B0")]
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			return default(bool);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x259F560", Offset = "0x259DB60", VA = "0x18259F560")]
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target)
		{
			return default(bool);
		}

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x38")]
		[Nullable(2)]
		private Type _rootType;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x40")]
		private int _rootLevel;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<object> _serializeStack;
	}
}

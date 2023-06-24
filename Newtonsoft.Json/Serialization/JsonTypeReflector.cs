using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	[Nullable(0)]
	[NullableContext(1)]
	internal static class JsonTypeReflector
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000957")]
		public static T GetCachedAttribute<T>(object attributeProvider) where T : Attribute
		{
			return null;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x25A06F0", Offset = "0x259ECF0", VA = "0x1825A06F0")]
		public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter)
		{
			return default(bool);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x25A0A20", Offset = "0x259F020", VA = "0x1825A0A20")]
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			return null;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x25A0AD0", Offset = "0x259F0D0", VA = "0x1825A0AD0")]
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x25A1270", Offset = "0x259F870", VA = "0x1825A1270")]
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			return MemberSerialization.OptOut;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x25A1360", Offset = "0x259F960", VA = "0x1825A1360")]
		public static JsonConverter GetJsonConverter(object attributeProvider)
		{
			return null;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x25A14A0", Offset = "0x259FAA0", VA = "0x1825A14A0")]
		public static JsonConverter CreateJsonConverterInstance(Type converterType, [Nullable(new byte[]
		{
			2,
			1
		})] object[] args)
		{
			return null;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x25A15C0", Offset = "0x259FBC0", VA = "0x1825A15C0")]
		public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, [Nullable(new byte[]
		{
			2,
			1
		})] object[] args)
		{
			return null;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x25A16E0", Offset = "0x259FCE0", VA = "0x1825A16E0")]
		public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute)
		{
			return null;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x25A17B0", Offset = "0x259FDB0", VA = "0x1825A17B0")]
		private static Func<object[], object> GetCreator(Type type)
		{
			return null;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x25A19A0", Offset = "0x259FFA0", VA = "0x1825A19A0")]
		private static Type GetAssociatedMetadataType(Type type)
		{
			return null;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x25A1A40", Offset = "0x25A0040", VA = "0x1825A1A40")]
		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			return null;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000963")]
		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			return null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000964")]
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			return null;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x25A1D10", Offset = "0x25A0310", VA = "0x1825A1D10")]
		public static bool IsNonSerializable(object provider)
		{
			return default(bool);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x25A1D80", Offset = "0x25A0380", VA = "0x1825A1D80")]
		public static bool IsSerializable(object provider)
		{
			return default(bool);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000967")]
		public static T GetAttribute<T>(object provider) where T : Attribute
		{
			return null;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x1700016C")]
		public static bool DynamicCodeGeneration
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x25A1DF0", Offset = "0x25A03F0", VA = "0x1825A1DF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x1700016D")]
		public static bool FullyTrusted
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x25A1ED0", Offset = "0x25A04D0", VA = "0x1825A1ED0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700016E")]
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x25A1FD0", Offset = "0x25A05D0", VA = "0x1825A1FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x0")]
		private static bool? _dynamicCodeGeneration;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x2")]
		private static bool? _fullyTrusted;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		public const string IdPropertyName = "$id";

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		public const string RefPropertyName = "$ref";

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		public const string TypePropertyName = "$type";

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		public const string ValuePropertyName = "$value";

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		public const string ArrayValuesPropertyName = "$values";

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		public const string ShouldSerializePrefix = "ShouldSerialize";

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		public const string SpecifiedPostfix = "Specified";

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		public const string ConcurrentDictionaryTypeName = "System.Collections.Concurrent.ConcurrentDictionary`2";

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x8")]
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1,
			1
		})]
		private static readonly ThreadSafeStore<Type, Func<object[], object>> CreatorCache;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x10")]
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x18")]
		[Nullable(2)]
		private static ReflectionObject _metadataTypeAttributeReflectionObject;
	}
}

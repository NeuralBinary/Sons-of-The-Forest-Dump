using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	[Nullable(0)]
	[NullableContext(1)]
	public class DefaultContractResolver : IContractResolver
	{
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E4")]
		internal static IContractResolver Instance
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x2572850", Offset = "0x2570E50", VA = "0x182572850")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x170000E5")]
		public bool DynamicCodeGeneration
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x25728A0", Offset = "0x2570EA0", VA = "0x1825728A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00004470 File Offset: 0x00002670
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E6")]
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			[CompilerGenerated]
			get
			{
				return BindingFlags.Default;
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00004488 File Offset: 0x00002688
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E7")]
		public bool SerializeCompilerGeneratedMembers
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x21FA640", Offset = "0x21F8C40", VA = "0x1821FA640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x25729B0", Offset = "0x2570FB0", VA = "0x1825729B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x000044A0 File Offset: 0x000026A0
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E8")]
		public bool IgnoreSerializableInterface
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x25729C0", Offset = "0x2570FC0", VA = "0x1825729C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x25729D0", Offset = "0x2570FD0", VA = "0x1825729D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x000044B8 File Offset: 0x000026B8
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E9")]
		public bool IgnoreSerializableAttribute
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x25729E0", Offset = "0x2570FE0", VA = "0x1825729E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x25729F0", Offset = "0x2570FF0", VA = "0x1825729F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x000044D0 File Offset: 0x000026D0
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EA")]
		public bool IgnoreIsSpecifiedMembers
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x2572A00", Offset = "0x2571000", VA = "0x182572A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x2572A10", Offset = "0x2571010", VA = "0x182572A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x000044E8 File Offset: 0x000026E8
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EB")]
		public bool IgnoreShouldSerializeMembers
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EC")]
		[Nullable(2)]
		public NamingStrategy NamingStrategy
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[NullableContext(2)]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2572A20", Offset = "0x2571020", VA = "0x182572A20")]
		public DefaultContractResolver()
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2572BB0", Offset = "0x25711B0", VA = "0x182572BB0", Slot = "5")]
		public virtual JsonContract ResolveContract(Type type)
		{
			return null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2572C80", Offset = "0x2571280", VA = "0x182572C80")]
		private static bool FilterMembers(MemberInfo member)
		{
			return default(bool);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2572DE0", Offset = "0x25713E0", VA = "0x182572DE0", Slot = "6")]
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			return null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x2573AB0", Offset = "0x25720B0", VA = "0x182573AB0")]
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			return default(bool);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x2573C00", Offset = "0x2572200", VA = "0x182573C00", Slot = "7")]
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x25744B0", Offset = "0x2572AB0", VA = "0x1825744B0")]
		private static void ThrowUnableToSerializeError(object o, StreamingContext context)
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x2574550", Offset = "0x2572B50", VA = "0x182574550")]
		private MemberInfo GetExtensionDataMemberForType(Type type)
		{
			return null;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x2574800", Offset = "0x2572E00", VA = "0x182574800")]
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x2575520", Offset = "0x2573B20", VA = "0x182575520")]
		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			return null;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x2575990", Offset = "0x2573F90", VA = "0x182575990")]
		private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x2575BD0", Offset = "0x25741D0", VA = "0x182575BD0")]
		private ConstructorInfo GetParameterizedConstructor(Type objectType)
		{
			return null;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x2575C20", Offset = "0x2574220", VA = "0x182575C20", Slot = "8")]
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x2575DF0", Offset = "0x25743F0", VA = "0x182575DF0")]
		private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type)
		{
			return null;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x2575EB0", Offset = "0x25744B0", VA = "0x182575EB0", Slot = "9")]
		protected virtual JsonProperty CreatePropertyFromConstructorParameter([Nullable(2)] JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			return null;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x25762A0", Offset = "0x25748A0", VA = "0x1825762A0", Slot = "10")]
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return null;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x25762F0", Offset = "0x25748F0", VA = "0x1825762F0")]
		private Func<object> GetDefaultCreator(Type createdType)
		{
			return null;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x2576360", Offset = "0x2574960", VA = "0x182576360")]
		private void InitializeContract(JsonContract contract)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x25766D0", Offset = "0x2574CD0", VA = "0x1825766D0")]
		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2576A70", Offset = "0x2575070", VA = "0x182576A70")]
		private void GetCallbackMethodsForType(Type type, [Nullable(new byte[]
		{
			2,
			1
		})] out List<SerializationCallback> onSerializing, [Nullable(new byte[]
		{
			2,
			1
		})] out List<SerializationCallback> onSerialized, [Nullable(new byte[]
		{
			2,
			1
		})] out List<SerializationCallback> onDeserializing, [Nullable(new byte[]
		{
			2,
			1
		})] out List<SerializationCallback> onDeserialized, [Nullable(new byte[]
		{
			2,
			1
		})] out List<SerializationErrorCallback> onError)
		{
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x25775D0", Offset = "0x2575BD0", VA = "0x1825775D0")]
		private static bool IsConcurrentOrObservableCollection(Type t)
		{
			return default(bool);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x25777D0", Offset = "0x2575DD0", VA = "0x1825777D0")]
		private static bool ShouldSkipDeserialized(Type t)
		{
			return default(bool);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2577900", Offset = "0x2575F00", VA = "0x182577900")]
		private static bool ShouldSkipSerializing(Type t)
		{
			return default(bool);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2577A30", Offset = "0x2576030", VA = "0x182577A30")]
		private List<Type> GetClassHierarchyForType(Type type)
		{
			return null;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2577C30", Offset = "0x2576230", VA = "0x182577C30", Slot = "11")]
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2578350", Offset = "0x2576950", VA = "0x182578350", Slot = "12")]
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2578730", Offset = "0x2576D30", VA = "0x182578730", Slot = "13")]
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x25787A0", Offset = "0x2576DA0", VA = "0x1825787A0", Slot = "14")]
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2578820", Offset = "0x2576E20", VA = "0x182578820", Slot = "15")]
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			return null;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2578AD0", Offset = "0x25770D0", VA = "0x182578AD0", Slot = "16")]
		protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)
		{
			return null;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2578E00", Offset = "0x2577400", VA = "0x182578E00", Slot = "17")]
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			return null;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2578EB0", Offset = "0x25774B0", VA = "0x182578EB0", Slot = "18")]
		protected virtual JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2579430", Offset = "0x2577A30", VA = "0x182579430")]
		internal static bool IsJsonPrimitiveType(Type t)
		{
			return default(bool);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x25794D0", Offset = "0x2577AD0", VA = "0x1825794D0")]
		internal static bool IsIConvertible(Type t)
		{
			return default(bool);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x25796E0", Offset = "0x2577CE0", VA = "0x1825796E0")]
		internal static bool CanConvertToString(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2579AD0", Offset = "0x25780D0", VA = "0x182579AD0")]
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, [Nullable(2)] MethodInfo currentCallback, [Nullable(2)] ref Type prevAttributeType)
		{
			return default(bool);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x257A2A0", Offset = "0x25788A0", VA = "0x18257A2A0")]
		internal static string GetClrTypeFullName(Type type)
		{
			return null;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x257A3C0", Offset = "0x25789C0", VA = "0x18257A3C0", Slot = "19")]
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "20")]
		internal virtual DefaultJsonNameTable GetNameTable()
		{
			return null;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x257A990", Offset = "0x2578F90", VA = "0x18257A990", Slot = "21")]
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			return null;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x257AAA0", Offset = "0x25790A0", VA = "0x18257AAA0", Slot = "22")]
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x257AE60", Offset = "0x2579460", VA = "0x18257AE60")]
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x257B5C0", Offset = "0x2579BC0", VA = "0x18257B5C0")]
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			return null;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x257B840", Offset = "0x2579E40", VA = "0x18257B840")]
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x257BC10", Offset = "0x257A210", VA = "0x18257BC10", Slot = "23")]
		protected virtual string ResolvePropertyName(string propertyName)
		{
			return null;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x257BC40", Offset = "0x257A240", VA = "0x18257BC40", Slot = "24")]
		protected virtual string ResolveExtensionDataName(string extensionDataName)
		{
			return null;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x257BC70", Offset = "0x257A270", VA = "0x18257BC70", Slot = "25")]
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			return null;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x257BCB0", Offset = "0x257A2B0", VA = "0x18257BCB0")]
		public string GetResolvedPropertyName(string propertyName)
		{
			return null;
		}

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IContractResolver _instance;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] BlacklistedTypeNames;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x10")]
		private static readonly JsonConverter[] BuiltInConverters;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x10")]
		private readonly DefaultJsonNameTable _nameTable;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x18")]
		private readonly ThreadSafeStore<Type, JsonContract> _contractCache;

		// Token: 0x020000FB RID: 251
		[Token(Token = "0x20000FB")]
		[NullableContext(0)]
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			// Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600077E")]
			public EnumerableDictionaryWrapper([Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})] IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			// Token: 0x0600077F RID: 1919 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600077F")]
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000780 RID: 1920 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000780")]
			[NullableContext(1)]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x040004EA RID: 1258
			[Token(Token = "0x40004EA")]
			[FieldOffset(Offset = "0x0")]
			[Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
		}
	}
}

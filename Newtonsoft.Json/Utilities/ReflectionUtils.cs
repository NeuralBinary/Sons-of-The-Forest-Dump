using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	[NullableContext(1)]
	[Nullable(0)]
	internal static class ReflectionUtils
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x2569D60", Offset = "0x2568360", VA = "0x182569D60")]
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			return default(bool);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x2569E60", Offset = "0x2568460", VA = "0x182569E60")]
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2569F60", Offset = "0x2568560", VA = "0x182569F60")]
		public static bool IsPublic(PropertyInfo property)
		{
			return default(bool);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x256A000", Offset = "0x2568600", VA = "0x18256A000")]
		[NullableContext(2)]
		public static Type GetObjectType(object v)
		{
			return null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x256A020", Offset = "0x2568620", VA = "0x18256A020")]
		public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, [Nullable(2)] ISerializationBinder binder)
		{
			return null;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x256A0F0", Offset = "0x25686F0", VA = "0x18256A0F0")]
		private static string GetFullyQualifiedTypeName(Type t, [Nullable(2)] ISerializationBinder binder)
		{
			return null;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x256A3C0", Offset = "0x25689C0", VA = "0x18256A3C0")]
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			return null;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x256A530", Offset = "0x2568B30", VA = "0x18256A530")]
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			return default(bool);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x256A680", Offset = "0x2568C80", VA = "0x18256A680")]
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return null;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x256A6D0", Offset = "0x2568CD0", VA = "0x18256A6D0")]
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			return null;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x256A860", Offset = "0x2568E60", VA = "0x18256A860")]
		public static bool IsNullable(Type t)
		{
			return default(bool);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x256A930", Offset = "0x2568F30", VA = "0x18256A930")]
		public static bool IsNullableType(Type t)
		{
			return default(bool);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x256AA30", Offset = "0x2569030", VA = "0x18256AA30")]
		public static Type EnsureNotNullableType(Type t)
		{
			return null;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x256AA90", Offset = "0x2569090", VA = "0x18256AA90")]
		public static Type EnsureNotByRefType(Type t)
		{
			return null;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x256AB00", Offset = "0x2569100", VA = "0x18256AB00")]
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return default(bool);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x256ABA0", Offset = "0x25691A0", VA = "0x18256ABA0")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return default(bool);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x256AC10", Offset = "0x2569210", VA = "0x18256AC10")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] [Nullable(2)] out Type implementingType)
		{
			return default(bool);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x256AF00", Offset = "0x2569500", VA = "0x18256AF00")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			return default(bool);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x256AF70", Offset = "0x2569570", VA = "0x18256AF70")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, [Nullable(2)] out Type implementingType)
		{
			return default(bool);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x256B2B0", Offset = "0x25698B0", VA = "0x18256B2B0")]
		private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, [Nullable(2)] out Type implementingType)
		{
			return default(bool);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x256B440", Offset = "0x2569A40", VA = "0x18256B440")]
		public static Type GetCollectionItemType(Type type)
		{
			return null;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x256B770", Offset = "0x2569D70", VA = "0x18256B770")]
		[NullableContext(2)]
		public static void GetDictionaryKeyValueTypes([Nullable(1)] Type dictionaryType, out Type keyType, out Type valueType)
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x256BBE0", Offset = "0x256A1E0", VA = "0x18256BBE0")]
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			return null;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x256BE80", Offset = "0x256A480", VA = "0x18256BE80")]
		public static bool IsByRefLikeType(Type type)
		{
			return default(bool);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x256C010", Offset = "0x256A610", VA = "0x18256C010")]
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			return default(bool);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x256C0C0", Offset = "0x256A6C0", VA = "0x18256C0C0")]
		public static object GetMemberValue(MemberInfo member, object target)
		{
			return null;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x256C3F0", Offset = "0x256A9F0", VA = "0x18256C3F0")]
		public static void SetMemberValue(MemberInfo member, object target, [Nullable(2)] object value)
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x256C660", Offset = "0x256AC60", VA = "0x18256C660")]
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			return default(bool);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x256C7C0", Offset = "0x256ADC0", VA = "0x18256C7C0")]
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			return default(bool);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x256C970", Offset = "0x256AF70", VA = "0x18256C970")]
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x256D140", Offset = "0x256B740", VA = "0x18256D140")]
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			return default(bool);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006CF")]
		public static T GetAttribute<T>(object attributeProvider) where T : Attribute
		{
			return null;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006D0")]
		public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006D1")]
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x256D3D0", Offset = "0x256B9D0", VA = "0x18256D3D0")]
		public static Attribute[] GetAttributes(object attributeProvider, [Nullable(2)] Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x256DE30", Offset = "0x256C430", VA = "0x18256DE30")]
		public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName)
		{
			return default(StructMultiKey<string, string>);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x256DFC0", Offset = "0x256C5C0", VA = "0x18256DFC0")]
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			return null;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x256E080", Offset = "0x256C680", VA = "0x18256E080")]
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x256E490", Offset = "0x256CA90", VA = "0x18256E490")]
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x256E5D0", Offset = "0x256CBD0", VA = "0x18256E5D0")]
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type type, BindingFlags bindingAttr)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x256E7C0", Offset = "0x256CDC0", VA = "0x18256E7C0")]
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x256EB30", Offset = "0x256D130", VA = "0x18256EB30")]
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			return BindingFlags.Default;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x256EB40", Offset = "0x256D140", VA = "0x18256EB40")]
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x256EF30", Offset = "0x256D530", VA = "0x18256EF30")]
		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			return default(bool);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x256F0C0", Offset = "0x256D6C0", VA = "0x18256F0C0")]
		public static object GetDefaultValue(Type type)
		{
			return null;
		}

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Type[] EmptyTypes;
	}
}

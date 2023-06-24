using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	[NullableContext(1)]
	[Nullable(0)]
	internal static class TypeExtensions
	{
		// Token: 0x06000720 RID: 1824 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2571810", Offset = "0x256FE10", VA = "0x182571810")]
		public static MethodInfo Method(this Delegate d)
		{
			return null;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2571840", Offset = "0x256FE40", VA = "0x182571840")]
		public static MemberTypes MemberType(this MemberInfo memberInfo)
		{
			return (MemberTypes)0;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2571870", Offset = "0x256FE70", VA = "0x182571870")]
		public static bool ContainsGenericParameters(this Type type)
		{
			return default(bool);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x25718A0", Offset = "0x256FEA0", VA = "0x1825718A0")]
		public static bool IsInterface(this Type type)
		{
			return default(bool);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x25718C0", Offset = "0x256FEC0", VA = "0x1825718C0")]
		public static bool IsGenericType(this Type type)
		{
			return default(bool);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x25718F0", Offset = "0x256FEF0", VA = "0x1825718F0")]
		public static bool IsGenericTypeDefinition(this Type type)
		{
			return default(bool);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2571920", Offset = "0x256FF20", VA = "0x182571920")]
		public static Type BaseType(this Type type)
		{
			return null;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2571950", Offset = "0x256FF50", VA = "0x182571950")]
		public static Assembly Assembly(this Type type)
		{
			return null;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2571980", Offset = "0x256FF80", VA = "0x182571980")]
		public static bool IsEnum(this Type type)
		{
			return default(bool);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x25719B0", Offset = "0x256FFB0", VA = "0x1825719B0")]
		public static bool IsClass(this Type type)
		{
			return default(bool);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2571A10", Offset = "0x2570010", VA = "0x182571A10")]
		public static bool IsSealed(this Type type)
		{
			return default(bool);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x2571A40", Offset = "0x2570040", VA = "0x182571A40")]
		public static bool IsAbstract(this Type type)
		{
			return default(bool);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x2571A70", Offset = "0x2570070", VA = "0x182571A70")]
		public static bool IsVisible(this Type type)
		{
			return default(bool);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x2571A90", Offset = "0x2570090", VA = "0x182571A90")]
		public static bool IsValueType(this Type type)
		{
			return default(bool);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x2571AC0", Offset = "0x25700C0", VA = "0x182571AC0")]
		public static bool IsPrimitive(this Type type)
		{
			return default(bool);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2571AF0", Offset = "0x25700F0", VA = "0x182571AF0")]
		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out Type match)
		{
			return default(bool);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2571D60", Offset = "0x2570360", VA = "0x182571D60")]
		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces)
		{
			return default(bool);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x2571D80", Offset = "0x2570380", VA = "0x182571D80")]
		public static bool ImplementInterface(this Type type, Type interfaceType)
		{
			return default(bool);
		}
	}
}

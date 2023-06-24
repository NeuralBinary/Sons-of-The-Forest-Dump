using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Infrastructure
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	internal static class ReflectionHelper
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x9A2980", Offset = "0x9A0F80", VA = "0x1809A2980")]
		public static void SetAttributeOverride(IEnumerable<Attribute> overrides)
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000402")]
		public static Maybe<TAttribute> GetAttribute<TAttribute>() where TAttribute : Attribute
		{
			return null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x9A2DC0", Offset = "0x9A13C0", VA = "0x1809A2DC0")]
		public static string GetAssemblyName()
		{
			return null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x9A2E00", Offset = "0x9A1400", VA = "0x1809A2E00")]
		public static string GetAssemblyVersion()
		{
			return null;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x9A2F20", Offset = "0x9A1520", VA = "0x1809A2F20")]
		public static bool IsFSharpOptionType(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000406")]
		public static T CreateDefaultImmutableInstance<T>(Type[] constructorTypes)
		{
			return null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x9A3060", Offset = "0x9A1660", VA = "0x1809A3060")]
		public static object CreateDefaultImmutableInstance(Type type, Type[] constructorTypes)
		{
			return null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x9A33A0", Offset = "0x9A19A0", VA = "0x1809A33A0")]
		private static Assembly GetExecutingOrEntryAssembly()
		{
			return null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x9A33B0", Offset = "0x9A19B0", VA = "0x1809A33B0")]
		public static IEnumerable<string> GetNamesOfEnum(Type t)
		{
			return null;
		}

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[ThreadStatic]
		private static IDictionary<Type, Attribute> _overrides;
	}
}

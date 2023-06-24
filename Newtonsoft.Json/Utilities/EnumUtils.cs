using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	[Nullable(0)]
	[NullableContext(1)]
	internal static class EnumUtils
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x255E3A0", Offset = "0x255C9A0", VA = "0x18255E3A0")]
		private static EnumInfo InitializeValuesAndNames([Nullable(new byte[]
		{
			0,
			1,
			2
		})] StructMultiKey<Type, NamingStrategy> key)
		{
			return null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005FC")]
		[NullableContext(0)]
		public static IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			return null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x255EA30", Offset = "0x255D030", VA = "0x18255EA30")]
		public static bool TryToString(Type enumType, object value, bool camelCase, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string name)
		{
			return default(bool);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x255EAE0", Offset = "0x255D0E0", VA = "0x18255EAE0")]
		public static bool TryToString(Type enumType, object value, [Nullable(2)] NamingStrategy namingStrategy, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] [Nullable(2)] out string name)
		{
			return default(bool);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x255EDF0", Offset = "0x255D3F0", VA = "0x18255EDF0")]
		private static string InternalFlagsFormat(EnumInfo entry, ulong result)
		{
			return null;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x255EF90", Offset = "0x255D590", VA = "0x18255EF90")]
		public static EnumInfo GetEnumValuesAndNames(Type enumType)
		{
			return null;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x255F100", Offset = "0x255D700", VA = "0x18255F100")]
		private static ulong ToUInt64(object value)
		{
			return 0UL;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x255F470", Offset = "0x255DA70", VA = "0x18255F470")]
		public static object ParseEnum(Type enumType, [Nullable(2)] NamingStrategy namingStrategy, string value, bool disallowNumber)
		{
			return null;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x255FED0", Offset = "0x255E4D0", VA = "0x18255FED0")]
		private static int? MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			return null;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x255FFB0", Offset = "0x255E5B0", VA = "0x18255FFB0")]
		private static int? FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			return null;
		}

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		private const char EnumSeparatorChar = ',';

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		private const string EnumSeparatorString = ", ";

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			2,
			1
		})]
		private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x8")]
		private static CamelCaseNamingStrategy _camelCaseNamingStrategy;
	}
}

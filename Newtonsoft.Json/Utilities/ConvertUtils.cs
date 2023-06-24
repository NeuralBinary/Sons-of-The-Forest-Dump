using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	[NullableContext(1)]
	[Nullable(0)]
	internal static class ConvertUtils
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x2551AA0", Offset = "0x25500A0", VA = "0x182551AA0")]
		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			return PrimitiveTypeCode.Empty;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x2551B00", Offset = "0x2550100", VA = "0x182551B00")]
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			return PrimitiveTypeCode.Empty;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2551E50", Offset = "0x2550450", VA = "0x182551E50")]
		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2551EF0", Offset = "0x25504F0", VA = "0x182551EF0")]
		public static bool IsConvertible(Type t)
		{
			return default(bool);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2551FC0", Offset = "0x25505C0", VA = "0x182551FC0")]
		public static TimeSpan ParseTimeSpan(string input)
		{
			return default(TimeSpan);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x25520F0", Offset = "0x25506F0", VA = "0x1825520F0")]
		[NullableContext(2)]
		private static Func<object, object> CreateCastConverter([Nullable(new byte[]
		{
			0,
			1,
			1
		})] StructMultiKey<Type, Type> t)
		{
			return null;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x2552390", Offset = "0x2550990", VA = "0x182552390")]
		internal static BigInteger ToBigInteger(object value)
		{
			return default(BigInteger);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x25529E0", Offset = "0x2550FE0", VA = "0x1825529E0")]
		public static object FromBigInteger(BigInteger i, Type targetType)
		{
			return null;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2552F00", Offset = "0x2551500", VA = "0x182552F00")]
		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x25531A0", Offset = "0x25517A0", VA = "0x1825531A0")]
		private static bool TryConvert([Nullable(2)] object initialValue, CultureInfo culture, Type targetType, [Nullable(2)] out object value)
		{
			return default(bool);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2553280", Offset = "0x2551880", VA = "0x182553280")]
		private static ConvertUtils.ConvertResult TryConvertInternal([Nullable(2)] object initialValue, CultureInfo culture, Type targetType, [Nullable(2)] out object value)
		{
			return ConvertUtils.ConvertResult.Success;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2553FB0", Offset = "0x25525B0", VA = "0x182553FB0")]
		public static object ConvertOrCast([Nullable(2)] object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x2554150", Offset = "0x2552750", VA = "0x182554150")]
		private static object EnsureTypeAssignable([Nullable(2)] object value, Type initialType, Type targetType)
		{
			return null;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x231AF90", Offset = "0x2319590", VA = "0x18231AF90")]
		public static bool VersionTryParse(string input, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out Version result)
		{
			return default(bool);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x2554450", Offset = "0x2552A50", VA = "0x182554450")]
		public static bool IsInteger(object value)
		{
			return default(bool);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x2554560", Offset = "0x2552B60", VA = "0x182554560")]
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			return ParseResult.None;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x25546D0", Offset = "0x2552CD0", VA = "0x1825546D0")]
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			return ParseResult.None;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2554830", Offset = "0x2552E30", VA = "0x182554830")]
		public static ParseResult DecimalTryParse(char[] chars, int start, int length, out decimal value)
		{
			return ParseResult.None;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x2555550", Offset = "0x2553B50", VA = "0x182555550")]
		public static bool TryConvertGuid(string s, out Guid g)
		{
			return default(bool);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x25555A0", Offset = "0x2553BA0", VA = "0x1825555A0")]
		public static bool TryHexTextToInt(char[] text, int start, int end, out int value)
		{
			return default(bool);
		}

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TypeInformation[] PrimitiveTypeCodes;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x10")]
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			2,
			2,
			2
		})]
		private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> CastConverters;

		// Token: 0x020000A2 RID: 162
		[Token(Token = "0x20000A2")]
		[NullableContext(0)]
		internal enum ConvertResult
		{
			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x40003D7")]
			Success,
			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			CannotConvertNull,
			// Token: 0x040003D9 RID: 985
			[Token(Token = "0x40003D9")]
			NotInstantiableType,
			// Token: 0x040003DA RID: 986
			[Token(Token = "0x40003DA")]
			NoValidConversion
		}
	}
}

using System;
using System.Collections.Generic;
using System.Globalization;
using CSharpx;
using Il2CppDummyDll;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	internal static class TypeConverter
	{
		// Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x9C0670", Offset = "0x9BEC70", VA = "0x1809C0670")]
		public static Maybe<object> ChangeType(IEnumerable<string> values, Type conversionType, bool scalar, bool isFlag, CultureInfo conversionCulture, bool ignoreValueCase)
		{
			return null;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x9C0740", Offset = "0x9BED40", VA = "0x1809C0740")]
		private static Maybe<object> ChangeTypeSequence(IEnumerable<string> values, Type conversionType, CultureInfo conversionCulture, bool ignoreValueCase)
		{
			return null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x9C0E10", Offset = "0x9BF410", VA = "0x1809C0E10")]
		private static Maybe<object> ChangeTypeScalar(string value, Type conversionType, CultureInfo conversionCulture, bool ignoreValueCase)
		{
			return null;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x9C12D0", Offset = "0x9BF8D0", VA = "0x1809C12D0")]
		private static Maybe<object> ChangeTypeFlagCounter(IEnumerable<string> values, Type conversionType, CultureInfo conversionCulture, bool ignoreValueCase)
		{
			return null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x9C16B0", Offset = "0x9BFCB0", VA = "0x1809C16B0")]
		private static object ConvertString(string value, Type type, CultureInfo conversionCulture)
		{
			return null;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x9C1780", Offset = "0x9BFD80", VA = "0x1809C1780")]
		private static Result<object, Exception> ChangeTypeScalarImpl(string value, Type conversionType, CultureInfo conversionCulture, bool ignoreValueCase)
		{
			return null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x9C19C0", Offset = "0x9BFFC0", VA = "0x1809C19C0")]
		private static object ToEnum(this string value, Type conversionType, bool ignoreValueCase)
		{
			return null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x9C1B40", Offset = "0x9C0140", VA = "0x1809C1B40")]
		private static bool IsDefinedEx(object enumValue)
		{
			return default(bool);
		}
	}
}

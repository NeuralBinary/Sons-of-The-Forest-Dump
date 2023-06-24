using System;
using Il2CppDummyDll;

namespace CommandLine.Infrastructure
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	internal static class StringExtensions
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x9A3E30", Offset = "0x9A2430", VA = "0x1809A3E30")]
		public static string ToOneCharString(this char c)
		{
			return null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041F")]
		public static string ToStringInvariant<T>(this T value)
		{
			return null;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000420")]
		public static string ToStringLocal<T>(this T value)
		{
			return null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x9A3E80", Offset = "0x9A2480", VA = "0x1809A3E80")]
		public static string FormatInvariant(this string value, params object[] arguments)
		{
			return null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x9A3F20", Offset = "0x9A2520", VA = "0x1809A3F20")]
		public static string FormatLocal(this string value, params object[] arguments)
		{
			return null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x9A3FD0", Offset = "0x9A25D0", VA = "0x1809A3FD0")]
		public static string Spaces(this int value)
		{
			return null;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x9A3FF0", Offset = "0x9A25F0", VA = "0x1809A3FF0")]
		public static bool EqualsOrdinal(this string strA, string strB)
		{
			return default(bool);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x9A4060", Offset = "0x9A2660", VA = "0x1809A4060")]
		public static bool EqualsOrdinalIgnoreCase(this string strA, string strB)
		{
			return default(bool);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x9A4150", Offset = "0x9A2750", VA = "0x1809A4150")]
		public static int SafeLength(this string value)
		{
			return 0;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x9A4160", Offset = "0x9A2760", VA = "0x1809A4160")]
		public static string JoinTo(this string value, params string[] others)
		{
			return null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x9A4240", Offset = "0x9A2840", VA = "0x1809A4240")]
		public static bool IsBooleanString(this string value)
		{
			return default(bool);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x9A43C0", Offset = "0x9A29C0", VA = "0x1809A43C0")]
		public static bool ToBoolean(this string value)
		{
			return default(bool);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x9A44A0", Offset = "0x9A2AA0", VA = "0x1809A44A0")]
		public static bool ToBooleanLoose(this string value)
		{
			return default(bool);
		}
	}
}

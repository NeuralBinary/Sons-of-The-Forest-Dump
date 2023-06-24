using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	[Nullable(0)]
	[NullableContext(1)]
	internal static class StringUtils
	{
		// Token: 0x06000701 RID: 1793 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x210A640", Offset = "0x2108C40", VA = "0x18210A640")]
		[NullableContext(2)]
		public static bool IsNullOrEmpty([System.Diagnostics.CodeAnalysis.NotNullWhen(false)] string value)
		{
			return default(bool);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x2570390", Offset = "0x256E990", VA = "0x182570390")]
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0)
		{
			return null;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x25704B0", Offset = "0x256EAB0", VA = "0x1825704B0")]
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0, [Nullable(2)] object arg1)
		{
			return null;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x2570620", Offset = "0x256EC20", VA = "0x182570620")]
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0, [Nullable(2)] object arg1, [Nullable(2)] object arg2)
		{
			return null;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x25707D0", Offset = "0x256EDD0", VA = "0x1825707D0")]
		[NullableContext(2)]
		public static string FormatWith([Nullable(1)] this string format, [Nullable(1)] IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x25709C0", Offset = "0x256EFC0", VA = "0x1825709C0")]
		private static string FormatWith(this string format, IFormatProvider provider, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			return null;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x2570A70", Offset = "0x256F070", VA = "0x182570A70")]
		public static bool IsWhiteSpace(string s)
		{
			return default(bool);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x2570B70", Offset = "0x256F170", VA = "0x182570B70")]
		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x2570C70", Offset = "0x256F270", VA = "0x182570C70")]
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600070A")]
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			return null;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x2570D50", Offset = "0x256F350", VA = "0x182570D50")]
		public static string ToCamelCase(string s)
		{
			return null;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x2570F40", Offset = "0x256F540", VA = "0x182570F40")]
		private static char ToLower(char c)
		{
			return '\0';
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x2571080", Offset = "0x256F680", VA = "0x182571080")]
		public static string ToSnakeCase(string s)
		{
			return null;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x2571090", Offset = "0x256F690", VA = "0x182571090")]
		public static string ToKebabCase(string s)
		{
			return null;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x25710A0", Offset = "0x256F6A0", VA = "0x1825710A0")]
		private static string ToSeparatedCase(string s, char separator)
		{
			return null;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x2571420", Offset = "0x256FA20", VA = "0x182571420")]
		public static bool IsHighSurrogate(char c)
		{
			return default(bool);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2571480", Offset = "0x256FA80", VA = "0x182571480")]
		public static bool IsLowSurrogate(char c)
		{
			return default(bool);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x25714E0", Offset = "0x256FAE0", VA = "0x1825714E0")]
		public static int IndexOf(string s, char c)
		{
			return 0;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2571510", Offset = "0x256FB10", VA = "0x182571510")]
		public static string Replace(string s, string oldValue, string newValue)
		{
			return null;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x2571530", Offset = "0x256FB30", VA = "0x182571530")]
		public static bool StartsWith(this string source, char value)
		{
			return default(bool);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x2571560", Offset = "0x256FB60", VA = "0x182571560")]
		public static bool EndsWith(this string source, char value)
		{
			return default(bool);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x25715A0", Offset = "0x256FBA0", VA = "0x1825715A0")]
		public static string Trim(this string s, int start, int length)
		{
			return null;
		}

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		public const string Empty = "";

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		public const char CarriageReturn = '\r';

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		public const char LineFeed = '\n';

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		public const char Tab = '\t';

		// Token: 0x020000F1 RID: 241
		[Token(Token = "0x20000F1")]
		[NullableContext(0)]
		private enum SeparatedCaseState
		{
			// Token: 0x040004D0 RID: 1232
			[Token(Token = "0x40004D0")]
			Start,
			// Token: 0x040004D1 RID: 1233
			[Token(Token = "0x40004D1")]
			Lower,
			// Token: 0x040004D2 RID: 1234
			[Token(Token = "0x40004D2")]
			Upper,
			// Token: 0x040004D3 RID: 1235
			[Token(Token = "0x40004D3")]
			NewWord
		}
	}
}

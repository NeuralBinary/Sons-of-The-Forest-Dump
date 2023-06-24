using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	[NullableContext(1)]
	[Nullable(0)]
	internal static class JavaScriptUtils
	{
		// Token: 0x06000648 RID: 1608 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x25640E0", Offset = "0x25626E0", VA = "0x1825640E0")]
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			return null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x25641B0", Offset = "0x25627B0", VA = "0x1825641B0")]
		public static bool ShouldEscapeJavaScriptString([Nullable(2)] string s, bool[] charEscapeFlags)
		{
			return default(bool);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2564220", Offset = "0x2562820", VA = "0x182564220")]
		[NullableContext(2)]
		public static void WriteEscapedJavaScriptString([Nullable(1)] TextWriter writer, string s, char delimiter, bool appendDelimiters, [Nullable(1)] bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer)
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2564BF0", Offset = "0x25631F0", VA = "0x182564BF0")]
		public static string ToEscapedJavaScriptString([Nullable(2)] string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2564D90", Offset = "0x2563390", VA = "0x182564D90")]
		private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling)
		{
			return 0;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2564E50", Offset = "0x2563450", VA = "0x182564E50")]
		public static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2565020", Offset = "0x2563620", VA = "0x182565020")]
		private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2565280", Offset = "0x2563880", VA = "0x182565280")]
		private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(Task task, TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2565630", Offset = "0x2563C30", VA = "0x182565630")]
		public static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2565890", Offset = "0x2563E90", VA = "0x182565890")]
		private static Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2565A40", Offset = "0x2564040", VA = "0x182565A40")]
		private static Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, int lastWritePosition, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2565D90", Offset = "0x2564390", VA = "0x182565D90")]
		public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, [System.Diagnostics.CodeAnalysis.NotNullWhen(false)] [Nullable(2)] out string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2566250", Offset = "0x2564850", VA = "0x182566250")]
		private static bool TryGetDateConstructorValue(JsonReader reader, out long? integer, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(false)] out string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly bool[] HtmlCharEscapeFlags;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		private const int UnicodeTextLength = 6;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		private const string EscapedUnicodeText = "!";
	}
}

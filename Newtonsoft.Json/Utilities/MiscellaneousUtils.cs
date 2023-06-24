using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[NullableContext(1)]
	[Nullable(0)]
	internal static class MiscellaneousUtils
	{
		// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[NullableContext(2)]
		[Conditional("DEBUG")]
		public static void Assert([DoesNotReturnIf(false)] bool condition, [Optional] string message)
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x25683B0", Offset = "0x25669B0", VA = "0x1825683B0")]
		[NullableContext(2)]
		public static bool ValueEquals(object objA, object objB)
		{
			return default(bool);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x25687B0", Offset = "0x2566DB0", VA = "0x1825687B0")]
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			return null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x25688D0", Offset = "0x2566ED0", VA = "0x1825688D0")]
		public static string ToString([Nullable(2)] object value)
		{
			return null;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2568C80", Offset = "0x2567280", VA = "0x182568C80")]
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			return 0;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x2568D00", Offset = "0x2567300", VA = "0x182568D00")]
		public static string GetPrefix(string qualifiedName)
		{
			return null;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x2568D30", Offset = "0x2567330", VA = "0x182568D30")]
		public static string GetLocalName(string qualifiedName)
		{
			return null;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x2568D60", Offset = "0x2567360", VA = "0x182568D60")]
		public static void GetQualifiedNameParts(string qualifiedName, [Nullable(2)] out string prefix, out string localName)
		{
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x2568EC0", Offset = "0x25674C0", VA = "0x182568EC0")]
		internal static RegexOptions GetRegexOptions(string optionsText)
		{
			return RegexOptions.None;
		}
	}
}

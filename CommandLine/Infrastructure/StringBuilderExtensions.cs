using System;
using System.Text;
using Il2CppDummyDll;

namespace CommandLine.Infrastructure
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	internal static class StringBuilderExtensions
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x9A35D0", Offset = "0x9A1BD0", VA = "0x1809A35D0")]
		public static StringBuilder AppendWhen(this StringBuilder builder, bool condition, params string[] values)
		{
			return null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x9A3730", Offset = "0x9A1D30", VA = "0x1809A3730")]
		public static StringBuilder AppendWhen(this StringBuilder builder, bool condition, params char[] values)
		{
			return null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x9A37D0", Offset = "0x9A1DD0", VA = "0x1809A37D0")]
		public static StringBuilder AppendFormatWhen(this StringBuilder builder, bool condition, string format, params object[] args)
		{
			return null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x9A38C0", Offset = "0x9A1EC0", VA = "0x1809A38C0")]
		public static StringBuilder AppendIf(this StringBuilder builder, bool condition, string ifTrue, string ifFalse)
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x9A3900", Offset = "0x9A1F00", VA = "0x1809A3900")]
		public static StringBuilder BimapIf(this StringBuilder builder, bool condition, Func<StringBuilder, StringBuilder> ifTrue, Func<StringBuilder, StringBuilder> ifFalse)
		{
			return null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x9A3950", Offset = "0x9A1F50", VA = "0x1809A3950")]
		public static StringBuilder MapIf(this StringBuilder builder, bool condition, Func<StringBuilder, StringBuilder> ifTrue)
		{
			return null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x9A3990", Offset = "0x9A1F90", VA = "0x1809A3990")]
		public static StringBuilder AppendIfNotEmpty(this StringBuilder builder, params string[] values)
		{
			return null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x9A3A10", Offset = "0x9A2010", VA = "0x1809A3A10")]
		public static string SafeToString(this StringBuilder builder)
		{
			return null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x9A3A70", Offset = "0x9A2070", VA = "0x1809A3A70")]
		public static int SafeLength(this StringBuilder builder)
		{
			return 0;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x9A3A80", Offset = "0x9A2080", VA = "0x1809A3A80")]
		public static StringBuilder TrimEnd(this StringBuilder builder, char c)
		{
			return null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x9A3AC0", Offset = "0x9A20C0", VA = "0x1809A3AC0")]
		public static StringBuilder TrimEndIfMatch(this StringBuilder builder, char c)
		{
			return null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x9A3B30", Offset = "0x9A2130", VA = "0x1809A3B30")]
		public static StringBuilder TrimEndIfMatchWhen(this StringBuilder builder, bool condition, char c)
		{
			return null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x9A3BA0", Offset = "0x9A21A0", VA = "0x1809A3BA0")]
		public static int TrailingSpaces(this StringBuilder builder)
		{
			return 0;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x9A3C30", Offset = "0x9A2230", VA = "0x1809A3C30")]
		public static bool SafeStartsWith(this StringBuilder builder, string s)
		{
			return default(bool);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x9A3D30", Offset = "0x9A2330", VA = "0x1809A3D30")]
		public static bool SafeEndsWith(this StringBuilder builder, string s)
		{
			return default(bool);
		}
	}
}

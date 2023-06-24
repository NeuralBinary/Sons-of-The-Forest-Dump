using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace CommandLine.Text
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	public class TextWrapper
	{
		// Token: 0x060003D6 RID: 982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x9A0E30", Offset = "0x99F430", VA = "0x1809A0E30")]
		public TextWrapper(string input)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x9A0FD0", Offset = "0x99F5D0", VA = "0x1809A0FD0")]
		public TextWrapper WordWrap(int columnWidth)
		{
			return null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x9A1200", Offset = "0x99F800", VA = "0x1809A1200")]
		public TextWrapper Indent(int numberOfSpaces)
		{
			return null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x9A13B0", Offset = "0x99F9B0", VA = "0x1809A13B0")]
		public string ToText()
		{
			return null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x9A1490", Offset = "0x99FA90", VA = "0x1809A1490")]
		public static string WrapAndIndentText(string input, int indentLevel, int columnWidth)
		{
			return null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x9A18D0", Offset = "0x99FED0", VA = "0x1809A18D0")]
		private string[] WordWrapLine(string line, int columnWidth)
		{
			return null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x9A1C30", Offset = "0x9A0230", VA = "0x1809A1C30")]
		private static List<StringBuilder> AddWordToLastLineOrCreateNewLineIfNecessary(List<StringBuilder> lines, string word, int columnWidth)
		{
			return null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x9A1EF0", Offset = "0x9A04F0", VA = "0x1809A1EF0")]
		private static string RightString(string str, int n)
		{
			return null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x9A1F70", Offset = "0x9A0570", VA = "0x1809A1F70")]
		private static string LeftString(string str, int n)
		{
			return null;
		}

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x10")]
		private string[] lines;
	}
}

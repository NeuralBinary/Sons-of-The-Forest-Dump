using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class JsonReader
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002F")]
		public bool AllowComments
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x20930B0", Offset = "0x20916B0", VA = "0x1820930B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x20930D0", Offset = "0x20916D0", VA = "0x1820930D0")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000245C File Offset: 0x0000065C
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000030")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x20930F0", Offset = "0x20916F0", VA = "0x1820930F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x2093110", Offset = "0x2091710", VA = "0x182093110")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x17000031")]
		public bool EndOfInput
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x17000032")]
		public bool EndOfJson
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x17000033")]
		public JsonToken Token
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000034")]
		public object Value
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2093140", Offset = "0x2091740", VA = "0x182093140")]
		public JsonReader(string json_text)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x20931B0", Offset = "0x20917B0", VA = "0x1820931B0")]
		public JsonReader(TextReader reader)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x20931C0", Offset = "0x20917C0", VA = "0x1820931C0")]
		private JsonReader(TextReader reader, bool owned)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2093490", Offset = "0x2091A90", VA = "0x182093490")]
		private static void PopulateParseTable()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2093CC0", Offset = "0x20922C0", VA = "0x182093CC0")]
		private static void TableAddCol(ParserToken row, int col, params int[] symbols)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2093DF0", Offset = "0x20923F0", VA = "0x182093DF0")]
		private static void TableAddRow(ParserToken rule)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2093EC0", Offset = "0x20924C0", VA = "0x182093EC0")]
		private void ProcessNumber(string number)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2094470", Offset = "0x2092A70", VA = "0x182094470")]
		private void ProcessSymbol()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x20946F0", Offset = "0x2092CF0", VA = "0x1820946F0")]
		private bool ReadToken()
		{
			return default(bool);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x20947C0", Offset = "0x2092DC0", VA = "0x1820947C0")]
		public void Close()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2094850", Offset = "0x2092E50", VA = "0x182094850")]
		public bool Read()
		{
			return default(bool);
		}

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x0")]
		private static IDictionary<int, IDictionary<int, int[]>> parse_table;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10")]
		private Stack<int> automaton_stack;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x18")]
		private int current_input;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x1C")]
		private int current_symbol;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x20")]
		private bool end_of_json;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x21")]
		private bool end_of_input;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x28")]
		private Lexer lexer;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x30")]
		private bool parser_in_string;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x31")]
		private bool parser_return;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x32")]
		private bool read_started;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x38")]
		private TextReader reader;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x40")]
		private bool reader_is_owned;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x48")]
		private object token_value;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x50")]
		private JsonToken token;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x54")]
		public bool reReadToken;
	}
}

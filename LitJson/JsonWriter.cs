using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class JsonWriter
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public int IndentValue
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x2094CA0", Offset = "0x20932A0", VA = "0x182094CA0")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002504 File Offset: 0x00000704
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000036")]
		public bool PrettyPrint
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000037")]
		public TextWriter TextWriter
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000251C File Offset: 0x0000071C
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000038")]
		public bool Validate
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x2094CC0", Offset = "0x20932C0", VA = "0x182094CC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x2094CD0", Offset = "0x20932D0", VA = "0x182094CD0")]
			set
			{
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2094D80", Offset = "0x2093380", VA = "0x182094D80")]
		public JsonWriter()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2094ED0", Offset = "0x20934D0", VA = "0x182094ED0")]
		public JsonWriter(StringBuilder sb)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2094FE0", Offset = "0x20935E0", VA = "0x182094FE0")]
		public JsonWriter(TextWriter writer)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x20950A0", Offset = "0x20936A0", VA = "0x1820950A0")]
		private void DoValidation(Condition cond)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2095360", Offset = "0x2093960", VA = "0x182095360")]
		private void Init()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2095560", Offset = "0x2093B60", VA = "0x182095560")]
		private static void IntToHex(int n, char[] hex)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x20955D0", Offset = "0x2093BD0", VA = "0x1820955D0")]
		private void Indent()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x20955E0", Offset = "0x2093BE0", VA = "0x1820955E0")]
		private void Put(string str)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2095670", Offset = "0x2093C70", VA = "0x182095670")]
		private void PutNewline()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2095700", Offset = "0x2093D00", VA = "0x182095700")]
		private void PutNewline(bool add_comma)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2095790", Offset = "0x2093D90", VA = "0x182095790")]
		private void PutString(string str)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2095B60", Offset = "0x2094160", VA = "0x182095B60")]
		private void Unindent()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2095B70", Offset = "0x2094170", VA = "0x182095B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2095BD0", Offset = "0x20941D0", VA = "0x182095BD0")]
		public void Reset()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2095CE0", Offset = "0x20942E0", VA = "0x182095CE0")]
		public void Write(bool boolean)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2095E30", Offset = "0x2094430", VA = "0x182095E30")]
		public void Write(decimal number)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2095FE0", Offset = "0x20945E0", VA = "0x182095FE0")]
		public void Write(double number)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2096240", Offset = "0x2094840", VA = "0x182096240")]
		public void Write(int number)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x20963F0", Offset = "0x20949F0", VA = "0x1820963F0")]
		public void Write(long number)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x20965A0", Offset = "0x2094BA0", VA = "0x1820965A0")]
		public void Write(string str)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x20966F0", Offset = "0x2094CF0", VA = "0x1820966F0")]
		public void Write(ulong number)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x20968A0", Offset = "0x2094EA0", VA = "0x1820968A0")]
		public void WriteArrayEnd()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2096A10", Offset = "0x2095010", VA = "0x182096A10")]
		public void WriteArrayStart()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2096B20", Offset = "0x2095120", VA = "0x182096B20")]
		public void WriteObjectEnd()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2096C90", Offset = "0x2095290", VA = "0x182096C90")]
		public void WriteObjectStart()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2096DA0", Offset = "0x20953A0", VA = "0x182096DA0")]
		public void WritePropertyName(string property_name)
		{
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		private static NumberFormatInfo number_format;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x10")]
		private WriterContext context;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x18")]
		private Stack<WriterContext> ctx_stack;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x20")]
		private bool has_reached_end;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x28")]
		private char[] hex_seq;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x30")]
		private int indentation;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x34")]
		private int indent_value;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder inst_string_builder;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x40")]
		private bool pretty_print;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x41")]
		private bool validate;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x48")]
		private TextWriter writer;
	}
}

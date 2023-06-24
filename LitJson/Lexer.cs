using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	internal class Lexer
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00002534 File Offset: 0x00000734
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000039")]
		public bool AllowComments
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000254C File Offset: 0x0000074C
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003A")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x5FD500", Offset = "0x5FBB00", VA = "0x1805FD500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x5FD510", Offset = "0x5FBB10", VA = "0x1805FD510")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x1700003B")]
		public bool EndOfInput
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x5FD520", Offset = "0x5FBB20", VA = "0x1805FD520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x1700003C")]
		public int Token
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x1700003D")]
		public string StringValue
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2096FA0", Offset = "0x20955A0", VA = "0x182096FA0")]
		public Lexer(TextReader reader)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x20971F0", Offset = "0x20957F0", VA = "0x1820971F0")]
		private static int HexValue(int digit)
		{
			return 0;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2097290", Offset = "0x2095890", VA = "0x182097290")]
		private static void PopulateFsmTables()
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2097B20", Offset = "0x2096120", VA = "0x182097B20")]
		private static char ProcessEscChar(int esc_char)
		{
			return '\0';
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2097C10", Offset = "0x2096210", VA = "0x182097C10")]
		private static bool State1(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2097EA0", Offset = "0x20964A0", VA = "0x182097EA0")]
		private static bool State2(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2097F80", Offset = "0x2096580", VA = "0x182097F80")]
		private static bool State3(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2098110", Offset = "0x2096710", VA = "0x182098110")]
		private static bool State4(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2098240", Offset = "0x2096840", VA = "0x182098240")]
		private static bool State5(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x20982F0", Offset = "0x20968F0", VA = "0x1820982F0")]
		private static bool State6(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2098450", Offset = "0x2096A50", VA = "0x182098450")]
		private static bool State7(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2098560", Offset = "0x2096B60", VA = "0x182098560")]
		private static bool State8(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2098680", Offset = "0x2096C80", VA = "0x182098680")]
		private static bool State9(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2098710", Offset = "0x2096D10", VA = "0x182098710")]
		private static bool State10(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x20987A0", Offset = "0x2096DA0", VA = "0x1820987A0")]
		private static bool State11(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2098830", Offset = "0x2096E30", VA = "0x182098830")]
		private static bool State12(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x20988C0", Offset = "0x2096EC0", VA = "0x1820988C0")]
		private static bool State13(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2098950", Offset = "0x2096F50", VA = "0x182098950")]
		private static bool State14(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x20987A0", Offset = "0x2096DA0", VA = "0x1820987A0")]
		private static bool State15(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x20989E0", Offset = "0x2096FE0", VA = "0x1820989E0")]
		private static bool State16(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2098A70", Offset = "0x2097070", VA = "0x182098A70")]
		private static bool State17(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2098B00", Offset = "0x2097100", VA = "0x182098B00")]
		private static bool State18(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2098B90", Offset = "0x2097190", VA = "0x182098B90")]
		private static bool State19(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2098C90", Offset = "0x2097290", VA = "0x182098C90")]
		private static bool State20(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2098D20", Offset = "0x2097320", VA = "0x182098D20")]
		private static bool State21(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2098F60", Offset = "0x2097560", VA = "0x182098F60")]
		private static bool State22(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2099150", Offset = "0x2097750", VA = "0x182099150")]
		private static bool State23(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2099250", Offset = "0x2097850", VA = "0x182099250")]
		private static bool State24(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x20992F0", Offset = "0x20978F0", VA = "0x1820992F0")]
		private static bool State25(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x20993A0", Offset = "0x20979A0", VA = "0x1820993A0")]
		private static bool State26(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2099440", Offset = "0x2097A40", VA = "0x182099440")]
		private static bool State27(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x20994E0", Offset = "0x2097AE0", VA = "0x1820994E0")]
		private static bool State28(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x20995B0", Offset = "0x2097BB0", VA = "0x1820995B0")]
		private bool GetChar()
		{
			return default(bool);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2099610", Offset = "0x2097C10", VA = "0x182099610")]
		private int NextChar()
		{
			return 0;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2099650", Offset = "0x2097C50", VA = "0x182099650")]
		public bool NextToken()
		{
			return default(bool);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2099880", Offset = "0x2097E80", VA = "0x182099880")]
		private void UngetChar()
		{
		}

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x0")]
		private static int[] fsm_return_table;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x8")]
		private static Lexer.StateHandler[] fsm_handler_table;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x10")]
		private bool allow_comments;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x11")]
		private bool allow_single_quoted_strings;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x12")]
		private bool end_of_input;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x18")]
		private FsmContext fsm_context;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x20")]
		private int input_buffer;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x24")]
		private int input_char;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x28")]
		private TextReader reader;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x30")]
		private int state;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder string_buffer;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x40")]
		private string string_value;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x48")]
		private int token;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x4C")]
		private int unichar;

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000140 RID: 320
		[Token(Token = "0x200001C")]
		private delegate bool StateHandler(FsmContext ctx);
	}
}

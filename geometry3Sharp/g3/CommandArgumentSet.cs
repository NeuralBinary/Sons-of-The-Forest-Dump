using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public class CommandArgumentSet
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1F399C0", Offset = "0x1F37FC0", VA = "0x181F399C0")]
		public void Register(string argument, int defaultValue)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1F39A40", Offset = "0x1F38040", VA = "0x181F39A40")]
		public void Register(string argument, float defaultValue)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1F39AC0", Offset = "0x1F380C0", VA = "0x181F39AC0")]
		public void Register(string argument, bool defaultValue)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1F39B50", Offset = "0x1F38150", VA = "0x181F39B50")]
		public void Register(string argument, string defaultValue)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000030D4 File Offset: 0x000012D4
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1F39BD0", Offset = "0x1F381D0", VA = "0x181F39BD0")]
		public bool Saw(string argument)
		{
			return default(bool);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000030EC File Offset: 0x000012EC
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1F39C30", Offset = "0x1F38230", VA = "0x181F39C30")]
		public bool Validate(string sParam, params string[] values)
		{
			return default(bool);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00003104 File Offset: 0x00001304
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1F39DA0", Offset = "0x1F383A0", VA = "0x181F39DA0")]
		public bool Parse(string[] arguments)
		{
			return default(bool);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1F3A250", Offset = "0x1F38850", VA = "0x181F3A250", Slot = "4")]
		protected virtual void error_missing_argument(string arg)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1F3A2B0", Offset = "0x1F388B0", VA = "0x181F3A2B0", Slot = "5")]
		protected virtual void error_invalid_value(string arg, string value)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1F3A320", Offset = "0x1F38920", VA = "0x181F3A320")]
		public CommandArgumentSet()
		{
		}

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> Integers;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, float> Floats;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> Strings;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, bool> Flags;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x30")]
		public HashSet<string> SawArguments;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x38")]
		public List<string> Filenames;
	}
}

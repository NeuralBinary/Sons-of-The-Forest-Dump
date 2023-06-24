using System;
using System.Reflection;
using Il2CppDummyDll;

namespace CommandLine.Text
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public class CopyrightInfo
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008E")]
		public static CopyrightInfo Empty
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x996750", Offset = "0x994D50", VA = "0x180996750")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x996800", Offset = "0x994E00", VA = "0x180996800")]
		public CopyrightInfo(string author, int year)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x996890", Offset = "0x994E90", VA = "0x180996890")]
		public CopyrightInfo(string author, params int[] years)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x9968B0", Offset = "0x994EB0", VA = "0x1809968B0")]
		public CopyrightInfo(bool isSymbolUpper, string author, params int[] copyrightYears)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected CopyrightInfo()
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		private CopyrightInfo(AssemblyCopyrightAttribute attribute)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008F")]
		public static CopyrightInfo Default
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x996A70", Offset = "0x995070", VA = "0x180996A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000090")]
		protected virtual string CopyrightWord
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x996D00", Offset = "0x995300", VA = "0x180996D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x996D30", Offset = "0x995330", VA = "0x180996D30")]
		public static implicit operator string(CopyrightInfo info)
		{
			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x996D60", Offset = "0x995360", VA = "0x180996D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x996F80", Offset = "0x995580", VA = "0x180996F80", Slot = "5")]
		protected virtual string FormatYears(int[] years)
		{
			return null;
		}

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		private const string DefaultCopyrightWord = "Copyright";

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		private const string SymbolLower = "(c)";

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		private const string SymbolUpper = "(C)";

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x10")]
		private readonly AssemblyCopyrightAttribute attribute;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool isSymbolUpper;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x20")]
		private readonly int[] copyrightYears;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x28")]
		private readonly string author;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x30")]
		private readonly int builderSize;
	}
}

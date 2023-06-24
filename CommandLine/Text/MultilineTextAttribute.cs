using System;
using Il2CppDummyDll;

namespace CommandLine.Text
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public abstract class MultilineTextAttribute : Attribute
	{
		// Token: 0x06000395 RID: 917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x99D3E0", Offset = "0x99B9E0", VA = "0x18099D3E0")]
		protected MultilineTextAttribute(string line1)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x99D510", Offset = "0x99BB10", VA = "0x18099D510")]
		protected MultilineTextAttribute(string line1, string line2)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x99D6A0", Offset = "0x99BCA0", VA = "0x18099D6A0")]
		protected MultilineTextAttribute(string line1, string line2, string line3)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x996310", Offset = "0x994910", VA = "0x180996310")]
		protected MultilineTextAttribute(string line1, string line2, string line3, string line4)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x996550", Offset = "0x994B50", VA = "0x180996550")]
		protected MultilineTextAttribute(string line1, string line2, string line3, string line4, string line5)
		{
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A5")]
		public virtual string Value
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x99D890", Offset = "0x99BE90", VA = "0x18099D890", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A6")]
		public string Line1
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public string Line2
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A8")]
		public string Line3
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A9")]
		public string Line4
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AA")]
		public string Line5
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x99DA50", Offset = "0x99C050", VA = "0x18099DA50")]
		internal HelpText AddToHelpText(HelpText helpText, Func<string, HelpText> func)
		{
			return null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x99DC20", Offset = "0x99C220", VA = "0x18099DC20")]
		internal HelpText AddToHelpText(HelpText helpText, bool before)
		{
			return null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x99DCC0", Offset = "0x99C2C0", VA = "0x18099DCC0", Slot = "8")]
		protected virtual int GetLastLineWithText(string[] value)
		{
			return 0;
		}

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x10")]
		private readonly string line1;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x18")]
		private readonly string line2;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x20")]
		private readonly string line3;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x28")]
		private readonly string line4;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x30")]
		private readonly string line5;
	}
}

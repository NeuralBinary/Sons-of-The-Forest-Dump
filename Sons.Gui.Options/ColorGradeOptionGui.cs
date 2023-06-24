using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Serializable]
	public class ColorGradeOptionGui : CustomMenuOptionGui
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x1700000B")]
		public override bool ShouldShowValueOptions
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x303A450", Offset = "0x3038A50", VA = "0x18303A450", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700000C")]
		public override string SettingKey
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x303A480", Offset = "0x3038A80", VA = "0x18303A480", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x303A4B0", Offset = "0x3038AB0", VA = "0x18303A4B0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public ColorGradeOptionGui()
		{
		}

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		private const string LabelText = "Color Grade";
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[Serializable]
	public class LanguageOptionGui : CustomMenuOptionGui
	{
		// Token: 0x0600011B RID: 283 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x303E010", Offset = "0x303C610", VA = "0x18303E010", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003C")]
		public override string SettingKey
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x303E040", Offset = "0x303C640", VA = "0x18303E040", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x303E070", Offset = "0x303C670", VA = "0x18303E070", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x303E080", Offset = "0x303C680", VA = "0x18303E080", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public LanguageOptionGui()
		{
		}

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		private const string LabelText = "Language";
	}
}

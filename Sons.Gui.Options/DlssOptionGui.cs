using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[Serializable]
	public class DlssOptionGui : CustomMenuOptionGui
	{
		// Token: 0x060000AA RID: 170 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x303BAF0", Offset = "0x303A0F0", VA = "0x18303BAF0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000022")]
		public override string SettingKey
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x303BB20", Offset = "0x303A120", VA = "0x18303BB20", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x303BB50", Offset = "0x303A150", VA = "0x18303BB50", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x303BB80", Offset = "0x303A180", VA = "0x18303BB80", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public DlssOptionGui()
		{
		}

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		private const string LabelText = "Dlss";
	}
}

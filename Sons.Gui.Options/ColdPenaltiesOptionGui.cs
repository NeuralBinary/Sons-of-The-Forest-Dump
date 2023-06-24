using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[Serializable]
	public class ColdPenaltiesOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x303AC90", Offset = "0x3039290", VA = "0x18303AC90", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000010")]
		public override string SettingKey
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x303ACC0", Offset = "0x30392C0", VA = "0x18303ACC0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x303ACF0", Offset = "0x30392F0", VA = "0x18303ACF0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x303AD40", Offset = "0x3039340", VA = "0x18303AD40", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public ColdPenaltiesOptionGui()
		{
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		private const string LabelText = "Cold Penalties";
	}
}

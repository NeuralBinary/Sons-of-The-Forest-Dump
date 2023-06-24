using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Serializable]
	public class AnimalSpawnRateOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x303AB70", Offset = "0x3039170", VA = "0x18303AB70", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700000F")]
		public override string SettingKey
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x303ABA0", Offset = "0x30391A0", VA = "0x18303ABA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x303ABD0", Offset = "0x30391D0", VA = "0x18303ABD0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x303AC30", Offset = "0x3039230", VA = "0x18303AC30", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public AnimalSpawnRateOptionGui()
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		private const string LabelText = "Animal Amounts";
	}
}

using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[Serializable]
	public class GrassQualityOptionGui : HighMediumLowOptionGuiBase
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x303D600", Offset = "0x303BC00", VA = "0x18303D600", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000034")]
		public override string SettingKey
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x303D630", Offset = "0x303BC30", VA = "0x18303D630", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x303D660", Offset = "0x303BC60", VA = "0x18303D660", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public GrassQualityOptionGui()
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		private const string LabelText = "Grass";
	}
}

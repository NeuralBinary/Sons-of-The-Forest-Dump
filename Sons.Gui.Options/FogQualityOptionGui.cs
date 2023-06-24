using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[Serializable]
	public class FogQualityOptionGui : HighLowOffOptionGuiBase
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x303C470", Offset = "0x303AA70", VA = "0x18303C470", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700002A")]
		public override string SettingKey
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x303C4A0", Offset = "0x303AAA0", VA = "0x18303C4A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x303C4D0", Offset = "0x303AAD0", VA = "0x18303C4D0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public FogQualityOptionGui()
		{
		}

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		private const string LabelText = "Fog Quality";
	}
}

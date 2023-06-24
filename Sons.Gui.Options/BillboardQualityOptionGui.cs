using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[Serializable]
	public class BillboardQualityOptionGui : HighMediumLowOptionGuiBase
	{
		// Token: 0x0600002A RID: 42 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3039E60", Offset = "0x3038460", VA = "0x183039E60", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000005")]
		public override string SettingKey
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x3039E90", Offset = "0x3038490", VA = "0x183039E90", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3039EC0", Offset = "0x30384C0", VA = "0x183039EC0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public BillboardQualityOptionGui()
		{
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		private const string LabelText = "Billboard Quality";
	}
}

using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	[Serializable]
	public class WaterQualityOptionGui : HighLowOptionGuiBase
	{
		// Token: 0x060002ED RID: 749 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x3053B70", Offset = "0x3052170", VA = "0x183053B70", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000093")]
		public override string SettingKey
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x3053BA0", Offset = "0x30521A0", VA = "0x183053BA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x3053BD0", Offset = "0x30521D0", VA = "0x183053BD0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public WaterQualityOptionGui()
		{
		}

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		private const string LabelText = "Water";
	}
}

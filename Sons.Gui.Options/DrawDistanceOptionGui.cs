using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[Serializable]
	public class DrawDistanceOptionGui : QualityOptionGui
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x303BBD0", Offset = "0x303A1D0", VA = "0x18303BBD0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000023")]
		public override string SettingKey
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x303BC00", Offset = "0x303A200", VA = "0x18303BC00", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public DrawDistanceOptionGui()
		{
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		private const string LabelText = "Draw Distance";
	}
}

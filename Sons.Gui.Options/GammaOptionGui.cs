using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[Serializable]
	public class GammaOptionGui : FloatOptionGui
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x303C7A0", Offset = "0x303ADA0", VA = "0x18303C7A0", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000032")]
		public override string SettingKey
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x303C7D0", Offset = "0x303ADD0", VA = "0x18303C7D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x303C800", Offset = "0x303AE00", VA = "0x18303C800", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public GammaOptionGui()
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		private const string LabelText = "Gamma";
	}
}

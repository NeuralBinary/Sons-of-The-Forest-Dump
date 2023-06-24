using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[Serializable]
	public class GamePadXSensitivityOptionGui : FloatOptionGui
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x303C6D0", Offset = "0x303ACD0", VA = "0x18303C6D0", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000030")]
		public override string SettingKey
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x303C700", Offset = "0x303AD00", VA = "0x18303C700", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x303C730", Offset = "0x303AD30", VA = "0x18303C730", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public GamePadXSensitivityOptionGui()
		{
		}

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		private const string LabelText = "GamePad X Sensitivity";
	}
}

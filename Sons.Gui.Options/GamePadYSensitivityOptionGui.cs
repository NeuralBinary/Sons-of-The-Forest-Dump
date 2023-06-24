using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[Serializable]
	public class GamePadYSensitivityOptionGui : FloatOptionGui
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x303C740", Offset = "0x303AD40", VA = "0x18303C740", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000031")]
		public override string SettingKey
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x303C770", Offset = "0x303AD70", VA = "0x18303C770", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x303C730", Offset = "0x303AD30", VA = "0x18303C730", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public GamePadYSensitivityOptionGui()
		{
		}

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		private const string LabelText = "GamePad Y Sensitivity";
	}
}

using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[Serializable]
	public class MouseYSensitivityOptionGui : FloatOptionGui
	{
		// Token: 0x06000143 RID: 323 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x303F380", Offset = "0x303D980", VA = "0x18303F380", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000043")]
		public override string SettingKey
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x303F3B0", Offset = "0x303D9B0", VA = "0x18303F3B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x303C730", Offset = "0x303AD30", VA = "0x18303C730", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public MouseYSensitivityOptionGui()
		{
		}

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		private const string LabelText = "Mouse Y Sensitivity";
	}
}

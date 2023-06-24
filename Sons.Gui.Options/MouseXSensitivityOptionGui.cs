using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[Serializable]
	public class MouseXSensitivityOptionGui : FloatOptionGui
	{
		// Token: 0x0600013F RID: 319 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x303F320", Offset = "0x303D920", VA = "0x18303F320", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000042")]
		public override string SettingKey
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x303F350", Offset = "0x303D950", VA = "0x18303F350", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x303C730", Offset = "0x303AD30", VA = "0x18303C730", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public MouseXSensitivityOptionGui()
		{
		}

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		private const string LabelText = "Mouse X Sensitivity";
	}
}

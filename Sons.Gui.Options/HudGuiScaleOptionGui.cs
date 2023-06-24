using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[Serializable]
	public class HudGuiScaleOptionGui : FloatOptionGui
	{
		// Token: 0x0600010F RID: 271 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x303DE60", Offset = "0x303C460", VA = "0x18303DE60", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000039")]
		public override string SettingKey
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x303DE90", Offset = "0x303C490", VA = "0x18303DE90", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2F145B0", Offset = "0x2F12BB0", VA = "0x182F145B0", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public HudGuiScaleOptionGui()
		{
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		private const string LabelText = "Hud Scale";
	}
}

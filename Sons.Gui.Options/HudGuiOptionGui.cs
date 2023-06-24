using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[Serializable]
	public class HudGuiOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x0600010A RID: 266 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x303DDB0", Offset = "0x303C3B0", VA = "0x18303DDB0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000037")]
		public override string SettingKey
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x303DDE0", Offset = "0x303C3E0", VA = "0x18303DDE0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000038")]
		public override bool IsSettingVisible
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x303DE10", Offset = "0x303C410", VA = "0x18303DE10")]
		public HudGuiOptionGui()
		{
		}

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		private const string LabelText = "Vitals Hud";
	}
}

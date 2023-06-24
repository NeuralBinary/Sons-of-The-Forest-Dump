using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[Serializable]
	public class MiniMapGuiOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x06000137 RID: 311 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x303F1C0", Offset = "0x303D7C0", VA = "0x18303F1C0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000040")]
		public override string SettingKey
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x303F1F0", Offset = "0x303D7F0", VA = "0x18303F1F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x303F220", Offset = "0x303D820", VA = "0x18303F220")]
		public MiniMapGuiOptionGui()
		{
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		private const string LabelText = "MiniMap Hud";
	}
}

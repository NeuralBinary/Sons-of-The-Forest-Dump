using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[Serializable]
	public class GuiOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x303D690", Offset = "0x303BC90", VA = "0x18303D690", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000035")]
		public override string SettingKey
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x303D6C0", Offset = "0x303BCC0", VA = "0x18303D6C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x17000036")]
		public override bool IsSettingVisible
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x303D6F0", Offset = "0x303BCF0", VA = "0x18303D6F0")]
		public GuiOptionGui()
		{
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		private const string LabelText = "All Gui";
	}
}

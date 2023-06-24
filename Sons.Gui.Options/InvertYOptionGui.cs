using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Serializable]
	public class InvertYOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x06000113 RID: 275 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x303DEC0", Offset = "0x303C4C0", VA = "0x18303DEC0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003A")]
		public override string SettingKey
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x303DEF0", Offset = "0x303C4F0", VA = "0x18303DEF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x303DF20", Offset = "0x303C520", VA = "0x18303DF20")]
		public InvertYOptionGui()
		{
		}

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		private const string LabelText = "Invert Y";
	}
}

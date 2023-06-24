using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Serializable]
	public class JumpOptionGui : InputOptionGui
	{
		// Token: 0x06000117 RID: 279 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x303DF70", Offset = "0x303C570", VA = "0x18303DF70", Slot = "31")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003B")]
		public override string SettingKey
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x303DFA0", Offset = "0x303C5A0", VA = "0x18303DFA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x303DFD0", Offset = "0x303C5D0", VA = "0x18303DFD0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x303E000", Offset = "0x303C600", VA = "0x18303E000")]
		public JumpOptionGui()
		{
		}

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		private const string LabelText = "Jump";
	}
}

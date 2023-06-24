using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[Serializable]
	public class BrightnessOptionGui : FloatOptionGui
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3039FA0", Offset = "0x30385A0", VA = "0x183039FA0", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3039FD0", Offset = "0x30385D0", VA = "0x183039FD0", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000007")]
		public override string SettingKey
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x303A020", Offset = "0x3038620", VA = "0x18303A020", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public BrightnessOptionGui()
		{
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		private const string LabelText = "Brightness";
	}
}

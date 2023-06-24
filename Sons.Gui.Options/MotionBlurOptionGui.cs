using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[Serializable]
	public class MotionBlurOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x0600013B RID: 315 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x303F270", Offset = "0x303D870", VA = "0x18303F270", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000041")]
		public override string SettingKey
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x303F2A0", Offset = "0x303D8A0", VA = "0x18303F2A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x303F2D0", Offset = "0x303D8D0", VA = "0x18303F2D0")]
		public MotionBlurOptionGui()
		{
		}

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		private const string LabelText = "Motion Blur";
	}
}

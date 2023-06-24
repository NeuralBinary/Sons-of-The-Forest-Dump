using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Serializable]
	public class TargetFrameRateOptionGui : FloatOptionGui
	{
		// Token: 0x060002BF RID: 703 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x3053000", Offset = "0x3051600", VA = "0x183053000", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x3053030", Offset = "0x3051630", VA = "0x183053030", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x3053030", Offset = "0x3051630", VA = "0x183053030", Slot = "34")]
		internal override float GetMaxValue()
		{
			return 0f;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x3053040", Offset = "0x3051640", VA = "0x183053040", Slot = "33")]
		internal override float GetMinValue()
		{
			return 0f;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000085")]
		public override string SettingKey
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x3053050", Offset = "0x3051650", VA = "0x183053050", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public TargetFrameRateOptionGui()
		{
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		private const string LabelText = "Max FPS";
	}
}

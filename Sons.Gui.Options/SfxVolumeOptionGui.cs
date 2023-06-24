using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Serializable]
	public class SfxVolumeOptionGui : FloatOptionGui
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x3052920", Offset = "0x3050F20", VA = "0x183052920", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700007F")]
		public override string SettingKey
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x3052950", Offset = "0x3050F50", VA = "0x183052950", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x3052980", Offset = "0x3050F80", VA = "0x183052980", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x17000080")]
		public override bool ApplyChangesInstantly
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public SfxVolumeOptionGui()
		{
		}

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		private const string LabelText = "SFX Volume";
	}
}

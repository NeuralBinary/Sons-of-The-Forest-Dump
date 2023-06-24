using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[Serializable]
	public class VoiceVolumeOptionGui : FloatOptionGui
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x30535C0", Offset = "0x3051BC0", VA = "0x1830535C0", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700008E")]
		public override string SettingKey
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x30535F0", Offset = "0x3051BF0", VA = "0x1830535F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x3053620", Offset = "0x3051C20", VA = "0x183053620", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x1700008F")]
		public override bool ApplyChangesInstantly
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public VoiceVolumeOptionGui()
		{
		}

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		private const string LabelText = "Voice Volume";
	}
}

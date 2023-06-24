using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[Serializable]
	public class MasterVolumeOptionGui : FloatOptionGui
	{
		// Token: 0x0600012E RID: 302 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x303F060", Offset = "0x303D660", VA = "0x18303F060", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003D")]
		public override string SettingKey
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x303F090", Offset = "0x303D690", VA = "0x18303F090", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x303F0C0", Offset = "0x303D6C0", VA = "0x18303F0C0", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x1700003E")]
		public override bool ApplyChangesInstantly
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public MasterVolumeOptionGui()
		{
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		private const string LabelText = "Master Volume";
	}
}

using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[Serializable]
	public class MusicVolumeOptionGui : FloatOptionGui
	{
		// Token: 0x06000147 RID: 327 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x303F3E0", Offset = "0x303D9E0", VA = "0x18303F3E0", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000044")]
		public override string SettingKey
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x303F410", Offset = "0x303DA10", VA = "0x18303F410", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x303F440", Offset = "0x303DA40", VA = "0x18303F440", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x17000045")]
		public override bool ApplyChangesInstantly
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public MusicVolumeOptionGui()
		{
		}

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		private const string LabelText = "Music Volume";
	}
}

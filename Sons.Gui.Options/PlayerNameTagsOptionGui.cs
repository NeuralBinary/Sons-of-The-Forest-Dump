using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[Serializable]
	public class PlayerNameTagsOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x3051370", Offset = "0x304F970", VA = "0x183051370", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000078")]
		public override string SettingKey
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x30513A0", Offset = "0x304F9A0", VA = "0x1830513A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x30513D0", Offset = "0x304F9D0", VA = "0x1830513D0")]
		public PlayerNameTagsOptionGui()
		{
		}

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		private const string LabelText = "Player Name Tags";
	}
}

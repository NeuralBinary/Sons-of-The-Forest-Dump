using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[Serializable]
	public class GamePadDeadzoneOptionGui : FloatOptionGui
	{
		// Token: 0x060000DC RID: 220 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x303C660", Offset = "0x303AC60", VA = "0x18303C660", Slot = "30")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700002F")]
		public override string SettingKey
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x303C690", Offset = "0x303AC90", VA = "0x18303C690", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x303C6C0", Offset = "0x303ACC0", VA = "0x18303C6C0", Slot = "32")]
		public override float GetDefaultFloatValue()
		{
			return 0f;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x303A050", Offset = "0x3038650", VA = "0x18303A050")]
		public GamePadDeadzoneOptionGui()
		{
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		private const string LabelText = "GamePad Deadzone";
	}
}

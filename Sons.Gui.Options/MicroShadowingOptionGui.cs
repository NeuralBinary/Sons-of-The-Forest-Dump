using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[Serializable]
	public class MicroShadowingOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x06000133 RID: 307 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x303F110", Offset = "0x303D710", VA = "0x18303F110", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003F")]
		public override string SettingKey
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x303F140", Offset = "0x303D740", VA = "0x18303F140", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x303F170", Offset = "0x303D770", VA = "0x18303F170")]
		public MicroShadowingOptionGui()
		{
		}

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		private const string LabelText = "Micro Shadowing";
	}
}

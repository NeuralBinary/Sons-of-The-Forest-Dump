using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[Serializable]
	public class RumbleOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x0600029D RID: 669 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x30527C0", Offset = "0x3050DC0", VA = "0x1830527C0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700007D")]
		public override string SettingKey
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x30527F0", Offset = "0x3050DF0", VA = "0x1830527F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x3052820", Offset = "0x3050E20", VA = "0x183052820")]
		public RumbleOptionGui()
		{
		}

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		private const string LabelText = "Rumble";
	}
}

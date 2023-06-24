using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[Serializable]
	public class FilmGrainOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x303C3C0", Offset = "0x303A9C0", VA = "0x18303C3C0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000029")]
		public override string SettingKey
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x303C3F0", Offset = "0x303A9F0", VA = "0x18303C3F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x303C420", Offset = "0x303AA20", VA = "0x18303C420")]
		public FilmGrainOptionGui()
		{
		}

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		private const string LabelText = "Film Grain";
	}
}

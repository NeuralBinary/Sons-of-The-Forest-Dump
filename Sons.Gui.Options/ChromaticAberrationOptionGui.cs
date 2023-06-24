using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Serializable]
	public class ChromaticAberrationOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x0600003A RID: 58 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x303A110", Offset = "0x3038710", VA = "0x18303A110", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000009")]
		public override string SettingKey
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x303A140", Offset = "0x3038740", VA = "0x18303A140", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x303A170", Offset = "0x3038770", VA = "0x18303A170")]
		public ChromaticAberrationOptionGui()
		{
		}
	}
}

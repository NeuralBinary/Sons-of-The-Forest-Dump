using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Serializable]
	public class CrouchToggleOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x06000053 RID: 83 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x303AAC0", Offset = "0x30390C0", VA = "0x18303AAC0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700000E")]
		public override string SettingKey
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x303AAF0", Offset = "0x30390F0", VA = "0x18303AAF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x303AB20", Offset = "0x3039120", VA = "0x18303AB20")]
		public CrouchToggleOptionGui()
		{
		}

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		private const string LabelText = "Crouch Toggle";
	}
}

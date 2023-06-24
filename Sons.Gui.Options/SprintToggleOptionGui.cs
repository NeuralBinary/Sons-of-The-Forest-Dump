using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[Serializable]
	public class SprintToggleOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x060002B3 RID: 691 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x3052E10", Offset = "0x3051410", VA = "0x183052E10", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000082")]
		public override string SettingKey
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x3052E40", Offset = "0x3051440", VA = "0x183052E40", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x3052E70", Offset = "0x3051470", VA = "0x183052E70")]
		public SprintToggleOptionGui()
		{
		}

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		private const string LabelText = "Sprint Toggle";
	}
}

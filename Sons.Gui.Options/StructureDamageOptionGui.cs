using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[Serializable]
	public class StructureDamageOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x3052EC0", Offset = "0x30514C0", VA = "0x183052EC0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000083")]
		public override string SettingKey
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x3052EF0", Offset = "0x30514F0", VA = "0x183052EF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x3052F20", Offset = "0x3051520", VA = "0x183052F20")]
		public StructureDamageOptionGui()
		{
		}

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		private const string LabelText = "Structure Damage";
	}
}

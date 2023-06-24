using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[Serializable]
	public class TreeRegrowthOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x3053280", Offset = "0x3051880", VA = "0x183053280", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000089")]
		public override string SettingKey
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x30532B0", Offset = "0x30518B0", VA = "0x1830532B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x30532E0", Offset = "0x30518E0", VA = "0x1830532E0")]
		public TreeRegrowthOptionGui()
		{
		}

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		private const string LabelText = "Tree Regrowth";
	}
}

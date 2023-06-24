using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Serializable]
	public class ShadowQualityOptionGui : QualityOptionGui
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x3052DB0", Offset = "0x30513B0", VA = "0x183052DB0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000081")]
		public override string SettingKey
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x3052DE0", Offset = "0x30513E0", VA = "0x183052DE0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public ShadowQualityOptionGui()
		{
		}

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		private const string LabelText = "Shadow Quality";
	}
}

using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[Serializable]
	public class TutorialsGuiOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x3053330", Offset = "0x3051930", VA = "0x183053330", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700008A")]
		public override string SettingKey
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x3053360", Offset = "0x3051960", VA = "0x183053360", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x1700008B")]
		public override bool IsSettingVisible
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x3053390", Offset = "0x3051990", VA = "0x183053390")]
		public TutorialsGuiOptionGui()
		{
		}

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		private const string LabelText = "Tutorials";
	}
}

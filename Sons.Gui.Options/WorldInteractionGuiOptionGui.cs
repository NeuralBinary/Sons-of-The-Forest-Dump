using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	[Serializable]
	public class WorldInteractionGuiOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x3053C90", Offset = "0x3052290", VA = "0x183053C90", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000095")]
		public override string SettingKey
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x3053CC0", Offset = "0x30522C0", VA = "0x183053CC0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x17000096")]
		public override bool IsSettingVisible
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x3053CF0", Offset = "0x30522F0", VA = "0x183053CF0")]
		public WorldInteractionGuiOptionGui()
		{
		}

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		private const string LabelText = "World Interaction";
	}
}

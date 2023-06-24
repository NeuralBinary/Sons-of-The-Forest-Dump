using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[Serializable]
	public class ScreenSpaceReflectionOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x3052870", Offset = "0x3050E70", VA = "0x183052870", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700007E")]
		public override string SettingKey
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x30528A0", Offset = "0x3050EA0", VA = "0x1830528A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x30528D0", Offset = "0x3050ED0", VA = "0x1830528D0")]
		public ScreenSpaceReflectionOptionGui()
		{
		}

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		private const string LabelText = "Screen Space Reflection";
	}
}

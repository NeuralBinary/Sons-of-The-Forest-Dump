using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[Serializable]
	public class TakeAndUseOptionGui : InputOptionGui
	{
		// Token: 0x060002BB RID: 699 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x3052F70", Offset = "0x3051570", VA = "0x183052F70", Slot = "31")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000084")]
		public override string SettingKey
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x3052FA0", Offset = "0x30515A0", VA = "0x183052FA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x3052FD0", Offset = "0x30515D0", VA = "0x183052FD0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x303E000", Offset = "0x303C600", VA = "0x18303E000")]
		public TakeAndUseOptionGui()
		{
		}

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		private const string LabelText = "Take / Use";
	}
}

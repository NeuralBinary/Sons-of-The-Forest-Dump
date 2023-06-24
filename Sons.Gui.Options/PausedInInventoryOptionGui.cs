using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[Serializable]
	public class PausedInInventoryOptionGui : ToggleMenuGameSettingGui
	{
		// Token: 0x06000083 RID: 131 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x303B4D0", Offset = "0x3039AD0", VA = "0x18303B4D0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000018")]
		public override string SettingKey
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x303B500", Offset = "0x3039B00", VA = "0x18303B500", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x303B480", Offset = "0x3039A80", VA = "0x18303B480")]
		public PausedInInventoryOptionGui()
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		private const string LabelText = "Paused In Inventory";
	}
}

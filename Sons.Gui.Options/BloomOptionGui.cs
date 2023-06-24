using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[Serializable]
	public class BloomOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3039EF0", Offset = "0x30384F0", VA = "0x183039EF0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000006")]
		public override string SettingKey
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x3039F20", Offset = "0x3038520", VA = "0x183039F20", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3039F50", Offset = "0x3038550", VA = "0x183039F50")]
		public BloomOptionGui()
		{
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		private const string LabelText = "Bloom";
	}
}

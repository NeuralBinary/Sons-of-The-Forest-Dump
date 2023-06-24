using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[Serializable]
	public class CloudTypeOptionGui : CustomMenuOptionGui
	{
		// Token: 0x0600003E RID: 62 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x303A1C0", Offset = "0x30387C0", VA = "0x18303A1C0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700000A")]
		public override string SettingKey
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x303A1F0", Offset = "0x30387F0", VA = "0x18303A1F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x303A220", Offset = "0x3038820", VA = "0x18303A220", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x303A250", Offset = "0x3038850", VA = "0x18303A250", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x303A2A0", Offset = "0x30388A0", VA = "0x18303A2A0", Slot = "37")]
		public override int GetValueIndexFallback(string value)
		{
			return 0;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public CloudTypeOptionGui()
		{
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		private const string LabelText = "Clouds";
	}
}

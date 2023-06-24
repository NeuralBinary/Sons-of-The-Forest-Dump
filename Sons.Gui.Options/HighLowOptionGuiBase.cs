using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class HighLowOptionGuiBase : CustomMenuOptionGui
	{
		// Token: 0x06000104 RID: 260 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x303D960", Offset = "0x303BF60", VA = "0x18303D960", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x303D9B0", Offset = "0x303BFB0", VA = "0x18303D9B0", Slot = "37")]
		public override int GetValueIndexFallback(string value)
		{
			return 0;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public HighLowOptionGuiBase()
		{
		}
	}
}

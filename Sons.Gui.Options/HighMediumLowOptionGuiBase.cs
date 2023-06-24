using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class HighMediumLowOptionGuiBase : CustomMenuOptionGui
	{
		// Token: 0x06000107 RID: 263 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x303DB60", Offset = "0x303C160", VA = "0x18303DB60", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x303DBB0", Offset = "0x303C1B0", VA = "0x18303DBB0", Slot = "37")]
		public override int GetValueIndexFallback(string value)
		{
			return 0;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public HighMediumLowOptionGuiBase()
		{
		}
	}
}

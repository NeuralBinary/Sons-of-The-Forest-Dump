using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class HighLowOffOptionGuiBase : CustomMenuOptionGui
	{
		// Token: 0x06000101 RID: 257 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x303D740", Offset = "0x303BD40", VA = "0x18303D740", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x303D790", Offset = "0x303BD90", VA = "0x18303D790", Slot = "37")]
		public override int GetValueIndexFallback(string value)
		{
			return 0;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public HighLowOffOptionGuiBase()
		{
		}
	}
}

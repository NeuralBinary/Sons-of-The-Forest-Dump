using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class OnOffOptionGuiBase : CustomMenuOptionGui
	{
		// Token: 0x0600014C RID: 332 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x303F490", Offset = "0x303DA90", VA = "0x18303F490", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x303F4E0", Offset = "0x303DAE0", VA = "0x18303F4E0", Slot = "37")]
		public override int GetValueIndexFallback(string value)
		{
			return 0;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public OnOffOptionGuiBase()
		{
		}
	}
}

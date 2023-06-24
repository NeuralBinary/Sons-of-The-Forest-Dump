using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public abstract class QualityOptionGui : CustomMenuOptionGui
	{
		// Token: 0x06000286 RID: 646 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x30514D0", Offset = "0x304FAD0", VA = "0x1830514D0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x3051500", Offset = "0x304FB00", VA = "0x183051500", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		protected QualityOptionGui()
		{
		}
	}
}

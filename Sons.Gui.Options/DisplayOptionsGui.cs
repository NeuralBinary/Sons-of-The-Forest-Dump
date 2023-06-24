using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Options
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[AddComponentMenu("Sons/Gui/Options/DisplayOptionsGui")]
	public class DisplayOptionsGui : OptionsGui
	{
		// Token: 0x06000168 RID: 360 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x3042730", Offset = "0x3040D30", VA = "0x183042730", Slot = "4")]
		public override MenuOptionGui[] GetMenuOptionsOrder()
		{
			return null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x303F930", Offset = "0x303DF30", VA = "0x18303F930")]
		public DisplayOptionsGui()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Options
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[AddComponentMenu("Sons/Gui/Options/GameplayOptionsGui")]
	public class GameplayOptionsGui : OptionsGui
	{
		// Token: 0x0600016A RID: 362 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x30429D0", Offset = "0x3040FD0", VA = "0x1830429D0", Slot = "4")]
		public override MenuOptionGui[] GetMenuOptionsOrder()
		{
			return null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x303F930", Offset = "0x303DF30", VA = "0x18303F930")]
		public GameplayOptionsGui()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Options
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[AddComponentMenu("Sons/Gui/Options/AudioOptionsGui")]
	public class AudioOptionsGui : OptionsGui
	{
		// Token: 0x0600014F RID: 335 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x303F690", Offset = "0x303DC90", VA = "0x18303F690", Slot = "4")]
		public override MenuOptionGui[] GetMenuOptionsOrder()
		{
			return null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x303F930", Offset = "0x303DF30", VA = "0x18303F930")]
		public AudioOptionsGui()
		{
		}
	}
}

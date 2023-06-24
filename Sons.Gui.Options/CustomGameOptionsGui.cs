using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Options
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[AddComponentMenu("Sons/Gui/Options/CustomGameOptionsGui")]
	public class CustomGameOptionsGui : OptionsGui
	{
		// Token: 0x06000160 RID: 352 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x3041800", Offset = "0x303FE00", VA = "0x183041800", Slot = "4")]
		public override MenuOptionGui[] GetMenuOptionsOrder()
		{
			return null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x303F930", Offset = "0x303DF30", VA = "0x18303F930")]
		public CustomGameOptionsGui()
		{
		}
	}
}

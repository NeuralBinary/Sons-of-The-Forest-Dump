using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Options
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[AddComponentMenu("Sons/Gui/Options/GraphicsOptionsGui")]
	public class GraphicsOptionsGui : OptionsGui
	{
		// Token: 0x0600016C RID: 364 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x30431F0", Offset = "0x30417F0", VA = "0x1830431F0", Slot = "4")]
		public override MenuOptionGui[] GetMenuOptionsOrder()
		{
			return null;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x3043D40", Offset = "0x3042340", VA = "0x183043D40", Slot = "5")]
		internal override void OnPreEnable()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x3044240", Offset = "0x3042840", VA = "0x183044240", Slot = "9")]
		internal override void OnPostUpdate()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x303F930", Offset = "0x303DF30", VA = "0x18303F930")]
		public GraphicsOptionsGui()
		{
		}
	}
}

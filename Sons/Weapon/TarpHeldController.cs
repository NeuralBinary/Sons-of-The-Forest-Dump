using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008E3 RID: 2275
	[Token(Token = "0x20008E3")]
	[AddComponentMenu("Sons/Weapon/Tarp Held Controller")]
	public class TarpHeldController : HeldControllerBase
	{
		// Token: 0x06004110 RID: 16656 RVA: 0x00013E48 File Offset: 0x00012048
		[Token(Token = "0x6004110")]
		[Address(RVA = "0x3609C10", Offset = "0x3608210", VA = "0x183609C10", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004111")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TarpHeldController()
		{
		}
	}
}

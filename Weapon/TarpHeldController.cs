using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000872 RID: 2162
	[Token(Token = "0x2000872")]
	[AddComponentMenu("Sons/Weapon/Tarp Held Controller")]
	public class TarpHeldController : HeldControllerBase
	{
		// Token: 0x060039E9 RID: 14825 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		[Token(Token = "0x60039E9")]
		[Address(RVA = "0x2F076C0", Offset = "0x2F066C0", VA = "0x182F076C0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EA")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public TarpHeldController()
		{
		}
	}
}

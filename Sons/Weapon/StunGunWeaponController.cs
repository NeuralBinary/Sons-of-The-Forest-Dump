using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008E1 RID: 2273
	[Token(Token = "0x20008E1")]
	[AddComponentMenu("Sons/Weapon/StunGunWeaponController")]
	public class StunGunWeaponController : RangedWeaponController
	{
		// Token: 0x0600410A RID: 16650 RVA: 0x00013E00 File Offset: 0x00012000
		[Token(Token = "0x600410A")]
		[Address(RVA = "0x3609850", Offset = "0x3607E50", VA = "0x183609850", Slot = "26")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x00013E18 File Offset: 0x00012018
		[Token(Token = "0x600410B")]
		[Address(RVA = "0x36098C0", Offset = "0x3607EC0", VA = "0x1836098C0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410C")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public StunGunWeaponController()
		{
		}
	}
}

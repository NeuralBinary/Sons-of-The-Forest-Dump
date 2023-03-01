using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200083A RID: 2106
	[Token(Token = "0x200083A")]
	[AddComponentMenu("Sons/Items/CrossbowWeaponController")]
	public class CrossbowWeaponController : RangedWeaponController
	{
		// Token: 0x06003827 RID: 14375 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[Token(Token = "0x6003827")]
		[Address(RVA = "0x2EC62E0", Offset = "0x2EC52E0", VA = "0x182EC62E0", Slot = "25")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00010710 File Offset: 0x0000E910
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x2EC61D0", Offset = "0x2EC51D0", VA = "0x182EC61D0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003829")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public CrossbowWeaponController()
		{
		}
	}
}

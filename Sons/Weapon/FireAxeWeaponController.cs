using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008AD RID: 2221
	[Token(Token = "0x20008AD")]
	[AddComponentMenu("Sons/Weapon/Fire Axe Weapon Controller")]
	public class FireAxeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06003F4A RID: 16202 RVA: 0x00013500 File Offset: 0x00011700
		[Token(Token = "0x6003F4A")]
		[Address(RVA = "0x35E2650", Offset = "0x35E0C50", VA = "0x1835E2650", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4B")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public FireAxeWeaponController()
		{
		}
	}
}

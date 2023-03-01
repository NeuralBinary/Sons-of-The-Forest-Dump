using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200083D RID: 2109
	[Token(Token = "0x200083D")]
	[AddComponentMenu("Sons/Weapon/Fire Axe Weapon Controller")]
	public class FireAxeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06003835 RID: 14389 RVA: 0x00010758 File Offset: 0x0000E958
		[Token(Token = "0x6003835")]
		[Address(RVA = "0x2EC6580", Offset = "0x2EC5580", VA = "0x182EC6580", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003836")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public FireAxeWeaponController()
		{
		}
	}
}

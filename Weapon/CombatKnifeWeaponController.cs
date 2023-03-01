using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000837 RID: 2103
	[Token(Token = "0x2000837")]
	[AddComponentMenu("Sons/Weapon/CombatKnifeWeaponController")]
	public class CombatKnifeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x0600381B RID: 14363 RVA: 0x00010650 File Offset: 0x0000E850
		[Token(Token = "0x600381B")]
		[Address(RVA = "0x2EB59A0", Offset = "0x2EB49A0", VA = "0x182EB59A0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381C")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public CombatKnifeWeaponController()
		{
		}
	}
}

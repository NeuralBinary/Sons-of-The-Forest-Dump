using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000857 RID: 2135
	[Token(Token = "0x2000857")]
	[AddComponentMenu("Sons/Weapon/ModernAxeWeaponController")]
	public class ModernAxeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06003914 RID: 14612 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		[Token(Token = "0x6003914")]
		[Address(RVA = "0x2ED28A0", Offset = "0x2ED18A0", VA = "0x182ED28A0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003915")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public ModernAxeWeaponController()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200086F RID: 2159
	[Token(Token = "0x200086F")]
	[AddComponentMenu("Sons/Weapon/StickWeaponController")]
	public class StickWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x060039E1 RID: 14817 RVA: 0x00010F50 File Offset: 0x0000F150
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x2F072A0", Offset = "0x2F062A0", VA = "0x182F072A0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E2")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public StickWeaponController()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000836 RID: 2102
	[Token(Token = "0x2000836")]
	[AddComponentMenu("Sons/Weapon/Club Weapon Controller")]
	public class ClubWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06003819 RID: 14361 RVA: 0x00010638 File Offset: 0x0000E838
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x2EB5890", Offset = "0x2EB4890", VA = "0x182EB5890", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381A")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public ClubWeaponController()
		{
		}
	}
}

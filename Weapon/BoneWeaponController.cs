using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000832 RID: 2098
	[Token(Token = "0x2000832")]
	[AddComponentMenu("Sons/Weapon/BoneWeaponController")]
	public class BoneWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x060037E8 RID: 14312 RVA: 0x000104E8 File Offset: 0x0000E6E8
		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x2EAE550", Offset = "0x2EAD550", VA = "0x182EAE550", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E9")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public BoneWeaponController()
		{
		}
	}
}

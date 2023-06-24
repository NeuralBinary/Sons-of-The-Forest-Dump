using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008A6 RID: 2214
	[Token(Token = "0x20008A6")]
	[AddComponentMenu("Sons/Weapon/Club Weapon Controller")]
	public class ClubWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06003F2A RID: 16170 RVA: 0x00013398 File Offset: 0x00011598
		[Token(Token = "0x6003F2A")]
		[Address(RVA = "0x35E0710", Offset = "0x35DED10", VA = "0x1835E0710", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2B")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public ClubWeaponController()
		{
		}
	}
}

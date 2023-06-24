using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008A7 RID: 2215
	[Token(Token = "0x20008A7")]
	[AddComponentMenu("Sons/Weapon/CombatKnifeWeaponController")]
	public class CombatKnifeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06003F2C RID: 16172 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x35E0870", Offset = "0x35DEE70", VA = "0x1835E0870", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2D")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public CombatKnifeWeaponController()
		{
		}
	}
}

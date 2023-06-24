using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008C7 RID: 2247
	[Token(Token = "0x20008C7")]
	[AddComponentMenu("Sons/Weapon/ModernAxeWeaponController")]
	public class ModernAxeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06004030 RID: 16432 RVA: 0x000139E0 File Offset: 0x00011BE0
		[Token(Token = "0x6004030")]
		[Address(RVA = "0x35F5BD0", Offset = "0x35F41D0", VA = "0x1835F5BD0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004031")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public ModernAxeWeaponController()
		{
		}
	}
}

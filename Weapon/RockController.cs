using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000863 RID: 2147
	[Token(Token = "0x2000863")]
	[AddComponentMenu("Sons/Weapon/RockController")]
	public class RockController : GenericMeleeWeaponController
	{
		// Token: 0x0600397B RID: 14715 RVA: 0x00010D88 File Offset: 0x0000EF88
		[Token(Token = "0x600397B")]
		[Address(RVA = "0x2ED99A0", Offset = "0x2ED89A0", VA = "0x182ED99A0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public RockController()
		{
		}
	}
}

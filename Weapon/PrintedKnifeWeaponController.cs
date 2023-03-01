using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200085A RID: 2138
	[Token(Token = "0x200085A")]
	[AddComponentMenu("Sons/Weapon/PrintedKnifeWeaponController")]
	public class PrintedKnifeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x0600392E RID: 14638 RVA: 0x00010C38 File Offset: 0x0000EE38
		[Token(Token = "0x600392E")]
		[Address(RVA = "0x2ED44E0", Offset = "0x2ED34E0", VA = "0x182ED44E0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392F")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public PrintedKnifeWeaponController()
		{
		}
	}
}

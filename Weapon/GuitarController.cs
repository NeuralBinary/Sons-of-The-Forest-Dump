using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200084C RID: 2124
	[Token(Token = "0x200084C")]
	[AddComponentMenu("Sons/Weapon/GuitarController")]
	public class GuitarController : GenericMeleeWeaponController
	{
		// Token: 0x060038BF RID: 14527 RVA: 0x000109E0 File Offset: 0x0000EBE0
		[Token(Token = "0x60038BF")]
		[Address(RVA = "0x2ECEE90", Offset = "0x2ECDE90", VA = "0x182ECEE90", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C0")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public GuitarController()
		{
		}
	}
}

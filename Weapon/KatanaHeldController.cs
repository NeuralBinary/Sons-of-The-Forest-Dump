using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000851 RID: 2129
	[Token(Token = "0x2000851")]
	[AddComponentMenu("Sons/Weapon/KatanaHeldController")]
	public class KatanaHeldController : GenericMeleeWeaponController
	{
		// Token: 0x060038E1 RID: 14561 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		[Token(Token = "0x60038E1")]
		[Address(RVA = "0x2ECFBF0", Offset = "0x2ECEBF0", VA = "0x182ECFBF0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E2")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public KatanaHeldController()
		{
		}
	}
}

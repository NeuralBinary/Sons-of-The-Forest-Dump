using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000854 RID: 2132
	[Token(Token = "0x2000854")]
	[AddComponentMenu("Sons/Weapon/Machete Weapon Controller")]
	public class MacheteWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x060038E9 RID: 14569 RVA: 0x00010B18 File Offset: 0x0000ED18
		[Token(Token = "0x60038E9")]
		[Address(RVA = "0x2ECFE50", Offset = "0x2ECEE50", VA = "0x182ECFE50", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EA")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public MacheteWeaponController()
		{
		}
	}
}

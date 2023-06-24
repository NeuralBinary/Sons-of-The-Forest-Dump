using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008C4 RID: 2244
	[Token(Token = "0x20008C4")]
	[AddComponentMenu("Sons/Weapon/Machete Weapon Controller")]
	public class MacheteWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06004003 RID: 16387 RVA: 0x000138F0 File Offset: 0x00011AF0
		[Token(Token = "0x6004003")]
		[Address(RVA = "0x35F1BB0", Offset = "0x35F01B0", VA = "0x1835F1BB0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004004")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public MacheteWeaponController()
		{
		}
	}
}

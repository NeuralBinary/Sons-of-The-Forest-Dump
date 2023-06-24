using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008E0 RID: 2272
	[Token(Token = "0x20008E0")]
	[AddComponentMenu("Sons/Weapon/StickWeaponController")]
	public class StickWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06004108 RID: 16648 RVA: 0x00013DE8 File Offset: 0x00011FE8
		[Token(Token = "0x6004108")]
		[Address(RVA = "0x36097A0", Offset = "0x3607DA0", VA = "0x1836097A0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004109")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public StickWeaponController()
		{
		}
	}
}

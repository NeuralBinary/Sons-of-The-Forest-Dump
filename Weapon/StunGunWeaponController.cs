using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000870 RID: 2160
	[Token(Token = "0x2000870")]
	[AddComponentMenu("Sons/Weapon/StunGunWeaponController")]
	public class StunGunWeaponController : RangedWeaponController
	{
		// Token: 0x060039E3 RID: 14819 RVA: 0x00010F68 File Offset: 0x0000F168
		[Token(Token = "0x60039E3")]
		[Address(RVA = "0x2F07410", Offset = "0x2F06410", VA = "0x182F07410", Slot = "25")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00010F80 File Offset: 0x0000F180
		[Token(Token = "0x60039E4")]
		[Address(RVA = "0x2F07360", Offset = "0x2F06360", VA = "0x182F07360", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E5")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public StunGunWeaponController()
		{
		}
	}
}

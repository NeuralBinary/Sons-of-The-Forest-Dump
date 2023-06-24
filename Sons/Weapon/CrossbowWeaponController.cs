using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008AA RID: 2218
	[Token(Token = "0x20008AA")]
	[AddComponentMenu("Sons/Items/CrossbowWeaponController")]
	public class CrossbowWeaponController : RangedWeaponController
	{
		// Token: 0x06003F39 RID: 16185 RVA: 0x00013470 File Offset: 0x00011670
		[Token(Token = "0x6003F39")]
		[Address(RVA = "0x35E14C0", Offset = "0x35DFAC0", VA = "0x1835E14C0", Slot = "26")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x00013488 File Offset: 0x00011688
		[Token(Token = "0x6003F3A")]
		[Address(RVA = "0x35E1560", Offset = "0x35DFB60", VA = "0x1835E1560", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x000134A0 File Offset: 0x000116A0
		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x35E16F0", Offset = "0x35DFCF0", VA = "0x1835E16F0", Slot = "24")]
		protected override bool CanAim()
		{
			return default(bool);
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x000134B8 File Offset: 0x000116B8
		[Token(Token = "0x6003F3C")]
		[Address(RVA = "0x35E13D0", Offset = "0x35DF9D0", VA = "0x1835E13D0", Slot = "35")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3D")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public CrossbowWeaponController()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008A8 RID: 2216
	[Token(Token = "0x20008A8")]
	[AddComponentMenu("Sons/Weapon/CompactPistolWeaponController")]
	public class CompactPistolWeaponController : RangedWeaponController
	{
		// Token: 0x06003F2E RID: 16174 RVA: 0x000133C8 File Offset: 0x000115C8
		[Token(Token = "0x6003F2E")]
		[Address(RVA = "0x35E0920", Offset = "0x35DEF20", VA = "0x1835E0920", Slot = "10")]
		internal override bool ShouldShowMuzzleFlash()
		{
			return default(bool);
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x000133E0 File Offset: 0x000115E0
		[Token(Token = "0x6003F2F")]
		[Address(RVA = "0x35E0940", Offset = "0x35DEF40", VA = "0x1835E0940")]
		private bool HasSuppressor()
		{
			return default(bool);
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x35E0A30", Offset = "0x35DF030", VA = "0x1835E0A30", Slot = "18")]
		protected override void PlayFireAnimNetwork()
		{
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x000133F8 File Offset: 0x000115F8
		[Token(Token = "0x6003F31")]
		[Address(RVA = "0x35E0B90", Offset = "0x35DF190", VA = "0x1835E0B90", Slot = "26")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x00013410 File Offset: 0x00011610
		[Token(Token = "0x6003F32")]
		[Address(RVA = "0x35E0C00", Offset = "0x35DF200", VA = "0x1835E0C00", Slot = "24")]
		protected override bool CanAim()
		{
			return default(bool);
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00013428 File Offset: 0x00011628
		[Token(Token = "0x6003F33")]
		[Address(RVA = "0x35E0EF0", Offset = "0x35DF4F0", VA = "0x1835E0EF0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x35E1140", Offset = "0x35DF740", VA = "0x1835E1140", Slot = "28")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x00013440 File Offset: 0x00011640
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x35E13D0", Offset = "0x35DF9D0", VA = "0x1835E13D0", Slot = "35")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public CompactPistolWeaponController()
		{
		}
	}
}

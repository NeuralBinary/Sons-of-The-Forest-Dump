using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008D2 RID: 2258
	[Token(Token = "0x20008D2")]
	[AddComponentMenu("Sons/Weapon/RifleAnimatorController")]
	public class RifleAnimatorController : RangedWeaponController
	{
		// Token: 0x06004097 RID: 16535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004097")]
		[Address(RVA = "0x36003F0", Offset = "0x35FE9F0", VA = "0x1836003F0", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004098")]
		[Address(RVA = "0x36005D0", Offset = "0x35FEBD0", VA = "0x1836005D0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00013B90 File Offset: 0x00011D90
		[Token(Token = "0x6004099")]
		[Address(RVA = "0x36006B0", Offset = "0x35FECB0", VA = "0x1836006B0", Slot = "26")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x00013BA8 File Offset: 0x00011DA8
		[Token(Token = "0x600409A")]
		[Address(RVA = "0x3600820", Offset = "0x35FEE20", VA = "0x183600820", Slot = "24")]
		protected override bool CanAim()
		{
			return default(bool);
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00013BC0 File Offset: 0x00011DC0
		[Token(Token = "0x600409B")]
		[Address(RVA = "0x3600A50", Offset = "0x35FF050", VA = "0x183600A50", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00013BD8 File Offset: 0x00011DD8
		[Token(Token = "0x600409C")]
		[Address(RVA = "0x35E13D0", Offset = "0x35DF9D0", VA = "0x1835E13D0", Slot = "35")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409D")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public RifleAnimatorController()
		{
		}
	}
}

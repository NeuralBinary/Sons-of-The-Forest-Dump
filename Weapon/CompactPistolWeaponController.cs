using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000838 RID: 2104
	[Token(Token = "0x2000838")]
	[AddComponentMenu("Sons/Weapon/CompactPistolWeaponController")]
	public class CompactPistolWeaponController : RangedWeaponController
	{
		// Token: 0x0600381D RID: 14365 RVA: 0x00010668 File Offset: 0x0000E868
		[Token(Token = "0x600381D")]
		[Address(RVA = "0x2EB5F50", Offset = "0x2EB4F50", VA = "0x182EB5F50", Slot = "10")]
		internal override bool ShouldShowMuzzleFlash()
		{
			return default(bool);
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00010680 File Offset: 0x0000E880
		[Token(Token = "0x600381E")]
		[Address(RVA = "0x2EB5A60", Offset = "0x2EB4A60", VA = "0x182EB5A60")]
		private bool HasSuppressor()
		{
			return default(bool);
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381F")]
		[Address(RVA = "0x2EB5E20", Offset = "0x2EB4E20", VA = "0x182EB5E20", Slot = "18")]
		protected override void PlayFireAnimNetwork()
		{
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x00010698 File Offset: 0x0000E898
		[Token(Token = "0x6003820")]
		[Address(RVA = "0x2EB5DA0", Offset = "0x2EB4DA0", VA = "0x182EB5DA0", Slot = "25")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x000106B0 File Offset: 0x0000E8B0
		[Token(Token = "0x6003821")]
		[Address(RVA = "0x2EB5B20", Offset = "0x2EB4B20", VA = "0x182EB5B20", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003822")]
		[Address(RVA = "0x2EB5F80", Offset = "0x2EB4F80", VA = "0x182EB5F80", Slot = "27")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x000106C8 File Offset: 0x0000E8C8
		[Token(Token = "0x6003823")]
		[Address(RVA = "0x2EB5AF0", Offset = "0x2EB4AF0", VA = "0x182EB5AF0", Slot = "34")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003824")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public CompactPistolWeaponController()
		{
		}
	}
}

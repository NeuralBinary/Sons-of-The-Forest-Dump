using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200084B RID: 2123
	[Token(Token = "0x200084B")]
	[AddComponentMenu("Sons/Weapon/GrenadeWeaponController")]
	public class GrenadeWeaponController : RangedWeaponController
	{
		// Token: 0x060038B7 RID: 14519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B7")]
		[Address(RVA = "0x2EC6AE0", Offset = "0x2EC5AE0", VA = "0x182EC6AE0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, int itemId)
		{
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B8")]
		[Address(RVA = "0x2EC6A60", Offset = "0x2EC5A60", VA = "0x182EC6A60", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B9")]
		[Address(RVA = "0x2ECED80", Offset = "0x2ECDD80", VA = "0x182ECED80", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038BA")]
		[Address(RVA = "0x2ECEAF0", Offset = "0x2ECDAF0", VA = "0x182ECEAF0", Slot = "33")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038BB")]
		[Address(RVA = "0x2ECE9D0", Offset = "0x2ECD9D0", VA = "0x182ECE9D0", Slot = "32")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x000109C8 File Offset: 0x0000EBC8
		[Token(Token = "0x60038BC")]
		[Address(RVA = "0x2ECEA20", Offset = "0x2ECDA20", VA = "0x182ECEA20", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038BD")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "27")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038BE")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public GrenadeWeaponController()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200086C RID: 2156
	[Token(Token = "0x200086C")]
	[AddComponentMenu("Sons/Weapon/SmallRockWeaponController")]
	public class SmallRockWeaponController : RangedWeaponController
	{
		// Token: 0x060039C1 RID: 14785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C1")]
		[Address(RVA = "0x2EC6AE0", Offset = "0x2EC5AE0", VA = "0x182EC6AE0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, int itemId)
		{
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x2EC6A60", Offset = "0x2EC5A60", VA = "0x182EC6A60", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x2F05B40", Offset = "0x2F04B40", VA = "0x182F05B40", Slot = "33")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C4")]
		[Address(RVA = "0x2F05A70", Offset = "0x2F04A70", VA = "0x182F05A70", Slot = "32")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		[Token(Token = "0x60039C5")]
		[Address(RVA = "0x2F05AC0", Offset = "0x2F04AC0", VA = "0x182F05AC0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C6")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "27")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public SmallRockWeaponController()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000876 RID: 2166
	[Token(Token = "0x2000876")]
	[AddComponentMenu("Sons/Weapon/Time Bomb Controller")]
	public class TimeBombWeaponController : RangedWeaponController
	{
		// Token: 0x060039FC RID: 14844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039FC")]
		[Address(RVA = "0x2EC6AE0", Offset = "0x2EC5AE0", VA = "0x182EC6AE0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, int itemId)
		{
		}

		// Token: 0x060039FD RID: 14845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039FD")]
		[Address(RVA = "0x2EC6A60", Offset = "0x2EC5A60", VA = "0x182EC6A60", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039FE")]
		[Address(RVA = "0x2F08650", Offset = "0x2F07650", VA = "0x182F08650", Slot = "33")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039FF")]
		[Address(RVA = "0x2F05A70", Offset = "0x2F04A70", VA = "0x182F05A70", Slot = "32")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x00011010 File Offset: 0x0000F210
		[Token(Token = "0x6003A00")]
		[Address(RVA = "0x2F085B0", Offset = "0x2F075B0", VA = "0x182F085B0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A01")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "27")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A02")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public TimeBombWeaponController()
		{
		}
	}
}

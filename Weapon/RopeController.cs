using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000864 RID: 2148
	[Token(Token = "0x2000864")]
	[AddComponentMenu("Sons/Items/RopeController")]
	public class RopeController : HeldControllerBase
	{
		// Token: 0x0600397D RID: 14717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397D")]
		[Address(RVA = "0x2EC6390", Offset = "0x2EC5390", VA = "0x182EC6390", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x2ED9A80", Offset = "0x2ED8A80", VA = "0x182ED9A80", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public RopeController()
		{
		}
	}
}

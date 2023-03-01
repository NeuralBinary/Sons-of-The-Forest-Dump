using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000853 RID: 2131
	[Token(Token = "0x2000853")]
	[AddComponentMenu("Sons/Items/LeafController")]
	public class LeafController : HeldControllerBase
	{
		// Token: 0x060038E6 RID: 14566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E6")]
		[Address(RVA = "0x2EC6390", Offset = "0x2EC5390", VA = "0x182EC6390", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x00010B00 File Offset: 0x0000ED00
		[Token(Token = "0x60038E7")]
		[Address(RVA = "0x2ECFD80", Offset = "0x2ECED80", VA = "0x182ECFD80", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E8")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public LeafController()
		{
		}
	}
}

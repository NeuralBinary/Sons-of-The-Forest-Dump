using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008EF RID: 2287
	[Token(Token = "0x20008EF")]
	[AddComponentMenu("Sons/Items/TutorialPageController")]
	public class TutorialPageController : HeldControllerBase
	{
		// Token: 0x0600415E RID: 16734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600415E")]
		[Address(RVA = "0x35E2590", Offset = "0x35E0B90", VA = "0x1835E2590", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x00013F50 File Offset: 0x00012150
		[Token(Token = "0x600415F")]
		[Address(RVA = "0x3610660", Offset = "0x360EC60", VA = "0x183610660", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004160")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TutorialPageController()
		{
		}
	}
}

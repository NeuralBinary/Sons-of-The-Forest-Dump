using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Items
{
	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	[AddComponentMenu("Sons/Items/StoryItemController")]
	public class StoryItemController : HeldControllerBase
	{
		// Token: 0x0600379C RID: 14236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379C")]
		[Address(RVA = "0x2EB8780", Offset = "0x2EB7780", VA = "0x182EB8780", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00010428 File Offset: 0x0000E628
		[Token(Token = "0x600379D")]
		[Address(RVA = "0x2EB9D40", Offset = "0x2EB8D40", VA = "0x182EB9D40", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379E")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public StoryItemController()
		{
		}
	}
}

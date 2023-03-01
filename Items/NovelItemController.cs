using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Items
{
	// Token: 0x02000829 RID: 2089
	[Token(Token = "0x2000829")]
	[AddComponentMenu("Sons/Items/NovelItemController")]
	public class NovelItemController : HeldControllerBase
	{
		// Token: 0x06003799 RID: 14233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003799")]
		[Address(RVA = "0x2EB8780", Offset = "0x2EB7780", VA = "0x182EB8780", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00010410 File Offset: 0x0000E610
		[Token(Token = "0x600379A")]
		[Address(RVA = "0x2EB87E0", Offset = "0x2EB77E0", VA = "0x182EB87E0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379B")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public NovelItemController()
		{
		}
	}
}

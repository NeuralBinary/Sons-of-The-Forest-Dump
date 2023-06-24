using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Items
{
	// Token: 0x0200073C RID: 1852
	[Token(Token = "0x200073C")]
	[AddComponentMenu("Sons/Items/NovelItemController")]
	public class NovelItemController : HeldControllerBase
	{
		// Token: 0x0600317D RID: 12669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317D")]
		[Address(RVA = "0x348C190", Offset = "0x348A790", VA = "0x18348C190", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x0000F048 File Offset: 0x0000D248
		[Token(Token = "0x600317E")]
		[Address(RVA = "0x348C1F0", Offset = "0x348A7F0", VA = "0x18348C1F0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public NovelItemController()
		{
		}
	}
}

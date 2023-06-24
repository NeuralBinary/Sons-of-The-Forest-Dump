using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Items
{
	// Token: 0x0200073D RID: 1853
	[Token(Token = "0x200073D")]
	[AddComponentMenu("Sons/Items/StoryItemController")]
	public class StoryItemController : HeldControllerBase
	{
		// Token: 0x06003180 RID: 12672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003180")]
		[Address(RVA = "0x348C190", Offset = "0x348A790", VA = "0x18348C190", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0000F060 File Offset: 0x0000D260
		[Token(Token = "0x6003181")]
		[Address(RVA = "0x348C260", Offset = "0x348A860", VA = "0x18348C260", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003182")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public StoryItemController()
		{
		}
	}
}

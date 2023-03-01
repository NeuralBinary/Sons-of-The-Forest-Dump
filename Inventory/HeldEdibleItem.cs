using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005EC RID: 1516
	[Token(Token = "0x20005EC")]
	[AddComponentMenu("Sons/Items/HeldEdibleItem")]
	public class HeldEdibleItem : HeldControllerBase
	{
		// Token: 0x060026D5 RID: 9941 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x2D93A80", Offset = "0x2D92A80", VA = "0x182D93A80")]
		private bool IsInInventory()
		{
			return default(bool);
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0x2D937D0", Offset = "0x2D927D0", VA = "0x182D937D0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x2D93AC0", Offset = "0x2D92AC0", VA = "0x182D93AC0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public HeldEdibleItem()
		{
		}
	}
}

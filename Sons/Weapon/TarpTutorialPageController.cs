using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008E4 RID: 2276
	[Token(Token = "0x20008E4")]
	[AddComponentMenu("Sons/Items/TarpTutorialPageController")]
	public class TarpTutorialPageController : HeldControllerBase
	{
		// Token: 0x06004112 RID: 16658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004112")]
		[Address(RVA = "0x3609D30", Offset = "0x3608330", VA = "0x183609D30", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004113")]
		[Address(RVA = "0x3609F10", Offset = "0x3608510", VA = "0x183609F10")]
		private void Update()
		{
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x00013E60 File Offset: 0x00012060
		[Token(Token = "0x6004114")]
		[Address(RVA = "0x3609F90", Offset = "0x3608590", VA = "0x183609F90", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004115")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TarpTutorialPageController()
		{
		}
	}
}

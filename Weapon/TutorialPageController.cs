using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200087D RID: 2173
	[Token(Token = "0x200087D")]
	[AddComponentMenu("Sons/Items/TutorialPageController")]
	public class TutorialPageController : HeldControllerBase
	{
		// Token: 0x06003A36 RID: 14902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A36")]
		[Address(RVA = "0x2EC6390", Offset = "0x2EC5390", VA = "0x182EC6390", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x000110B8 File Offset: 0x0000F2B8
		[Token(Token = "0x6003A37")]
		[Address(RVA = "0x2F0BE30", Offset = "0x2F0AE30", VA = "0x182F0BE30", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A38")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public TutorialPageController()
		{
		}
	}
}

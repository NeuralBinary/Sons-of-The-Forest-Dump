using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200087E RID: 2174
	[Token(Token = "0x200087E")]
	[AddComponentMenu("Sons/Items/VodkaBottleController")]
	public class VodkaBottleController : HeldControllerBase
	{
		// Token: 0x06003A39 RID: 14905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A39")]
		[Address(RVA = "0x2EC6390", Offset = "0x2EC5390", VA = "0x182EC6390", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x000110D0 File Offset: 0x0000F2D0
		[Token(Token = "0x6003A3A")]
		[Address(RVA = "0x2F0D160", Offset = "0x2F0C160", VA = "0x182F0D160", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3B")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public VodkaBottleController()
		{
		}
	}
}

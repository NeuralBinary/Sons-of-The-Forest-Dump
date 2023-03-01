using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006CB RID: 1739
	[Token(Token = "0x20006CB")]
	[AddComponentMenu("Sons/Gameplay/UnderwaterMaskController")]
	public class UnderwaterMaskController : HeldControllerBase
	{
		// Token: 0x06002C83 RID: 11395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C83")]
		[Address(RVA = "0x2DFCC20", Offset = "0x2DFBC20", VA = "0x182DFCC20", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[Token(Token = "0x6002C84")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C85")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public UnderwaterMaskController()
		{
		}
	}
}

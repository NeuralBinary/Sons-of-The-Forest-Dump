using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	public interface IHeldItem
	{
		// Token: 0x060038E0 RID: 14560
		[Token(Token = "0x60038E0")]
		void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId);
	}
}

using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008C0 RID: 2240
	[Token(Token = "0x20008C0")]
	public interface IHeldItem
	{
		// Token: 0x06003FFA RID: 16378
		[Token(Token = "0x6003FFA")]
		void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance);
	}
}

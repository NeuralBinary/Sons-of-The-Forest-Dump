using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000852 RID: 2130
	[Token(Token = "0x2000852")]
	[AddComponentMenu("Sons/Items/KeyCardItemController")]
	public class KeyCardItemController : HeldControllerBase
	{
		// Token: 0x060038E3 RID: 14563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E3")]
		[Address(RVA = "0x2ECFCB0", Offset = "0x2ECECB0", VA = "0x182ECFCB0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		[Token(Token = "0x60038E4")]
		[Address(RVA = "0x2ECFD00", Offset = "0x2ECED00", VA = "0x182ECFD00", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E5")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public KeyCardItemController()
		{
		}
	}
}

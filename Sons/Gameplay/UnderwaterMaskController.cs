using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000803 RID: 2051
	[Token(Token = "0x2000803")]
	[AddComponentMenu("Sons/Gameplay/UnderwaterMaskController")]
	public class UnderwaterMaskController : HeldControllerBase
	{
		// Token: 0x06003755 RID: 14165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x353D870", Offset = "0x353BE70", VA = "0x18353D870", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x000107E8 File Offset: 0x0000E9E8
		[Token(Token = "0x6003756")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003757")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UnderwaterMaskController()
		{
		}
	}
}

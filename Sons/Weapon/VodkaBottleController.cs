using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008F0 RID: 2288
	[Token(Token = "0x20008F0")]
	[AddComponentMenu("Sons/Items/VodkaBottleController")]
	public class VodkaBottleController : HeldControllerBase
	{
		// Token: 0x06004161 RID: 16737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004161")]
		[Address(RVA = "0x35E2590", Offset = "0x35E0B90", VA = "0x1835E2590", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x00013F68 File Offset: 0x00012168
		[Token(Token = "0x6004162")]
		[Address(RVA = "0x36106D0", Offset = "0x360ECD0", VA = "0x1836106D0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004163")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VodkaBottleController()
		{
		}
	}
}

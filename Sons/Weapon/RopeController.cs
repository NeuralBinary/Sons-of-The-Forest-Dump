using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008D4 RID: 2260
	[Token(Token = "0x20008D4")]
	[AddComponentMenu("Sons/Items/RopeController")]
	public class RopeController : HeldControllerBase
	{
		// Token: 0x060040A0 RID: 16544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A0")]
		[Address(RVA = "0x35E2590", Offset = "0x35E0B90", VA = "0x1835E2590", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00013C08 File Offset: 0x00011E08
		[Token(Token = "0x60040A1")]
		[Address(RVA = "0x3600CD0", Offset = "0x35FF2D0", VA = "0x183600CD0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RopeController()
		{
		}
	}
}

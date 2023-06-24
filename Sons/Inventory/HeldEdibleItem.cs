using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x20005FE")]
	[AddComponentMenu("Sons/Items/HeldEdibleItem")]
	public class HeldEdibleItem : HeldControllerBase
	{
		// Token: 0x060027DF RID: 10207 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x2F67C40", Offset = "0x2F66240", VA = "0x182F67C40")]
		private bool IsInInventory()
		{
			return default(bool);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x33CE780", Offset = "0x33CCD80", VA = "0x1833CE780", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x33CEC70", Offset = "0x33CD270", VA = "0x1833CEC70", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HeldEdibleItem()
		{
		}
	}
}

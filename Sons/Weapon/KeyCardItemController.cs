using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008C2 RID: 2242
	[Token(Token = "0x20008C2")]
	[AddComponentMenu("Sons/Items/KeyCardItemController")]
	public class KeyCardItemController : HeldControllerBase
	{
		// Token: 0x06003FFD RID: 16381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFD")]
		[Address(RVA = "0x35F19D0", Offset = "0x35EFFD0", VA = "0x1835F19D0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x000138C0 File Offset: 0x00011AC0
		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x35F1A20", Offset = "0x35F0020", VA = "0x1835F1A20", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFF")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public KeyCardItemController()
		{
		}
	}
}

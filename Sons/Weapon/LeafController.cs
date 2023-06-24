using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008C3 RID: 2243
	[Token(Token = "0x20008C3")]
	[AddComponentMenu("Sons/Items/LeafController")]
	public class LeafController : HeldControllerBase
	{
		// Token: 0x06004000 RID: 16384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004000")]
		[Address(RVA = "0x35E2590", Offset = "0x35E0B90", VA = "0x1835E2590", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x000138D8 File Offset: 0x00011AD8
		[Token(Token = "0x6004001")]
		[Address(RVA = "0x35F1A90", Offset = "0x35F0090", VA = "0x1835F1A90", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004002")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LeafController()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008E2 RID: 2274
	[Token(Token = "0x20008E2")]
	[AddComponentMenu("Sons/Weapon/TacticalAxeWeaponController")]
	public class TacticalAxeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x0600410D RID: 16653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410D")]
		[Address(RVA = "0x3609960", Offset = "0x3607F60", VA = "0x183609960", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x00013E30 File Offset: 0x00012030
		[Token(Token = "0x600410E")]
		[Address(RVA = "0x3609AB0", Offset = "0x36080B0", VA = "0x183609AB0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410F")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public TacticalAxeWeaponController()
		{
		}
	}
}

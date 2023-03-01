using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000871 RID: 2161
	[Token(Token = "0x2000871")]
	[AddComponentMenu("Sons/Weapon/TacticalAxeWeaponController")]
	public class TacticalAxeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x060039E6 RID: 14822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E6")]
		[Address(RVA = "0x2F07490", Offset = "0x2F06490", VA = "0x182F07490", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x00010F98 File Offset: 0x0000F198
		[Token(Token = "0x60039E7")]
		[Address(RVA = "0x2F075B0", Offset = "0x2F065B0", VA = "0x182F075B0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E8")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public TacticalAxeWeaponController()
		{
		}
	}
}

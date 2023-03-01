using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000869 RID: 2153
	[Token(Token = "0x2000869")]
	[AddComponentMenu("Sons/Weapon/ShotgunWeaponController")]
	public class ShotgunWeaponController : RangedWeaponController
	{
		// Token: 0x060039AC RID: 14764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AC")]
		[Address(RVA = "0x2EDD5D0", Offset = "0x2EDC5D0", VA = "0x182EDD5D0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AD")]
		[Address(RVA = "0x2EDD7D0", Offset = "0x2EDC7D0", VA = "0x182EDD7D0", Slot = "18")]
		protected override void PlayFireAnimNetwork()
		{
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x00010E60 File Offset: 0x0000F060
		[Token(Token = "0x60039AE")]
		[Address(RVA = "0x2EDD6E0", Offset = "0x2EDC6E0", VA = "0x182EDD6E0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AF")]
		[Address(RVA = "0x2EDD540", Offset = "0x2EDC540", VA = "0x182EDD540", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x00010E78 File Offset: 0x0000F078
		[Token(Token = "0x60039B0")]
		[Address(RVA = "0x2ED94B0", Offset = "0x2ED84B0", VA = "0x182ED94B0", Slot = "34")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B1")]
		[Address(RVA = "0x2EDD860", Offset = "0x2EDC860", VA = "0x182EDD860")]
		public ShotgunWeaponController()
		{
		}

		// Token: 0x04003117 RID: 12567
		[Token(Token = "0x4003117")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private float _multiplayerScale;
	}
}

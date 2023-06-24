using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008D0 RID: 2256
	[Token(Token = "0x20008D0")]
	[AddComponentMenu("Sons/Weapon/RepairToolWeaponController")]
	public class RepairToolWeaponController : HeldControllerBase
	{
		// Token: 0x0600408D RID: 16525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408D")]
		[Address(RVA = "0x35FF8A0", Offset = "0x35FDEA0", VA = "0x1835FF8A0")]
		private void Update()
		{
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408E")]
		[Address(RVA = "0x35FFA40", Offset = "0x35FE040", VA = "0x1835FFA40", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00013B18 File Offset: 0x00011D18
		[Token(Token = "0x600408F")]
		[Address(RVA = "0x35FFBE0", Offset = "0x35FE1E0", VA = "0x1835FFBE0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004090")]
		[Address(RVA = "0x35FFD20", Offset = "0x35FE320", VA = "0x1835FFD20", Slot = "9")]
		protected override void UnequipStartedHook()
		{
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004091")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RepairToolWeaponController()
		{
		}

		// Token: 0x040035B7 RID: 13751
		[Token(Token = "0x40035B7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private weaponInfo _weaponInfo;
	}
}

using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008E8 RID: 2280
	[Token(Token = "0x20008E8")]
	[AddComponentMenu("Sons/Weapon/Time Bomb Controller")]
	public class TimeBombWeaponController : RangedWeaponController
	{
		// Token: 0x06004124 RID: 16676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004124")]
		[Address(RVA = "0x35E2830", Offset = "0x35E0E30", VA = "0x1835E2830", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004125")]
		[Address(RVA = "0x35E31D0", Offset = "0x35E17D0", VA = "0x1835E31D0", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004126")]
		[Address(RVA = "0x360AD30", Offset = "0x3609330", VA = "0x18360AD30", Slot = "34")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004127")]
		[Address(RVA = "0x35EFC60", Offset = "0x35EE260", VA = "0x1835EFC60", Slot = "33")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x00013EA8 File Offset: 0x000120A8
		[Token(Token = "0x6004128")]
		[Address(RVA = "0x360B120", Offset = "0x3609720", VA = "0x18360B120", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004129")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412A")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public TimeBombWeaponController()
		{
		}
	}
}

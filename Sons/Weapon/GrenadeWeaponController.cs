using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008BB RID: 2235
	[Token(Token = "0x20008BB")]
	[AddComponentMenu("Sons/Weapon/GrenadeWeaponController")]
	public class GrenadeWeaponController : RangedWeaponController
	{
		// Token: 0x06003FCF RID: 16335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x35E2830", Offset = "0x35E0E30", VA = "0x1835E2830", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x35E31D0", Offset = "0x35E17D0", VA = "0x1835E31D0", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x35EF6E0", Offset = "0x35EDCE0", VA = "0x1835EF6E0", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x35EF890", Offset = "0x35EDE90", VA = "0x1835EF890", Slot = "34")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD3")]
		[Address(RVA = "0x35EFC60", Offset = "0x35EE260", VA = "0x1835EFC60", Slot = "33")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x00013788 File Offset: 0x00011988
		[Token(Token = "0x6003FD4")]
		[Address(RVA = "0x35EFCB0", Offset = "0x35EE2B0", VA = "0x1835EFCB0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD6")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public GrenadeWeaponController()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008DC RID: 2268
	[Token(Token = "0x20008DC")]
	[AddComponentMenu("Sons/Weapon/SmallRockWeaponController")]
	public class SmallRockWeaponController : RangedWeaponController
	{
		// Token: 0x060040E5 RID: 16613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E5")]
		[Address(RVA = "0x35E2830", Offset = "0x35E0E30", VA = "0x1835E2830", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x35E31D0", Offset = "0x35E17D0", VA = "0x1835E31D0", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E7")]
		[Address(RVA = "0x3607940", Offset = "0x3605F40", VA = "0x183607940", Slot = "34")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E8")]
		[Address(RVA = "0x35EFC60", Offset = "0x35EE260", VA = "0x1835EFC60", Slot = "33")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x00013D70 File Offset: 0x00011F70
		[Token(Token = "0x60040E9")]
		[Address(RVA = "0x3607D00", Offset = "0x3606300", VA = "0x183607D00", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EB")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public SmallRockWeaponController()
		{
		}
	}
}

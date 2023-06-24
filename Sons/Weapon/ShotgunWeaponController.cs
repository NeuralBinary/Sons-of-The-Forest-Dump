using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008D9 RID: 2265
	[Token(Token = "0x20008D9")]
	[AddComponentMenu("Sons/Weapon/ShotgunWeaponController")]
	public class ShotgunWeaponController : RangedWeaponController
	{
		// Token: 0x060040CF RID: 16591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040CF")]
		[Address(RVA = "0x36067A0", Offset = "0x3604DA0", VA = "0x1836067A0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D0")]
		[Address(RVA = "0x3606950", Offset = "0x3604F50", VA = "0x183606950", Slot = "18")]
		protected override void PlayFireAnimNetwork()
		{
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x00013CC8 File Offset: 0x00011EC8
		[Token(Token = "0x60040D1")]
		[Address(RVA = "0x3606A20", Offset = "0x3605020", VA = "0x183606A20", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x00013CE0 File Offset: 0x00011EE0
		[Token(Token = "0x60040D2")]
		[Address(RVA = "0x3606B80", Offset = "0x3605180", VA = "0x183606B80", Slot = "24")]
		protected override bool CanAim()
		{
			return default(bool);
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D3")]
		[Address(RVA = "0x3606D30", Offset = "0x3605330", VA = "0x183606D30", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x00013CF8 File Offset: 0x00011EF8
		[Token(Token = "0x60040D4")]
		[Address(RVA = "0x35E13D0", Offset = "0x35DF9D0", VA = "0x1835E13D0", Slot = "35")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D5")]
		[Address(RVA = "0x3606E50", Offset = "0x3605450", VA = "0x183606E50")]
		public ShotgunWeaponController()
		{
		}

		// Token: 0x040035E0 RID: 13792
		[Token(Token = "0x40035E0")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private float _multiplayerScale;
	}
}

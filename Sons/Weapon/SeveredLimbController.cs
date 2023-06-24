using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008D7 RID: 2263
	[Token(Token = "0x20008D7")]
	[AddComponentMenu("Sons/Weapon/SeveredLimbController")]
	public class SeveredLimbController : GenericMeleeWeaponController
	{
		// Token: 0x060040B8 RID: 16568 RVA: 0x00013C68 File Offset: 0x00011E68
		[Token(Token = "0x60040B8")]
		[Address(RVA = "0x2F67C40", Offset = "0x2F66240", VA = "0x182F67C40")]
		private bool IsInInventory()
		{
			return default(bool);
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B9")]
		[Address(RVA = "0x36050B0", Offset = "0x36036B0", VA = "0x1836050B0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x3605350", Offset = "0x3603950", VA = "0x183605350", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BB")]
		[Address(RVA = "0x36054D0", Offset = "0x3603AD0", VA = "0x1836054D0", Slot = "29")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x3605650", Offset = "0x3603C50", VA = "0x183605650", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x36056C0", Offset = "0x3603CC0", VA = "0x1836056C0", Slot = "14")]
		protected override void AttackButtonDown()
		{
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x36057E0", Offset = "0x3603DE0", VA = "0x1836057E0")]
		private IEnumerator DoAttackWorker()
		{
			return null;
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BF")]
		[Address(RVA = "0x3605870", Offset = "0x3603E70", VA = "0x183605870", Slot = "19")]
		protected override void BlockStart()
		{
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C0")]
		[Address(RVA = "0x3605970", Offset = "0x3603F70", VA = "0x183605970", Slot = "20")]
		protected override void BlockEnd()
		{
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "21")]
		protected override void BlockEndOnDisable()
		{
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "23")]
		protected override void UpdateBlock()
		{
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C3")]
		[Address(RVA = "0x3605A50", Offset = "0x3604050", VA = "0x183605A50")]
		private void OnItemLeavesHandEvent()
		{
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C4")]
		[Address(RVA = "0x3605E30", Offset = "0x3604430", VA = "0x183605E30")]
		private void AttackEndCallback()
		{
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x00013C80 File Offset: 0x00011E80
		[Token(Token = "0x60040C5")]
		[Address(RVA = "0x3605EC0", Offset = "0x36044C0", VA = "0x183605EC0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x00013C98 File Offset: 0x00011E98
		[Token(Token = "0x60040C6")]
		[Address(RVA = "0x36060E0", Offset = "0x36046E0", VA = "0x1836060E0")]
		private bool WeaponIsIdle()
		{
			return default(bool);
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x36063A0", Offset = "0x36049A0", VA = "0x1836063A0")]
		private RangedWeapon GetRangedWeapon()
		{
			return null;
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C8")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public SeveredLimbController()
		{
		}

		// Token: 0x040035D8 RID: 13784
		[Token(Token = "0x40035D8")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine _attackWorker;

		// Token: 0x040035D9 RID: 13785
		[Token(Token = "0x40035D9")]
		[FieldOffset(Offset = "0x188")]
		private RangedWeapon _rangedWeapon;

		// Token: 0x040035DA RID: 13786
		[Token(Token = "0x40035DA")]
		[FieldOffset(Offset = "0x190")]
		private bool _inMidThrow;

		// Token: 0x040035DB RID: 13787
		[Token(Token = "0x40035DB")]
		[FieldOffset(Offset = "0x191")]
		private bool _isThrowing;

		// Token: 0x040035DC RID: 13788
		[Token(Token = "0x40035DC")]
		[FieldOffset(Offset = "0x192")]
		private bool _itemWasThrown;
	}
}

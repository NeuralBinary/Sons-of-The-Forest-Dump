using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008DE RID: 2270
	[Token(Token = "0x20008DE")]
	[AddComponentMenu("Sons/Weapon/SpearWeaponController")]
	public class SpearWeaponController : MeleeWeaponController
	{
		// Token: 0x060040EE RID: 16622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x3607E90", Offset = "0x3606490", VA = "0x183607E90", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x3607F00", Offset = "0x3606500", VA = "0x183607F00", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F0")]
		[Address(RVA = "0x36080D0", Offset = "0x36066D0", VA = "0x1836080D0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F1")]
		[Address(RVA = "0x3608140", Offset = "0x3606740", VA = "0x183608140")]
		private void RegisterEvents()
		{
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x36083E0", Offset = "0x36069E0", VA = "0x1836083E0")]
		private void UnRegisterEvents()
		{
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x00013DA0 File Offset: 0x00011FA0
		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x3608680", Offset = "0x3606C80", VA = "0x183608680")]
		private bool WeaponIsIdle()
		{
			return default(bool);
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x36088C0", Offset = "0x3606EC0", VA = "0x1836088C0", Slot = "14")]
		protected override void AttackButtonDown()
		{
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x36089F0", Offset = "0x3606FF0", VA = "0x1836089F0")]
		private IEnumerator DoAttackWorker()
		{
			return null;
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F6")]
		[Address(RVA = "0x3608A80", Offset = "0x3607080", VA = "0x183608A80", Slot = "19")]
		protected override void BlockStart()
		{
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F7")]
		[Address(RVA = "0x3608B80", Offset = "0x3607180", VA = "0x183608B80", Slot = "20")]
		protected override void BlockEnd()
		{
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "23")]
		protected override void UpdateBlock()
		{
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F9")]
		[Address(RVA = "0x3608C60", Offset = "0x3607260", VA = "0x183608C60")]
		private void OnCheckComboStart()
		{
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FA")]
		[Address(RVA = "0x3608C70", Offset = "0x3607270", VA = "0x183608C70")]
		private void OnCheckComboEnd()
		{
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FB")]
		[Address(RVA = "0x3608C80", Offset = "0x3607280", VA = "0x183608C80")]
		private void OnMeleeAttackEvent()
		{
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FC")]
		[Address(RVA = "0x3608D30", Offset = "0x3607330", VA = "0x183608D30")]
		private void OnGroundAttackStart()
		{
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FD")]
		[Address(RVA = "0x3608DE0", Offset = "0x36073E0", VA = "0x183608DE0")]
		private void OnItemLeavesHandEvent()
		{
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FE")]
		[Address(RVA = "0x36091C0", Offset = "0x36077C0", VA = "0x1836091C0")]
		private void AttackEndCallback()
		{
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FF")]
		[Address(RVA = "0x3609250", Offset = "0x3607850", VA = "0x183609250")]
		private RangedWeapon GetRangedWeapon()
		{
			return null;
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x00013DB8 File Offset: 0x00011FB8
		[Token(Token = "0x6004100")]
		[Address(RVA = "0x36093F0", Offset = "0x36079F0", VA = "0x1836093F0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004101")]
		[Address(RVA = "0x3609530", Offset = "0x3607B30", VA = "0x183609530")]
		public SpearWeaponController()
		{
		}

		// Token: 0x040035E1 RID: 13793
		[Token(Token = "0x40035E1")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine _attackWorker;

		// Token: 0x040035E2 RID: 13794
		[Token(Token = "0x40035E2")]
		[FieldOffset(Offset = "0xE0")]
		private RangedWeapon _rangedWeapon;

		// Token: 0x040035E3 RID: 13795
		[Token(Token = "0x40035E3")]
		[FieldOffset(Offset = "0xE8")]
		private bool _shouldSpawnWaterFX;

		// Token: 0x040035E4 RID: 13796
		[Token(Token = "0x40035E4")]
		[FieldOffset(Offset = "0xE9")]
		private bool _inMidThrow;

		// Token: 0x040035E5 RID: 13797
		[Token(Token = "0x40035E5")]
		[FieldOffset(Offset = "0xEA")]
		private bool _isThrowing;

		// Token: 0x040035E6 RID: 13798
		[Token(Token = "0x40035E6")]
		[FieldOffset(Offset = "0xEB")]
		private bool _checkCombo;

		// Token: 0x040035E7 RID: 13799
		[Token(Token = "0x40035E7")]
		[FieldOffset(Offset = "0xEC")]
		private bool _itemWasThrown;
	}
}

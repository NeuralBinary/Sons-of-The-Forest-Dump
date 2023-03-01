using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200086D RID: 2157
	[Token(Token = "0x200086D")]
	[AddComponentMenu("Sons/Weapon/SpearWeaponController")]
	public class SpearWeaponController : MeleeWeaponController
	{
		// Token: 0x060039C8 RID: 14792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C8")]
		[Address(RVA = "0x2F061C0", Offset = "0x2F051C0", VA = "0x182F061C0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, int itemId)
		{
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C9")]
		[Address(RVA = "0x2F06340", Offset = "0x2F05340", VA = "0x182F06340", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CA")]
		[Address(RVA = "0x2F06660", Offset = "0x2F05660", VA = "0x182F06660")]
		private void RegisterEvents()
		{
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x2F06B40", Offset = "0x2F05B40", VA = "0x182F06B40")]
		private void UnRegisterEvents()
		{
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x00010F08 File Offset: 0x0000F108
		[Token(Token = "0x60039CC")]
		[Address(RVA = "0x2F07020", Offset = "0x2F06020", VA = "0x182F07020")]
		private bool WeaponIsIdle()
		{
			return default(bool);
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CD")]
		[Address(RVA = "0x2F05DD0", Offset = "0x2F04DD0", VA = "0x182F05DD0", Slot = "14")]
		protected override void AttackButtonDown()
		{
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039CE")]
		[Address(RVA = "0x2F06090", Offset = "0x2F05090", VA = "0x182F06090")]
		private IEnumerator DoAttackWorker()
		{
			return null;
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CF")]
		[Address(RVA = "0x2F05FD0", Offset = "0x2F04FD0", VA = "0x182F05FD0", Slot = "19")]
		protected override void BlockStart()
		{
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D0")]
		[Address(RVA = "0x2F05F30", Offset = "0x2F04F30", VA = "0x182F05F30", Slot = "20")]
		protected override void BlockEnd()
		{
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D1")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "23")]
		protected override void UpdateBlock()
		{
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D2")]
		[Address(RVA = "0x2F06330", Offset = "0x2F05330", VA = "0x182F06330")]
		private void OnCheckComboStart()
		{
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D3")]
		[Address(RVA = "0x2F06320", Offset = "0x2F05320", VA = "0x182F06320")]
		private void OnCheckComboEnd()
		{
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D4")]
		[Address(RVA = "0x2F06650", Offset = "0x2F05650", VA = "0x182F06650")]
		private void OnMeleeAttackEvent()
		{
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D5")]
		[Address(RVA = "0x2F063B0", Offset = "0x2F053B0", VA = "0x182F063B0")]
		private void OnGroundAttackStart()
		{
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D6")]
		[Address(RVA = "0x2F063C0", Offset = "0x2F053C0", VA = "0x182F063C0")]
		private void OnItemLeavesHandEvent()
		{
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D7")]
		[Address(RVA = "0x2F05E90", Offset = "0x2F04E90", VA = "0x182F05E90")]
		private void AttackEndCallback()
		{
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D8")]
		[Address(RVA = "0x2F06100", Offset = "0x2F05100", VA = "0x182F06100")]
		private RangedWeapon GetRangedWeapon()
		{
			return null;
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00010F20 File Offset: 0x0000F120
		[Token(Token = "0x60039D9")]
		[Address(RVA = "0x2F06230", Offset = "0x2F05230", VA = "0x182F06230", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x2F07290", Offset = "0x2F06290", VA = "0x182F07290")]
		public SpearWeaponController()
		{
		}

		// Token: 0x04003118 RID: 12568
		[Token(Token = "0x4003118")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine _attackWorker;

		// Token: 0x04003119 RID: 12569
		[Token(Token = "0x4003119")]
		[FieldOffset(Offset = "0xE0")]
		private RangedWeapon _rangedWeapon;

		// Token: 0x0400311A RID: 12570
		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0xE8")]
		private bool _shouldSpawnWaterFX;

		// Token: 0x0400311B RID: 12571
		[Token(Token = "0x400311B")]
		[FieldOffset(Offset = "0xE9")]
		private bool _inMidThrow;

		// Token: 0x0400311C RID: 12572
		[Token(Token = "0x400311C")]
		[FieldOffset(Offset = "0xEA")]
		private bool _isThrowing;

		// Token: 0x0400311D RID: 12573
		[Token(Token = "0x400311D")]
		[FieldOffset(Offset = "0xEB")]
		private bool _checkCombo;

		// Token: 0x0400311E RID: 12574
		[Token(Token = "0x400311E")]
		[FieldOffset(Offset = "0xEC")]
		private bool _itemWasThrown;
	}
}

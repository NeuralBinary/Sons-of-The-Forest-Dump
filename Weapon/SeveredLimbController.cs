using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000867 RID: 2151
	[Token(Token = "0x2000867")]
	[AddComponentMenu("Sons/Weapon/SeveredLimbController")]
	public class SeveredLimbController : GenericMeleeWeaponController
	{
		// Token: 0x06003995 RID: 14741 RVA: 0x00010E00 File Offset: 0x0000F000
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x2D93A80", Offset = "0x2D92A80", VA = "0x182D93A80")]
		private bool IsInInventory()
		{
			return default(bool);
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x2EDC9D0", Offset = "0x2EDB9D0", VA = "0x182EDC9D0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, int itemId)
		{
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x2EDD030", Offset = "0x2EDC030", VA = "0x182EDD030", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x2EDD150", Offset = "0x2EDC150", VA = "0x182EDD150", Slot = "29")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003999")]
		[Address(RVA = "0x2EDCD20", Offset = "0x2EDBD20", VA = "0x182EDCD20", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399A")]
		[Address(RVA = "0x2EDC5F0", Offset = "0x2EDB5F0", VA = "0x182EDC5F0", Slot = "14")]
		protected override void AttackButtonDown()
		{
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399B")]
		[Address(RVA = "0x2EDC8A0", Offset = "0x2EDB8A0", VA = "0x182EDC8A0")]
		private IEnumerator DoAttackWorker()
		{
			return null;
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399C")]
		[Address(RVA = "0x2EDC7E0", Offset = "0x2EDB7E0", VA = "0x182EDC7E0", Slot = "19")]
		protected override void BlockStart()
		{
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399D")]
		[Address(RVA = "0x2EDC740", Offset = "0x2EDB740", VA = "0x182EDC740", Slot = "20")]
		protected override void BlockEnd()
		{
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399E")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "21")]
		protected override void BlockEndOnDisable()
		{
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "23")]
		protected override void UpdateBlock()
		{
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x2EDCD90", Offset = "0x2EDBD90", VA = "0x182EDCD90")]
		private void OnItemLeavesHandEvent()
		{
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A1")]
		[Address(RVA = "0x2EDC6A0", Offset = "0x2EDB6A0", VA = "0x182EDC6A0")]
		private void AttackEndCallback()
		{
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x00010E18 File Offset: 0x0000F018
		[Token(Token = "0x60039A2")]
		[Address(RVA = "0x2EDCB70", Offset = "0x2EDBB70", VA = "0x182EDCB70", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x00010E30 File Offset: 0x0000F030
		[Token(Token = "0x60039A3")]
		[Address(RVA = "0x2EDD270", Offset = "0x2EDC270", VA = "0x182EDD270")]
		private bool WeaponIsIdle()
		{
			return default(bool);
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0x2EDC910", Offset = "0x2EDB910", VA = "0x182EDC910")]
		private RangedWeapon GetRangedWeapon()
		{
			return null;
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public SeveredLimbController()
		{
		}

		// Token: 0x0400310F RID: 12559
		[Token(Token = "0x400310F")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine _attackWorker;

		// Token: 0x04003110 RID: 12560
		[Token(Token = "0x4003110")]
		[FieldOffset(Offset = "0x180")]
		private RangedWeapon _rangedWeapon;

		// Token: 0x04003111 RID: 12561
		[Token(Token = "0x4003111")]
		[FieldOffset(Offset = "0x188")]
		private bool _inMidThrow;

		// Token: 0x04003112 RID: 12562
		[Token(Token = "0x4003112")]
		[FieldOffset(Offset = "0x189")]
		private bool _isThrowing;

		// Token: 0x04003113 RID: 12563
		[Token(Token = "0x4003113")]
		[FieldOffset(Offset = "0x18A")]
		private bool _itemWasThrown;
	}
}

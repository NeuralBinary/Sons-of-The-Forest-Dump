using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x02000856 RID: 2134
	[Token(Token = "0x2000856")]
	[DefaultExecutionOrder(-1)]
	[AddComponentMenu("Sons/Weapon/MeleeWeaponController")]
	public abstract class MeleeWeaponController : HeldControllerBase
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x00010B48 File Offset: 0x0000ED48
		[Token(Token = "0x17000716")]
		protected bool GroundAttackAngleActive
		{
			[Token(Token = "0x60038F2")]
			[Address(RVA = "0x5F0C80", Offset = "0x5EFC80", VA = "0x1805F0C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F3")]
		[Address(RVA = "0x2ED04F0", Offset = "0x2ECF4F0", VA = "0x182ED04F0")]
		public void ApplySwingSpeed()
		{
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x00010B60 File Offset: 0x0000ED60
		[Token(Token = "0x60038F4")]
		[Address(RVA = "0x2ED0E50", Offset = "0x2ECFE50", VA = "0x182ED0E50")]
		protected float GetStaminaFactor()
		{
			return default(float);
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F5")]
		[Address(RVA = "0x2ED1BE0", Offset = "0x2ED0BE0", VA = "0x182ED1BE0")]
		private void OnValidate()
		{
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F6")]
		[Address(RVA = "0x2ED1100", Offset = "0x2ED0100", VA = "0x182ED1100", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F7")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "10")]
		protected virtual void OnInitialized()
		{
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F8")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "11")]
		protected virtual void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F9")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "12")]
		protected virtual void OnAttackBlocked(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FA")]
		[Address(RVA = "0x2ED1AF0", Offset = "0x2ED0AF0", VA = "0x182ED1AF0")]
		protected void OnSwingWeapon(weaponInfo.SwingType swingType)
		{
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FB")]
		[Address(RVA = "0x2ED1710", Offset = "0x2ED0710", VA = "0x182ED1710", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FC")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "14")]
		protected virtual void AttackButtonDown()
		{
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FD")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "15")]
		protected virtual void AttackHeld()
		{
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FE")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "16")]
		protected virtual void AttackHeldEnded()
		{
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FF")]
		[Address(RVA = "0x2ED24B0", Offset = "0x2ED14B0", VA = "0x182ED24B0", Slot = "17")]
		internal virtual void Update()
		{
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003900")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "18")]
		protected virtual void UpdateAttackState()
		{
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003901")]
		[Address(RVA = "0x2ED0B10", Offset = "0x2ECFB10", VA = "0x182ED0B10")]
		private void CheckAttackHeldInput()
		{
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003902")]
		[Address(RVA = "0x2ED0C70", Offset = "0x2ECFC70", VA = "0x182ED0C70")]
		private void CheckAttackInput()
		{
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x00010B78 File Offset: 0x0000ED78
		[Token(Token = "0x6003903")]
		[Address(RVA = "0x2ED16D0", Offset = "0x2ED06D0", VA = "0x182ED16D0")]
		protected bool IsHoldingAttack()
		{
			return default(bool);
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003904")]
		[Address(RVA = "0x2ED0D50", Offset = "0x2ECFD50", VA = "0x182ED0D50")]
		private void CheckBlockInput()
		{
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003905")]
		[Address(RVA = "0x2ED0850", Offset = "0x2ECF850", VA = "0x182ED0850", Slot = "19")]
		protected virtual void BlockStart()
		{
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003906")]
		[Address(RVA = "0x2ED0770", Offset = "0x2ECF770", VA = "0x182ED0770", Slot = "20")]
		protected virtual void BlockEnd()
		{
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003907")]
		[Address(RVA = "0x2ED06D0", Offset = "0x2ECF6D0", VA = "0x182ED06D0", Slot = "21")]
		protected virtual void BlockEndOnDisable()
		{
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x00010B90 File Offset: 0x0000ED90
		[Token(Token = "0x6003908")]
		[Address(RVA = "0x255D2C0", Offset = "0x255C2C0", VA = "0x18255D2C0")]
		protected bool IsHoldingBlock()
		{
			return default(bool);
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		[Token(Token = "0x6003909")]
		[Address(RVA = "0x2ED1580", Offset = "0x2ED0580", VA = "0x182ED1580")]
		private bool IsBlockDamageActive()
		{
			return default(bool);
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		[Token(Token = "0x600390A")]
		[Address(RVA = "0x2ED1590", Offset = "0x2ED0590", VA = "0x182ED1590", Slot = "22")]
		protected virtual bool IsBlocking()
		{
			return default(bool);
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390B")]
		[Address(RVA = "0x2ED16E0", Offset = "0x2ED06E0", VA = "0x182ED16E0")]
		protected void OnBlockActive(bool active)
		{
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390C")]
		[Address(RVA = "0x2ED09A0", Offset = "0x2ECF9A0", VA = "0x182ED09A0")]
		private void BlockedImpact(IImpactSender sender, IImpactData data)
		{
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390D")]
		[Address(RVA = "0x2ED0EF0", Offset = "0x2ECFEF0", VA = "0x182ED0EF0")]
		public void HandleBlockedImpact(AudioImpactMaterial impactMaterial, float impactWeight)
		{
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390E")]
		[Address(RVA = "0x2ED1DE0", Offset = "0x2ED0DE0", VA = "0x182ED1DE0")]
		private void UpdateBlockAnimParam()
		{
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390F")]
		[Address(RVA = "0x2ED1EE0", Offset = "0x2ED0EE0", VA = "0x182ED1EE0", Slot = "23")]
		protected virtual void UpdateBlock()
		{
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003910")]
		[Address(RVA = "0x2ED2060", Offset = "0x2ED1060", VA = "0x182ED2060")]
		private void UpdateGroundAttackAngle()
		{
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003911")]
		[Address(RVA = "0x2ED1A70", Offset = "0x2ED0A70", VA = "0x182ED1A70")]
		private void OnNewAttack()
		{
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003912")]
		[Address(RVA = "0x2ED1C80", Offset = "0x2ED0C80", VA = "0x182ED1C80")]
		protected void ShowItemRenderable(bool show)
		{
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003913")]
		[Address(RVA = "0x2ED2850", Offset = "0x2ED1850", VA = "0x182ED2850")]
		protected MeleeWeaponController()
		{
		}

		// Token: 0x0400308F RID: 12431
		[Token(Token = "0x400308F")]
		[FieldOffset(Offset = "0x70")]
		private bool _groundAttackAngleActive;

		// Token: 0x04003090 RID: 12432
		[Token(Token = "0x4003090")]
		[FieldOffset(Offset = "0x74")]
		private float _currentSwingSpeed;

		// Token: 0x04003091 RID: 12433
		[Token(Token = "0x4003091")]
		[FieldOffset(Offset = "0x78")]
		protected int _lastAttackFrame;

		// Token: 0x04003092 RID: 12434
		[Token(Token = "0x4003092")]
		[FieldOffset(Offset = "0x7C")]
		protected float _lastAttackTime;

		// Token: 0x04003093 RID: 12435
		[Token(Token = "0x4003093")]
		[FieldOffset(Offset = "0x80")]
		protected int _lastAttackHeldFrame;

		// Token: 0x04003094 RID: 12436
		[Token(Token = "0x4003094")]
		[FieldOffset(Offset = "0x84")]
		protected float _lastAttackHeldTime;

		// Token: 0x04003095 RID: 12437
		[Token(Token = "0x4003095")]
		[FieldOffset(Offset = "0x88")]
		protected float _attackHoldTime;

		// Token: 0x04003096 RID: 12438
		[Token(Token = "0x4003096")]
		[FieldOffset(Offset = "0x8C")]
		private bool _isHoldingAttack;

		// Token: 0x04003097 RID: 12439
		[Token(Token = "0x4003097")]
		[FieldOffset(Offset = "0x90")]
		protected MeleeWeaponData _meleeWeaponData;

		// Token: 0x04003098 RID: 12440
		[Token(Token = "0x4003098")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected weaponInfo _weaponInfo;

		// Token: 0x04003099 RID: 12441
		[Token(Token = "0x4003099")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioImpactMaterial _impactAudioMaterial;

		// Token: 0x0400309A RID: 12442
		[Token(Token = "0x400309A")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _groundAttackAngleBase;

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[FieldOffset(Offset = "0xA8")]
		[FormerlySerializedAs("_useStickBlock")]
		[SerializeField]
		private bool _allowBlocking;

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0xA9")]
		[SerializeField]
		private bool _twoArmBlock;

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0xB0")]
		private Vitals _playerStats;

		// Token: 0x0400309E RID: 12446
		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0xB8")]
		protected DamageController _damageController;

		// Token: 0x0400309F RID: 12447
		[Token(Token = "0x400309F")]
		[FieldOffset(Offset = "0xC0")]
		private float _blockImpactTime;

		// Token: 0x040030A0 RID: 12448
		[Token(Token = "0x40030A0")]
		[FieldOffset(Offset = "0xC4")]
		private bool _isHoldingBlocking;

		// Token: 0x040030A1 RID: 12449
		[Token(Token = "0x40030A1")]
		[FieldOffset(Offset = "0xC8")]
		private int _isBlockDamageActive;

		// Token: 0x040030A2 RID: 12450
		[Token(Token = "0x40030A2")]
		[FieldOffset(Offset = "0xD0")]
		private ItemRenderableTag _itemRenderable;
	}
}

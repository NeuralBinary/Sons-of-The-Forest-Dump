using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x020008C6 RID: 2246
	[Token(Token = "0x20008C6")]
	[AddComponentMenu("Sons/Weapon/MeleeWeaponController")]
	[DefaultExecutionOrder(-1)]
	public abstract class MeleeWeaponController : HeldControllerBase
	{
		// Token: 0x0600400C RID: 16396 RVA: 0x00013920 File Offset: 0x00011B20
		[Token(Token = "0x600400C")]
		[Address(RVA = "0x35F24F0", Offset = "0x35F0AF0", VA = "0x1835F24F0")]
		internal float GetTreeCutDamageMultiplier()
		{
			return 0f;
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600400D RID: 16397 RVA: 0x00013938 File Offset: 0x00011B38
		[Token(Token = "0x1700083A")]
		protected bool GroundAttackAngleActive
		{
			[Token(Token = "0x600400D")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600400E")]
		[Address(RVA = "0x35F2520", Offset = "0x35F0B20", VA = "0x1835F2520")]
		protected void ApplySwingSpeed()
		{
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x00013950 File Offset: 0x00011B50
		[Token(Token = "0x600400F")]
		[Address(RVA = "0x35F27C0", Offset = "0x35F0DC0", VA = "0x1835F27C0")]
		private float GetStaminaFactor()
		{
			return 0f;
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004010")]
		[Address(RVA = "0x35F28C0", Offset = "0x35F0EC0", VA = "0x1835F28C0")]
		private void OnValidate()
		{
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004011")]
		[Address(RVA = "0x35F2A00", Offset = "0x35F1000", VA = "0x1835F2A00", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004012")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		protected virtual void OnInitialized()
		{
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004013")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		protected virtual void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004014")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		protected virtual void OnAttackBlocked(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004015")]
		[Address(RVA = "0x35F3300", Offset = "0x35F1900", VA = "0x1835F3300")]
		protected void OnSwingWeapon(weaponInfo.SwingType swingType)
		{
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004016")]
		[Address(RVA = "0x35F33F0", Offset = "0x35F19F0", VA = "0x1835F33F0", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004017")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		protected virtual void AttackButtonDown()
		{
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004018")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		protected virtual void AttackHeld()
		{
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004019")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		protected virtual void AttackHeldEnded()
		{
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600401A")]
		[Address(RVA = "0x35F3A00", Offset = "0x35F2000", VA = "0x1835F3A00", Slot = "17")]
		internal virtual void Update()
		{
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600401B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "18")]
		protected virtual void UpdateAttackState()
		{
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600401C")]
		[Address(RVA = "0x35F3D60", Offset = "0x35F2360", VA = "0x1835F3D60")]
		private void CheckAttackHeldInput()
		{
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x00013968 File Offset: 0x00011B68
		[Token(Token = "0x600401D")]
		[Address(RVA = "0x35F3FA0", Offset = "0x35F25A0", VA = "0x1835F3FA0")]
		protected bool CanAttackOrBlock()
		{
			return default(bool);
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600401E")]
		[Address(RVA = "0x35F4080", Offset = "0x35F2680", VA = "0x1835F4080")]
		private void CheckAttackInput()
		{
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x00013980 File Offset: 0x00011B80
		[Token(Token = "0x600401F")]
		[Address(RVA = "0x2921A20", Offset = "0x2920020", VA = "0x182921A20")]
		protected bool IsHoldingAttack()
		{
			return default(bool);
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004020")]
		[Address(RVA = "0x35F41D0", Offset = "0x35F27D0", VA = "0x1835F41D0")]
		private void CheckBlockInput()
		{
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004021")]
		[Address(RVA = "0x35F42D0", Offset = "0x35F28D0", VA = "0x1835F42D0", Slot = "19")]
		protected virtual void BlockStart()
		{
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004022")]
		[Address(RVA = "0x35F4470", Offset = "0x35F2A70", VA = "0x1835F4470", Slot = "20")]
		protected virtual void BlockEnd()
		{
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004023")]
		[Address(RVA = "0x35F45B0", Offset = "0x35F2BB0", VA = "0x1835F45B0", Slot = "21")]
		protected virtual void BlockEndOnDisable()
		{
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x00013998 File Offset: 0x00011B98
		[Token(Token = "0x6004024")]
		[Address(RVA = "0x2A29410", Offset = "0x2A27A10", VA = "0x182A29410")]
		protected bool IsHoldingBlock()
		{
			return default(bool);
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x000139B0 File Offset: 0x00011BB0
		[Token(Token = "0x6004025")]
		[Address(RVA = "0x35F46B0", Offset = "0x35F2CB0", VA = "0x1835F46B0")]
		private bool IsBlockDamageActive()
		{
			return default(bool);
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x000139C8 File Offset: 0x00011BC8
		[Token(Token = "0x6004026")]
		[Address(RVA = "0x35F46C0", Offset = "0x35F2CC0", VA = "0x1835F46C0", Slot = "22")]
		protected virtual bool IsBlocking()
		{
			return default(bool);
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004027")]
		[Address(RVA = "0x35F4840", Offset = "0x35F2E40", VA = "0x1835F4840")]
		protected void OnBlockActive(bool active)
		{
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004028")]
		[Address(RVA = "0x35F4870", Offset = "0x35F2E70", VA = "0x1835F4870")]
		private void BlockedImpact(IImpactSender sender, IImpactData data)
		{
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004029")]
		[Address(RVA = "0x35F4900", Offset = "0x35F2F00", VA = "0x1835F4900")]
		public void HandleBlockedImpact(AudioImpactMaterial impactMaterial, float impactWeight)
		{
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402A")]
		[Address(RVA = "0x35F4CC0", Offset = "0x35F32C0", VA = "0x1835F4CC0")]
		private void UpdateBlockAnimParam()
		{
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402B")]
		[Address(RVA = "0x35F4DC0", Offset = "0x35F33C0", VA = "0x1835F4DC0", Slot = "23")]
		protected virtual void UpdateBlock()
		{
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402C")]
		[Address(RVA = "0x35F5030", Offset = "0x35F3630", VA = "0x1835F5030")]
		private void UpdateGroundAttackAngle()
		{
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402D")]
		[Address(RVA = "0x35F5750", Offset = "0x35F3D50", VA = "0x1835F5750")]
		private void OnNewAttack()
		{
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402E")]
		[Address(RVA = "0x35F5840", Offset = "0x35F3E40", VA = "0x1835F5840")]
		protected void ShowItemRenderable(bool show)
		{
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402F")]
		[Address(RVA = "0x35F5B50", Offset = "0x35F4150", VA = "0x1835F5B50")]
		protected MeleeWeaponController()
		{
		}

		// Token: 0x04003555 RID: 13653
		[Token(Token = "0x4003555")]
		[FieldOffset(Offset = "0x68")]
		private bool _groundAttackAngleActive;

		// Token: 0x04003556 RID: 13654
		[Token(Token = "0x4003556")]
		[FieldOffset(Offset = "0x6C")]
		private float _currentSwingSpeed;

		// Token: 0x04003557 RID: 13655
		[Token(Token = "0x4003557")]
		[FieldOffset(Offset = "0x70")]
		protected int _lastAttackFrame;

		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x74")]
		protected float _lastAttackTime;

		// Token: 0x04003559 RID: 13657
		[Token(Token = "0x4003559")]
		[FieldOffset(Offset = "0x78")]
		protected int _lastAttackHeldFrame;

		// Token: 0x0400355A RID: 13658
		[Token(Token = "0x400355A")]
		[FieldOffset(Offset = "0x7C")]
		protected float _lastAttackHeldTime;

		// Token: 0x0400355B RID: 13659
		[Token(Token = "0x400355B")]
		[FieldOffset(Offset = "0x80")]
		protected float _attackHoldTime;

		// Token: 0x0400355C RID: 13660
		[Token(Token = "0x400355C")]
		[FieldOffset(Offset = "0x84")]
		private bool _isHoldingAttack;

		// Token: 0x0400355D RID: 13661
		[Token(Token = "0x400355D")]
		[FieldOffset(Offset = "0x88")]
		protected MeleeWeaponData _meleeWeaponData;

		// Token: 0x0400355E RID: 13662
		[Token(Token = "0x400355E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected weaponInfo _weaponInfo;

		// Token: 0x0400355F RID: 13663
		[Token(Token = "0x400355F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioImpactMaterial _impactAudioMaterial;

		// Token: 0x04003560 RID: 13664
		[Token(Token = "0x4003560")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _groundAttackAngleBase;

		// Token: 0x04003561 RID: 13665
		[Token(Token = "0x4003561")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[FormerlySerializedAs("_useStickBlock")]
		private bool _allowBlocking;

		// Token: 0x04003562 RID: 13666
		[Token(Token = "0x4003562")]
		[FieldOffset(Offset = "0xA1")]
		[SerializeField]
		private bool _twoArmBlock;

		// Token: 0x04003563 RID: 13667
		[Token(Token = "0x4003563")]
		[FieldOffset(Offset = "0xA8")]
		private Vitals _playerStats;

		// Token: 0x04003564 RID: 13668
		[Token(Token = "0x4003564")]
		[FieldOffset(Offset = "0xB0")]
		protected DamageController _damageController;

		// Token: 0x04003565 RID: 13669
		[Token(Token = "0x4003565")]
		[FieldOffset(Offset = "0xB8")]
		private float _blockImpactTime;

		// Token: 0x04003566 RID: 13670
		[Token(Token = "0x4003566")]
		[FieldOffset(Offset = "0xBC")]
		private bool _isHoldingBlocking;

		// Token: 0x04003567 RID: 13671
		[Token(Token = "0x4003567")]
		[FieldOffset(Offset = "0xC0")]
		private int _isBlockDamageActive;

		// Token: 0x04003568 RID: 13672
		[Token(Token = "0x4003568")]
		[FieldOffset(Offset = "0xC8")]
		private ItemRenderableTag _itemRenderable;

		// Token: 0x04003569 RID: 13673
		[Token(Token = "0x4003569")]
		[FieldOffset(Offset = "0xD0")]
		private Func<float> _treeCutDamageMultiplierMethod;
	}
}

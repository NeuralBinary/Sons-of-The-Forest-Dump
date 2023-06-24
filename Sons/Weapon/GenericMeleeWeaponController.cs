using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008B2 RID: 2226
	[Token(Token = "0x20008B2")]
	[AddComponentMenu("Sons/Weapon/GenericMeleeWeaponController")]
	public abstract class GenericMeleeWeaponController : MeleeWeaponController
	{
		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06003F7F RID: 16255 RVA: 0x000135D8 File Offset: 0x000117D8
		[Token(Token = "0x1700082E")]
		private bool ShowGroundAttackOptions
		{
			[Token(Token = "0x6003F7F")]
			[Address(RVA = "0x35E6B60", Offset = "0x35E5160", VA = "0x1835E6B60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06003F80 RID: 16256 RVA: 0x000135F0 File Offset: 0x000117F0
		[Token(Token = "0x1700082F")]
		protected bool InCheckComboWindow
		{
			[Token(Token = "0x6003F80")]
			[Address(RVA = "0x27394A0", Offset = "0x2737AA0", VA = "0x1827394A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x00013608 File Offset: 0x00011808
		[Token(Token = "0x17000830")]
		protected bool AttackActive
		{
			[Token(Token = "0x6003F81")]
			[Address(RVA = "0x2739510", Offset = "0x2737B10", VA = "0x182739510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x00013620 File Offset: 0x00011820
		[Token(Token = "0x17000831")]
		public float TreeHitFrequency
		{
			[Token(Token = "0x6003F82")]
			[Address(RVA = "0x2811690", Offset = "0x280FC90", VA = "0x182811690")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x00013638 File Offset: 0x00011838
		[Token(Token = "0x17000832")]
		public int TreeMaxSwingHits
		{
			[Token(Token = "0x6003F83")]
			[Address(RVA = "0x35E6B70", Offset = "0x35E5170", VA = "0x1835E6B70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F84")]
		[Address(RVA = "0x35E6BC0", Offset = "0x35E51C0", VA = "0x1835E6BC0", Slot = "10")]
		protected override void OnInitialized()
		{
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F85")]
		[Address(RVA = "0x35E6C60", Offset = "0x35E5260", VA = "0x1835E6C60", Slot = "24")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F86")]
		[Address(RVA = "0x35E6D30", Offset = "0x35E5330", VA = "0x1835E6D30", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F87")]
		[Address(RVA = "0x35E7140", Offset = "0x35E5740", VA = "0x1835E7140")]
		private void ResetAllParams()
		{
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F88")]
		[Address(RVA = "0x35E7390", Offset = "0x35E5990", VA = "0x1835E7390", Slot = "11")]
		protected override void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F89")]
		[Address(RVA = "0x35E76A0", Offset = "0x35E5CA0", VA = "0x1835E76A0", Slot = "12")]
		protected override void OnAttackBlocked(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8A")]
		[Address(RVA = "0x35E7810", Offset = "0x35E5E10", VA = "0x1835E7810")]
		protected void SetAttackState(GenericMeleeWeaponController.AttackInputState newInputState)
		{
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8B")]
		[Address(RVA = "0x35E7910", Offset = "0x35E5F10", VA = "0x1835E7910")]
		private void SetGroundAttackState(GenericMeleeWeaponController.GroundAttackState groundAttackState)
		{
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x35E7A80", Offset = "0x35E6080", VA = "0x1835E7A80", Slot = "18")]
		protected override void UpdateAttackState()
		{
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8D")]
		[Address(RVA = "0x35E8180", Offset = "0x35E6780", VA = "0x1835E8180")]
		private void UpdateSwingSpeedAfterHit()
		{
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x35E82C0", Offset = "0x35E68C0", VA = "0x1835E82C0")]
		private void UpdateTreeAttack()
		{
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0x35E82D0", Offset = "0x35E68D0", VA = "0x1835E82D0")]
		protected void UpdatePlayerMovementSlow(bool slowed)
		{
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x00013650 File Offset: 0x00011850
		[Token(Token = "0x6003F90")]
		[Address(RVA = "0x35E8450", Offset = "0x35E6A50", VA = "0x1835E8450")]
		private bool IsAttackHeld()
		{
			return default(bool);
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x00013668 File Offset: 0x00011868
		[Token(Token = "0x6003F91")]
		[Address(RVA = "0x35E8500", Offset = "0x35E6B00", VA = "0x1835E8500")]
		private bool ShouldDoComboEnder()
		{
			return default(bool);
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00013680 File Offset: 0x00011880
		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x35E85A0", Offset = "0x35E6BA0", VA = "0x1835E85A0", Slot = "25")]
		protected virtual bool HasChargeAttack()
		{
			return default(bool);
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x00013698 File Offset: 0x00011898
		[Token(Token = "0x6003F93")]
		[Address(RVA = "0x35E85B0", Offset = "0x35E6BB0", VA = "0x1835E85B0", Slot = "26")]
		protected virtual bool ShouldChopTree()
		{
			return default(bool);
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x000136B0 File Offset: 0x000118B0
		[Token(Token = "0x6003F94")]
		[Address(RVA = "0x35E86F0", Offset = "0x35E6CF0", VA = "0x1835E86F0", Slot = "27")]
		protected virtual bool ShouldGroundAttack()
		{
			return default(bool);
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x000136C8 File Offset: 0x000118C8
		[Token(Token = "0x6003F95")]
		[Address(RVA = "0x35E87C0", Offset = "0x35E6DC0", VA = "0x1835E87C0")]
		private bool CanStartAttack()
		{
			return default(bool);
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F96")]
		[Address(RVA = "0x35E89C0", Offset = "0x35E6FC0", VA = "0x1835E89C0", Slot = "14")]
		protected override void AttackButtonDown()
		{
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F97")]
		[Address(RVA = "0x35E8B20", Offset = "0x35E7120", VA = "0x1835E8B20", Slot = "15")]
		protected override void AttackHeld()
		{
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F98")]
		[Address(RVA = "0x35E8BE0", Offset = "0x35E71E0", VA = "0x1835E8BE0", Slot = "16")]
		protected override void AttackHeldEnded()
		{
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F99")]
		[Address(RVA = "0x35E8C00", Offset = "0x35E7200", VA = "0x1835E8C00", Slot = "28")]
		protected virtual void RegisterEvents()
		{
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9A")]
		[Address(RVA = "0x35E97C0", Offset = "0x35E7DC0", VA = "0x1835E97C0", Slot = "29")]
		protected virtual void UnregisterEvents()
		{
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9B")]
		[Address(RVA = "0x35EA370", Offset = "0x35E8970", VA = "0x1835EA370")]
		private void OnParryActive(bool active)
		{
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9C")]
		[Address(RVA = "0x35EA460", Offset = "0x35E8A60", VA = "0x1835EA460")]
		private void OnCheckComboStart()
		{
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x35EA4B0", Offset = "0x35E8AB0", VA = "0x1835EA4B0")]
		private void OnCheckComboEnd()
		{
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0x35EA500", Offset = "0x35E8B00", VA = "0x1835EA500")]
		private void OnAttackStarted(weaponInfo.SwingType swingType)
		{
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x35EA560", Offset = "0x35E8B60", VA = "0x1835EA560", Slot = "30")]
		protected virtual void SetSwingType(weaponInfo.SwingType swingType)
		{
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA0")]
		[Address(RVA = "0x35EA590", Offset = "0x35E8B90", VA = "0x1835EA590")]
		private void OnChargeAttackStart()
		{
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA1")]
		[Address(RVA = "0x35EA640", Offset = "0x35E8C40", VA = "0x1835EA640")]
		private void OnChargeAttackEnd()
		{
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA2")]
		[Address(RVA = "0x35EA720", Offset = "0x35E8D20", VA = "0x1835EA720")]
		private void OnAttackStart()
		{
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA3")]
		[Address(RVA = "0x35EA880", Offset = "0x35E8E80", VA = "0x1835EA880")]
		private void OnAttackEnd()
		{
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA4")]
		[Address(RVA = "0x35EA9E0", Offset = "0x35E8FE0", VA = "0x1835EA9E0")]
		private void OnTreeChopStart()
		{
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x35EABA0", Offset = "0x35E91A0", VA = "0x1835EABA0")]
		private void OnTreeChopEnd()
		{
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x35EACA0", Offset = "0x35E92A0", VA = "0x1835EACA0")]
		private void OnGroundAttackStart()
		{
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x35EAE00", Offset = "0x35E9400", VA = "0x1835EAE00")]
		private void OnGroundAttackEnd()
		{
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x35EAE20", Offset = "0x35E9420", VA = "0x1835EAE20")]
		private void OnGroundAttackReset()
		{
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0x35EAF10", Offset = "0x35E9510", VA = "0x1835EAF10")]
		protected void ResetAttackParams()
		{
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FAA")]
		[Address(RVA = "0x35EB400", Offset = "0x35E9A00", VA = "0x1835EB400")]
		private void ResetGroundAttackParams(bool forceIdle = false)
		{
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x35EB570", Offset = "0x35E9B70", VA = "0x1835EB570")]
		private void OnGroundAttackFinished()
		{
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x000136E0 File Offset: 0x000118E0
		[Token(Token = "0x6003FAC")]
		[Address(RVA = "0x35EB650", Offset = "0x35E9C50", VA = "0x1835EB650")]
		private bool IsFullBodyIdle()
		{
			return default(bool);
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x000136F8 File Offset: 0x000118F8
		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0x35EB790", Offset = "0x35E9D90", VA = "0x1835EB790")]
		private bool IsFullBodyActive()
		{
			return default(bool);
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0x35EB800", Offset = "0x35E9E00", VA = "0x1835EB800", Slot = "31")]
		protected virtual void QueueTreeAttack()
		{
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FAF")]
		[Address(RVA = "0x35EBA90", Offset = "0x35EA090", VA = "0x1835EBA90")]
		private void CheckDoComboEnder()
		{
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB0")]
		[Address(RVA = "0x35EBC60", Offset = "0x35EA260", VA = "0x1835EBC60")]
		private void DoAttack()
		{
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB1")]
		[Address(RVA = "0x35EC0E0", Offset = "0x35EA6E0", VA = "0x1835EC0E0")]
		private void DoGroundAttack()
		{
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB2")]
		[Address(RVA = "0x35EC430", Offset = "0x35EAA30", VA = "0x1835EC430")]
		protected void LogText(string text)
		{
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x00013710 File Offset: 0x00011910
		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x35EC520", Offset = "0x35EAB20", VA = "0x1835EC520")]
		protected bool CanStashFullBody()
		{
			return default(bool);
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x35EC630", Offset = "0x35EAC30", VA = "0x1835EC630")]
		protected GenericMeleeWeaponController()
		{
		}

		// Token: 0x040034F2 RID: 13554
		[Token(Token = "0x40034F2")]
		[FieldOffset(Offset = "0xD8")]
		private GenericMeleeWeaponController.GroundAttackState _groundAttackState;

		// Token: 0x040034F3 RID: 13555
		[Token(Token = "0x40034F3")]
		[FieldOffset(Offset = "0xDC")]
		private int _groundAttackQueueFrame;

		// Token: 0x040034F4 RID: 13556
		[Token(Token = "0x40034F4")]
		[FieldOffset(Offset = "0xE0")]
		private float _groundAttackQueueTime;

		// Token: 0x040034F5 RID: 13557
		[Token(Token = "0x40034F5")]
		[FieldOffset(Offset = "0xE4")]
		private GenericMeleeWeaponController.AttackInputState _attackInputState;

		// Token: 0x040034F6 RID: 13558
		[Token(Token = "0x40034F6")]
		[FieldOffset(Offset = "0xE8")]
		private bool _checkCombo;

		// Token: 0x040034F7 RID: 13559
		[Token(Token = "0x40034F7")]
		[FieldOffset(Offset = "0xEC")]
		private int _hitDirection;

		// Token: 0x040034F8 RID: 13560
		[Token(Token = "0x40034F8")]
		[FieldOffset(Offset = "0xF0")]
		private int _comboHitSwings;

		// Token: 0x040034F9 RID: 13561
		[Token(Token = "0x40034F9")]
		[FieldOffset(Offset = "0xF4")]
		private bool _attackActive;

		// Token: 0x040034FA RID: 13562
		[Token(Token = "0x40034FA")]
		[FieldOffset(Offset = "0xF5")]
		private bool _treeChopActive;

		// Token: 0x040034FB RID: 13563
		[Token(Token = "0x40034FB")]
		[FieldOffset(Offset = "0xF6")]
		private bool _swingHit;

		// Token: 0x040034FC RID: 13564
		[Token(Token = "0x40034FC")]
		[FieldOffset(Offset = "0xF7")]
		private bool _comboEnderActive;

		// Token: 0x040034FD RID: 13565
		[Token(Token = "0x40034FD")]
		[FieldOffset(Offset = "0xF8")]
		private float _lastHitTime;

		// Token: 0x040034FE RID: 13566
		[Token(Token = "0x40034FE")]
		[FieldOffset(Offset = "0xFC")]
		private bool _movementSlowed;

		// Token: 0x040034FF RID: 13567
		[Token(Token = "0x40034FF")]
		[FieldOffset(Offset = "0x100")]
		private float _buttonPressTime;

		// Token: 0x04003500 RID: 13568
		[Token(Token = "0x4003500")]
		[FieldOffset(Offset = "0x104")]
		private float _attackStateStartTime;

		// Token: 0x04003501 RID: 13569
		[Token(Token = "0x4003501")]
		[FieldOffset(Offset = "0x108")]
		private float _lastAttackStartTime;

		// Token: 0x04003502 RID: 13570
		[Token(Token = "0x4003502")]
		[FieldOffset(Offset = "0x10C")]
		[Tooltip("This is timeout waiting for attack button to trigger animation.")]
		[SerializeField]
		private float _buttonPressTimeout;

		// Token: 0x04003503 RID: 13571
		[Token(Token = "0x4003503")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _canChopTrees;

		// Token: 0x04003504 RID: 13572
		[Token(Token = "0x4003504")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private float _treeSwingStaminaCost;

		// Token: 0x04003505 RID: 13573
		[Token(Token = "0x4003505")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float _treeAttackWaitTimeout;

		// Token: 0x04003506 RID: 13574
		[Token(Token = "0x4003506")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private float _treeCutPlayerRotationSpeed;

		// Token: 0x04003507 RID: 13575
		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _treeCutPlayerMoveSpeed;

		// Token: 0x04003508 RID: 13576
		[Token(Token = "0x4003508")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private float _treeCutMaxDistance;

		// Token: 0x04003509 RID: 13577
		[Token(Token = "0x4003509")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private float _treeHitFrequency;

		// Token: 0x0400350A RID: 13578
		[Token(Token = "0x400350A")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private int _treeMaxSwingHits;

		// Token: 0x0400350B RID: 13579
		[Token(Token = "0x400350B")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private bool _hasChargeAttack;

		// Token: 0x0400350C RID: 13580
		[Token(Token = "0x400350C")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private weaponInfo.SwingType _chargeAttackType;

		// Token: 0x0400350D RID: 13581
		[Token(Token = "0x400350D")]
		[FieldOffset(Offset = "0x138")]
		private float _groundAttackHoldTime;

		// Token: 0x0400350E RID: 13582
		[Token(Token = "0x400350E")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private GenericMeleeWeaponController.GroundAttackType _groundAttackType;

		// Token: 0x0400350F RID: 13583
		[Token(Token = "0x400350F")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private bool _canComboGroundAttack;

		// Token: 0x04003510 RID: 13584
		[Token(Token = "0x4003510")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private GenericMeleeWeaponController.GroundAttackOptions _groundAttackOptions;

		// Token: 0x04003511 RID: 13585
		[Token(Token = "0x4003511")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float _cancelQueuedGroundAttackTime;

		// Token: 0x04003512 RID: 13586
		[Token(Token = "0x4003512")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private float _cancelGroundComboAttackTime;

		// Token: 0x04003513 RID: 13587
		[Token(Token = "0x4003513")]
		[FieldOffset(Offset = "0x150")]
		private bool _debugLog;

		// Token: 0x04003514 RID: 13588
		[Token(Token = "0x4003514")]
		[FieldOffset(Offset = "0x151")]
		[SerializeField]
		private bool _useOnHitCurve;

		// Token: 0x04003515 RID: 13589
		[Token(Token = "0x4003515")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private float _onHitDelay;

		// Token: 0x04003516 RID: 13590
		[Token(Token = "0x4003516")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private float _onHitMinSpeed;

		// Token: 0x04003517 RID: 13591
		[Token(Token = "0x4003517")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x04003518 RID: 13592
		[Token(Token = "0x4003518")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private float _curveDuration;

		// Token: 0x04003519 RID: 13593
		[Token(Token = "0x4003519")]
		[FieldOffset(Offset = "0x170")]
		private readonly ILayerBehaviourActivator[] _fullBodyAttackActivators;

		// Token: 0x0400351A RID: 13594
		[Token(Token = "0x400351A")]
		[FieldOffset(Offset = "0x178")]
		private readonly ILayerBehaviourActivator[] _treeAttackActivators;

		// Token: 0x020008B3 RID: 2227
		[Token(Token = "0x20008B3")]
		private enum GroundAttackState
		{
			// Token: 0x0400351C RID: 13596
			[Token(Token = "0x400351C")]
			Idle,
			// Token: 0x0400351D RID: 13597
			[Token(Token = "0x400351D")]
			Queued,
			// Token: 0x0400351E RID: 13598
			[Token(Token = "0x400351E")]
			Playing,
			// Token: 0x0400351F RID: 13599
			[Token(Token = "0x400351F")]
			ComboQueued
		}

		// Token: 0x020008B4 RID: 2228
		[Token(Token = "0x20008B4")]
		protected enum AttackInputState
		{
			// Token: 0x04003521 RID: 13601
			[Token(Token = "0x4003521")]
			Idle,
			// Token: 0x04003522 RID: 13602
			[Token(Token = "0x4003522")]
			ButtonDown,
			// Token: 0x04003523 RID: 13603
			[Token(Token = "0x4003523")]
			ButtonPress,
			// Token: 0x04003524 RID: 13604
			[Token(Token = "0x4003524")]
			AttackQueued
		}

		// Token: 0x020008B5 RID: 2229
		[Token(Token = "0x20008B5")]
		private enum GroundAttackType
		{
			// Token: 0x04003526 RID: 13606
			[Token(Token = "0x4003526")]
			None,
			// Token: 0x04003527 RID: 13607
			[Token(Token = "0x4003527")]
			Smash
		}

		// Token: 0x020008B6 RID: 2230
		[Token(Token = "0x20008B6")]
		private enum GroundAttackOptions
		{
			// Token: 0x04003529 RID: 13609
			[Token(Token = "0x4003529")]
			SingleClick,
			// Token: 0x0400352A RID: 13610
			[Token(Token = "0x400352A")]
			Hold
		}
	}
}

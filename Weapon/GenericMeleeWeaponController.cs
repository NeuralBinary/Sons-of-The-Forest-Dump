using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000842 RID: 2114
	[Token(Token = "0x2000842")]
	[AddComponentMenu("Sons/Weapon/GenericMeleeWeaponController")]
	public abstract class GenericMeleeWeaponController : MeleeWeaponController
	{
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x00010818 File Offset: 0x0000EA18
		[Token(Token = "0x1700070C")]
		private bool ShowGroundAttackOptions
		{
			[Token(Token = "0x6003867")]
			[Address(RVA = "0x2ECCCB0", Offset = "0x2ECBCB0", VA = "0x182ECCCB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06003868 RID: 14440 RVA: 0x00010830 File Offset: 0x0000EA30
		[Token(Token = "0x1700070D")]
		protected bool InCheckComboWindow
		{
			[Token(Token = "0x6003868")]
			[Address(RVA = "0x22EB760", Offset = "0x22EA760", VA = "0x1822EB760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x00010848 File Offset: 0x0000EA48
		[Token(Token = "0x1700070E")]
		protected bool AttackActive
		{
			[Token(Token = "0x6003869")]
			[Address(RVA = "0x22EB740", Offset = "0x22EA740", VA = "0x1822EB740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600386A RID: 14442 RVA: 0x00010860 File Offset: 0x0000EA60
		[Token(Token = "0x1700070F")]
		public float TreeHitFrequency
		{
			[Token(Token = "0x600386A")]
			[Address(RVA = "0x2398C40", Offset = "0x2397C40", VA = "0x182398C40")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x00010878 File Offset: 0x0000EA78
		[Token(Token = "0x17000710")]
		public int TreeMaxSwingHits
		{
			[Token(Token = "0x600386B")]
			[Address(RVA = "0x2ECCCC0", Offset = "0x2ECBCC0", VA = "0x182ECCCC0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386C")]
		[Address(RVA = "0x2ECAA80", Offset = "0x2EC9A80", VA = "0x182ECAA80", Slot = "10")]
		protected override void OnInitialized()
		{
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386D")]
		[Address(RVA = "0x2ECA6F0", Offset = "0x2EC96F0", VA = "0x182ECA6F0", Slot = "24")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386E")]
		[Address(RVA = "0x2ECA4E0", Offset = "0x2EC94E0", VA = "0x182ECA4E0", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386F")]
		[Address(RVA = "0x2ECB3E0", Offset = "0x2ECA3E0", VA = "0x182ECB3E0")]
		private void ResetAllParams()
		{
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003870")]
		[Address(RVA = "0x2ECA350", Offset = "0x2EC9350", VA = "0x182ECA350", Slot = "11")]
		protected override void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003871")]
		[Address(RVA = "0x2EC9D80", Offset = "0x2EC8D80", VA = "0x182EC9D80", Slot = "12")]
		protected override void OnAttackBlocked(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003872")]
		[Address(RVA = "0x2ECB820", Offset = "0x2ECA820", VA = "0x182ECB820")]
		protected void SetAttackState(GenericMeleeWeaponController.AttackInputState newInputState)
		{
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003873")]
		[Address(RVA = "0x2ECB8E0", Offset = "0x2ECA8E0", VA = "0x182ECB8E0")]
		private void SetGroundAttackState(GenericMeleeWeaponController.GroundAttackState groundAttackState)
		{
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003874")]
		[Address(RVA = "0x2ECC090", Offset = "0x2ECB090", VA = "0x182ECC090", Slot = "18")]
		protected override void UpdateAttackState()
		{
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003875")]
		[Address(RVA = "0x2ECC8A0", Offset = "0x2ECB8A0", VA = "0x182ECC8A0")]
		private void UpdateSwingSpeedAfterHit()
		{
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003876")]
		[Address(RVA = "0x2ECC960", Offset = "0x2ECB960", VA = "0x182ECC960")]
		private void UpdateTreeAttack()
		{
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003877")]
		[Address(RVA = "0x2ECC670", Offset = "0x2ECB670", VA = "0x182ECC670")]
		protected void UpdatePlayerMovementSlow(bool slowed)
		{
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x00010890 File Offset: 0x0000EA90
		[Token(Token = "0x6003878")]
		[Address(RVA = "0x2EC9B70", Offset = "0x2EC8B70", VA = "0x182EC9B70")]
		private bool IsAttackHeld()
		{
			return default(bool);
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x000108A8 File Offset: 0x0000EAA8
		[Token(Token = "0x6003879")]
		[Address(RVA = "0x2ECBB00", Offset = "0x2ECAB00", VA = "0x182ECBB00")]
		private bool ShouldDoComboEnder()
		{
			return default(bool);
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x000108C0 File Offset: 0x0000EAC0
		[Token(Token = "0x600387A")]
		[Address(RVA = "0x2EC9B60", Offset = "0x2EC8B60", VA = "0x182EC9B60", Slot = "25")]
		protected virtual bool HasChargeAttack()
		{
			return default(bool);
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x000108D8 File Offset: 0x0000EAD8
		[Token(Token = "0x600387B")]
		[Address(RVA = "0x2ECBA20", Offset = "0x2ECAA20", VA = "0x182ECBA20", Slot = "26")]
		protected virtual bool ShouldChopTree()
		{
			return default(bool);
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x000108F0 File Offset: 0x0000EAF0
		[Token(Token = "0x600387C")]
		[Address(RVA = "0x2ECBBA0", Offset = "0x2ECABA0", VA = "0x182ECBBA0", Slot = "27")]
		protected virtual bool ShouldGroundAttack()
		{
			return default(bool);
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00010908 File Offset: 0x0000EB08
		[Token(Token = "0x600387D")]
		[Address(RVA = "0x2EC93B0", Offset = "0x2EC83B0", VA = "0x182EC93B0")]
		private bool CanStartAttack()
		{
			return default(bool);
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600387E")]
		[Address(RVA = "0x2EC91B0", Offset = "0x2EC81B0", VA = "0x182EC91B0", Slot = "14")]
		protected override void AttackButtonDown()
		{
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600387F")]
		[Address(RVA = "0x2EC92F0", Offset = "0x2EC82F0", VA = "0x182EC92F0", Slot = "15")]
		protected override void AttackHeld()
		{
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003880")]
		[Address(RVA = "0x2EC92D0", Offset = "0x2EC82D0", VA = "0x182EC92D0", Slot = "16")]
		protected override void AttackHeldEnded()
		{
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003881")]
		[Address(RVA = "0x2ECAF70", Offset = "0x2EC9F70", VA = "0x182ECAF70", Slot = "28")]
		protected virtual void RegisterEvents()
		{
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003882")]
		[Address(RVA = "0x2ECBC30", Offset = "0x2ECAC30", VA = "0x182ECBC30", Slot = "29")]
		protected virtual void UnregisterEvents()
		{
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003883")]
		[Address(RVA = "0x2ECAB20", Offset = "0x2EC9B20", VA = "0x182ECAB20")]
		private void OnParryActive(bool active)
		{
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x2ECA300", Offset = "0x2EC9300", VA = "0x182ECA300")]
		private void OnCheckComboStart()
		{
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x2ECA2B0", Offset = "0x2EC92B0", VA = "0x182ECA2B0")]
		private void OnCheckComboEnd()
		{
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x2ECA060", Offset = "0x2EC9060", VA = "0x182ECA060")]
		private void OnAttackStarted(weaponInfo.SwingType swingType)
		{
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003887")]
		[Address(RVA = "0x2ECB9F0", Offset = "0x2ECA9F0", VA = "0x182ECB9F0", Slot = "30")]
		protected virtual void SetSwingType(weaponInfo.SwingType swingType)
		{
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003888")]
		[Address(RVA = "0x2ECA160", Offset = "0x2EC9160", VA = "0x182ECA160")]
		private void OnChargeAttackStart()
		{
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003889")]
		[Address(RVA = "0x2ECA0C0", Offset = "0x2EC90C0", VA = "0x182ECA0C0")]
		private void OnChargeAttackEnd()
		{
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388A")]
		[Address(RVA = "0x2EC9F40", Offset = "0x2EC8F40", VA = "0x182EC9F40")]
		private void OnAttackStart()
		{
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388B")]
		[Address(RVA = "0x2EC9E60", Offset = "0x2EC8E60", VA = "0x182EC9E60")]
		private void OnAttackEnd()
		{
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388C")]
		[Address(RVA = "0x2ECAC70", Offset = "0x2EC9C70", VA = "0x182ECAC70")]
		private void OnTreeChopStart()
		{
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388D")]
		[Address(RVA = "0x2ECABB0", Offset = "0x2EC9BB0", VA = "0x182ECABB0")]
		private void OnTreeChopEnd()
		{
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388E")]
		[Address(RVA = "0x2ECA920", Offset = "0x2EC9920", VA = "0x182ECA920")]
		private void OnGroundAttackStart()
		{
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388F")]
		[Address(RVA = "0x2ECA770", Offset = "0x2EC9770", VA = "0x182ECA770")]
		private void OnGroundAttackEnd()
		{
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003890")]
		[Address(RVA = "0x2ECA830", Offset = "0x2EC9830", VA = "0x182ECA830")]
		private void OnGroundAttackReset()
		{
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003891")]
		[Address(RVA = "0x2ECB510", Offset = "0x2ECA510", VA = "0x182ECB510")]
		protected void ResetAttackParams()
		{
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003892")]
		[Address(RVA = "0x2ECB750", Offset = "0x2ECA750", VA = "0x182ECB750")]
		private void ResetGroundAttackParams(bool forceIdle = false)
		{
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003893")]
		[Address(RVA = "0x2ECA790", Offset = "0x2EC9790", VA = "0x182ECA790")]
		private void OnGroundAttackFinished()
		{
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00010920 File Offset: 0x0000EB20
		[Token(Token = "0x6003894")]
		[Address(RVA = "0x2EC9BF0", Offset = "0x2EC8BF0", VA = "0x182EC9BF0")]
		private bool IsFullBodyIdle()
		{
			return default(bool);
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00010938 File Offset: 0x0000EB38
		[Token(Token = "0x6003895")]
		[Address(RVA = "0x2EC9BC0", Offset = "0x2EC8BC0", VA = "0x182EC9BC0")]
		private bool IsFullBodyActive()
		{
			return default(bool);
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003896")]
		[Address(RVA = "0x2ECADF0", Offset = "0x2EC9DF0", VA = "0x182ECADF0", Slot = "31")]
		protected virtual void QueueTreeAttack()
		{
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003897")]
		[Address(RVA = "0x2EC9560", Offset = "0x2EC8560", VA = "0x182EC9560")]
		private void CheckDoComboEnder()
		{
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003898")]
		[Address(RVA = "0x2EC96F0", Offset = "0x2EC86F0", VA = "0x182EC96F0")]
		private void DoAttack()
		{
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003899")]
		[Address(RVA = "0x2EC9960", Offset = "0x2EC8960", VA = "0x182EC9960")]
		private void DoGroundAttack()
		{
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389A")]
		[Address(RVA = "0x2EC9CD0", Offset = "0x2EC8CD0", VA = "0x182EC9CD0")]
		protected void LogText(string text)
		{
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00010950 File Offset: 0x0000EB50
		[Token(Token = "0x600389B")]
		[Address(RVA = "0x2EC94C0", Offset = "0x2EC84C0", VA = "0x182EC94C0")]
		protected bool CanStashFullBody()
		{
			return default(bool);
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389C")]
		[Address(RVA = "0x2ECC970", Offset = "0x2ECB970", VA = "0x182ECC970")]
		protected GenericMeleeWeaponController()
		{
		}

		// Token: 0x0400302B RID: 12331
		[Token(Token = "0x400302B")]
		[FieldOffset(Offset = "0xD8")]
		private GenericMeleeWeaponController.GroundAttackState _groundAttackState;

		// Token: 0x0400302C RID: 12332
		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0xDC")]
		private int _groundAttackQueueFrame;

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0xE0")]
		private float _groundAttackQueueTime;

		// Token: 0x0400302E RID: 12334
		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0xE4")]
		private GenericMeleeWeaponController.AttackInputState _attackInputState;

		// Token: 0x0400302F RID: 12335
		[Token(Token = "0x400302F")]
		[FieldOffset(Offset = "0xE8")]
		private bool _checkCombo;

		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0xEC")]
		private int _hitDirection;

		// Token: 0x04003031 RID: 12337
		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0xF0")]
		private int _comboHitSwings;

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0xF4")]
		private bool _attackActive;

		// Token: 0x04003033 RID: 12339
		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0xF5")]
		private bool _treeChopActive;

		// Token: 0x04003034 RID: 12340
		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0xF6")]
		private bool _swingHit;

		// Token: 0x04003035 RID: 12341
		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0xF7")]
		private bool _comboEnderActive;

		// Token: 0x04003036 RID: 12342
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0xF8")]
		private float _lastHitTime;

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0xFC")]
		private bool _movementSlowed;

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x100")]
		private float _buttonPressTime;

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x104")]
		private float _attackStateStartTime;

		// Token: 0x0400303A RID: 12346
		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x108")]
		private float _lastAttackStartTime;

		// Token: 0x0400303B RID: 12347
		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		[Tooltip("This is timeout waiting for attack button to trigger animation.")]
		private float _buttonPressTimeout;

		// Token: 0x0400303C RID: 12348
		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _canChopTrees;

		// Token: 0x0400303D RID: 12349
		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private float _treeSwingStaminaCost;

		// Token: 0x0400303E RID: 12350
		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float _treeAttackWaitTimeout;

		// Token: 0x0400303F RID: 12351
		[Token(Token = "0x400303F")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private float _treeCutPlayerRotationSpeed;

		// Token: 0x04003040 RID: 12352
		[Token(Token = "0x4003040")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _treeCutPlayerMoveSpeed;

		// Token: 0x04003041 RID: 12353
		[Token(Token = "0x4003041")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private float _treeCutMaxDistance;

		// Token: 0x04003042 RID: 12354
		[Token(Token = "0x4003042")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private float _treeHitFrequency;

		// Token: 0x04003043 RID: 12355
		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private int _treeMaxSwingHits;

		// Token: 0x04003044 RID: 12356
		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private bool _hasChargeAttack;

		// Token: 0x04003045 RID: 12357
		[Token(Token = "0x4003045")]
		[FieldOffset(Offset = "0x134")]
		private float _groundAttackHoldTime;

		// Token: 0x04003046 RID: 12358
		[Token(Token = "0x4003046")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private GenericMeleeWeaponController.GroundAttackType _groundAttackType;

		// Token: 0x04003047 RID: 12359
		[Token(Token = "0x4003047")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private bool _canComboGroundAttack;

		// Token: 0x04003048 RID: 12360
		[Token(Token = "0x4003048")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GenericMeleeWeaponController.GroundAttackOptions _groundAttackOptions;

		// Token: 0x04003049 RID: 12361
		[Token(Token = "0x4003049")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private float _cancelQueuedGroundAttackTime;

		// Token: 0x0400304A RID: 12362
		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float _cancelGroundComboAttackTime;

		// Token: 0x0400304B RID: 12363
		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x14C")]
		private bool _debugLog;

		// Token: 0x0400304C RID: 12364
		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x14D")]
		[SerializeField]
		private bool _useOnHitCurve;

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private float _onHitDelay;

		// Token: 0x0400304E RID: 12366
		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private float _onHitMinSpeed;

		// Token: 0x0400304F RID: 12367
		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x04003050 RID: 12368
		[Token(Token = "0x4003050")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private float _curveDuration;

		// Token: 0x04003051 RID: 12369
		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x168")]
		private readonly ILayerBehaviourActivator[] _fullBodyAttackActivators;

		// Token: 0x04003052 RID: 12370
		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x170")]
		private readonly ILayerBehaviourActivator[] _treeAttackActivators;

		// Token: 0x02000843 RID: 2115
		[Token(Token = "0x2000843")]
		private enum GroundAttackState
		{
			// Token: 0x04003054 RID: 12372
			[Token(Token = "0x4003054")]
			Idle,
			// Token: 0x04003055 RID: 12373
			[Token(Token = "0x4003055")]
			Queued,
			// Token: 0x04003056 RID: 12374
			[Token(Token = "0x4003056")]
			Playing,
			// Token: 0x04003057 RID: 12375
			[Token(Token = "0x4003057")]
			ComboQueued
		}

		// Token: 0x02000844 RID: 2116
		[Token(Token = "0x2000844")]
		protected enum AttackInputState
		{
			// Token: 0x04003059 RID: 12377
			[Token(Token = "0x4003059")]
			Idle,
			// Token: 0x0400305A RID: 12378
			[Token(Token = "0x400305A")]
			ButtonDown,
			// Token: 0x0400305B RID: 12379
			[Token(Token = "0x400305B")]
			ButtonPress,
			// Token: 0x0400305C RID: 12380
			[Token(Token = "0x400305C")]
			AttackQueued
		}

		// Token: 0x02000845 RID: 2117
		[Token(Token = "0x2000845")]
		private enum GroundAttackType
		{
			// Token: 0x0400305E RID: 12382
			[Token(Token = "0x400305E")]
			None,
			// Token: 0x0400305F RID: 12383
			[Token(Token = "0x400305F")]
			Smash
		}

		// Token: 0x02000846 RID: 2118
		[Token(Token = "0x2000846")]
		private enum GroundAttackOptions
		{
			// Token: 0x04003061 RID: 12385
			[Token(Token = "0x4003061")]
			SingleClick,
			// Token: 0x04003062 RID: 12386
			[Token(Token = "0x4003062")]
			Hold
		}
	}
}

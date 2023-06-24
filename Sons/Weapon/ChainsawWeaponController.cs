using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008A5 RID: 2213
	[Token(Token = "0x20008A5")]
	[AddComponentMenu("Sons/Weapon/ChainsawWeaponController")]
	public class ChainsawWeaponController : GenericMeleeWeaponController, IItemInstanceModuleConsumer
	{
		// Token: 0x06003F0F RID: 16143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F0F")]
		[Address(RVA = "0x35DE020", Offset = "0x35DC620", VA = "0x1835DE020", Slot = "32")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F10")]
		[Address(RVA = "0x35DE130", Offset = "0x35DC730", VA = "0x1835DE130", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F11")]
		[Address(RVA = "0x35DE3C0", Offset = "0x35DC9C0", VA = "0x1835DE3C0", Slot = "29")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F12")]
		[Address(RVA = "0x35DE650", Offset = "0x35DCC50", VA = "0x1835DE650")]
		private void OnChainSawHoldAttack(bool active)
		{
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F13")]
		[Address(RVA = "0x35DE680", Offset = "0x35DCC80", VA = "0x1835DE680", Slot = "17")]
		internal override void Update()
		{
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F14")]
		[Address(RVA = "0x35DE6D0", Offset = "0x35DCCD0", VA = "0x1835DE6D0")]
		private void UpdateRevved()
		{
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F15")]
		[Address(RVA = "0x35DEB20", Offset = "0x35DD120", VA = "0x1835DEB20")]
		private void UpdateLocalPlayer()
		{
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F16")]
		[Address(RVA = "0x35DEE90", Offset = "0x35DD490", VA = "0x1835DEE90")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F17")]
		[Address(RVA = "0x35DEF80", Offset = "0x35DD580", VA = "0x1835DEF80")]
		private void UpdateTreeCuttingLocal(bool attackHeld)
		{
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x00013308 File Offset: 0x00011508
		[Token(Token = "0x6003F18")]
		[Address(RVA = "0x35DF340", Offset = "0x35DD940", VA = "0x1835DF340", Slot = "22")]
		protected override bool IsBlocking()
		{
			return default(bool);
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x00013320 File Offset: 0x00011520
		[Token(Token = "0x6003F19")]
		[Address(RVA = "0x35DF550", Offset = "0x35DDB50", VA = "0x1835DF550")]
		private bool HasPower()
		{
			return default(bool);
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F1A")]
		[Address(RVA = "0x35DF580", Offset = "0x35DDB80", VA = "0x1835DF580")]
		private void DrainBattery()
		{
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x00013338 File Offset: 0x00011538
		[Token(Token = "0x6003F1B")]
		[Address(RVA = "0x35DF620", Offset = "0x35DDC20", VA = "0x1835DF620", Slot = "25")]
		protected override bool HasChargeAttack()
		{
			return default(bool);
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x00013350 File Offset: 0x00011550
		[Token(Token = "0x6003F1C")]
		[Address(RVA = "0x35DF660", Offset = "0x35DDC60", VA = "0x1835DF660", Slot = "26")]
		protected override bool ShouldChopTree()
		{
			return default(bool);
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F1D")]
		[Address(RVA = "0x35DF7E0", Offset = "0x35DDDE0", VA = "0x1835DF7E0", Slot = "15")]
		protected override void AttackHeld()
		{
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0x35DF8D0", Offset = "0x35DDED0", VA = "0x1835DF8D0", Slot = "31")]
		protected override void QueueTreeAttack()
		{
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x00013368 File Offset: 0x00011568
		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0x35DFA30", Offset = "0x35DE030", VA = "0x1835DFA30", Slot = "27")]
		protected override bool ShouldGroundAttack()
		{
			return default(bool);
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F20")]
		[Address(RVA = "0x35DFB40", Offset = "0x35DE140", VA = "0x1835DFB40")]
		private ChainsawChain GetChain()
		{
			return null;
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F21")]
		[Address(RVA = "0x35DFD20", Offset = "0x35DE320", VA = "0x1835DFD20", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x00013380 File Offset: 0x00011580
		[Token(Token = "0x6003F22")]
		[Address(RVA = "0x35DFD40", Offset = "0x35DE340", VA = "0x1835DFD40", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F23")]
		[Address(RVA = "0x35DFDF0", Offset = "0x35DE3F0", VA = "0x1835DFDF0")]
		private void AffirmEventStarted()
		{
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F24")]
		[Address(RVA = "0x35DFF10", Offset = "0x35DE510", VA = "0x1835DFF10")]
		private void StopEvent()
		{
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F25")]
		[Address(RVA = "0x35E0020", Offset = "0x35DE620", VA = "0x1835E0020")]
		private void SetCuttingParameter(float value)
		{
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F26")]
		[Address(RVA = "0x35E0090", Offset = "0x35DE690", VA = "0x1835E0090")]
		private void SetCuttingFleshParameter(float value)
		{
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F27")]
		[Address(RVA = "0x35E0100", Offset = "0x35DE700", VA = "0x1835E0100")]
		private void SetCuttingTreeParameter(float value)
		{
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F28")]
		[Address(RVA = "0x35E0170", Offset = "0x35DE770", VA = "0x1835E0170")]
		private void UpdateAudio(bool revved)
		{
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F29")]
		[Address(RVA = "0x35E06A0", Offset = "0x35DECA0", VA = "0x1835E06A0")]
		public ChainsawWeaponController()
		{
		}

		// Token: 0x040034B2 RID: 13490
		[Token(Token = "0x40034B2")]
		[FieldOffset(Offset = "0x180")]
		[Min(0f)]
		[SerializeField]
		private float _idleChainSpeed;

		// Token: 0x040034B3 RID: 13491
		[Token(Token = "0x40034B3")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		[Min(0f)]
		private float _activeChainSpeed;

		// Token: 0x040034B4 RID: 13492
		[Token(Token = "0x40034B4")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Min(0f)]
		private float _chainLerpSpeed;

		// Token: 0x040034B5 RID: 13493
		[Token(Token = "0x40034B5")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Collider _chainCollider;

		// Token: 0x040034B6 RID: 13494
		[Token(Token = "0x40034B6")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private float _fullChargeDurationMinutes;

		// Token: 0x040034B7 RID: 13495
		[Token(Token = "0x40034B7")]
		[FieldOffset(Offset = "0x19C")]
		[Range(0f, 1f)]
		private float _remainingPower;

		// Token: 0x040034B8 RID: 13496
		[Token(Token = "0x40034B8")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private BatteryIndicator _batteryIndicator;

		// Token: 0x040034B9 RID: 13497
		[Token(Token = "0x40034B9")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _batteryItemId;

		// Token: 0x040034BA RID: 13498
		[Token(Token = "0x40034BA")]
		[FieldOffset(Offset = "0x1AC")]
		[SerializeField]
		private float _autoRefilThreshold;

		// Token: 0x040034BB RID: 13499
		[Token(Token = "0x40034BB")]
		[FieldOffset(Offset = "0x1B0")]
		[EventRef]
		[SerializeField]
		private string _replaceBatteryAudioEvent;

		// Token: 0x040034BC RID: 13500
		[Token(Token = "0x40034BC")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private float _treeCutAnimHeightCenter;

		// Token: 0x040034BD RID: 13501
		[Token(Token = "0x40034BD")]
		[FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		private float _treeCutAnimHeightMult;

		// Token: 0x040034BE RID: 13502
		[Token(Token = "0x40034BE")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private bool _debugTreeHeight;

		// Token: 0x040034BF RID: 13503
		[Token(Token = "0x40034BF")]
		[FieldOffset(Offset = "0x1C4")]
		[SerializeField]
		private float _attackRepeatTime;

		// Token: 0x040034C0 RID: 13504
		[Token(Token = "0x40034C0")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private float _holdAttackStaminaRate;

		// Token: 0x040034C1 RID: 13505
		[Token(Token = "0x40034C1")]
		[FieldOffset(Offset = "0x1D0")]
		private ChainsawChain _chainController;

		// Token: 0x040034C2 RID: 13506
		[Token(Token = "0x40034C2")]
		[FieldOffset(Offset = "0x1D8")]
		private float _chainSpeed;

		// Token: 0x040034C3 RID: 13507
		[Token(Token = "0x40034C3")]
		[FieldOffset(Offset = "0x1DC")]
		private float _targetChainSpeed;

		// Token: 0x040034C4 RID: 13508
		[Token(Token = "0x40034C4")]
		[FieldOffset(Offset = "0x1E0")]
		private VolumeContainerItemInstanceModule _powerCapacity;

		// Token: 0x040034C5 RID: 13509
		[Token(Token = "0x40034C5")]
		[FieldOffset(Offset = "0x1E8")]
		private float _powerDrainRate;

		// Token: 0x040034C6 RID: 13510
		[Token(Token = "0x40034C6")]
		[FieldOffset(Offset = "0x1EC")]
		private float _treeHeightBlend;

		// Token: 0x040034C7 RID: 13511
		[Token(Token = "0x40034C7")]
		[FieldOffset(Offset = "0x1F0")]
		private bool _isTreeAttack;

		// Token: 0x040034C8 RID: 13512
		[Token(Token = "0x40034C8")]
		[FieldOffset(Offset = "0x1F4")]
		private int _chainSawHoldAttackAnimActive;

		// Token: 0x040034C9 RID: 13513
		[Token(Token = "0x40034C9")]
		[FieldOffset(Offset = "0x1F8")]
		private float _lastColliderRefreshTime;

		// Token: 0x040034CA RID: 13514
		[Token(Token = "0x40034CA")]
		[FieldOffset(Offset = "0x1FC")]
		private bool _anyAttackHeld;

		// Token: 0x040034CB RID: 13515
		[Token(Token = "0x40034CB")]
		[FieldOffset(Offset = "0x200")]
		private EventInstance _audioEventInstance;

		// Token: 0x040034CC RID: 13516
		[Token(Token = "0x40034CC")]
		[FieldOffset(Offset = "0x208")]
		private float _lastNoiseStimuliTime;

		// Token: 0x040034CD RID: 13517
		[Token(Token = "0x40034CD")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private ChainSawBladeTrigger _bladeTrigger;
	}
}

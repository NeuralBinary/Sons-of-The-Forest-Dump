using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000835 RID: 2101
	[Token(Token = "0x2000835")]
	[AddComponentMenu("Sons/Weapon/ChainsawWeaponController")]
	public class ChainsawWeaponController : GenericMeleeWeaponController, IItemInstanceModuleConsumer
	{
		// Token: 0x060037FF RID: 14335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x2EB4580", Offset = "0x2EB3580", VA = "0x182EB4580", Slot = "32")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003800")]
		[Address(RVA = "0x2EB4760", Offset = "0x2EB3760", VA = "0x182EB4760", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003801")]
		[Address(RVA = "0x2EB4B10", Offset = "0x2EB3B10", VA = "0x182EB4B10", Slot = "29")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003802")]
		[Address(RVA = "0x2EB4650", Offset = "0x2EB3650", VA = "0x182EB4650")]
		private void OnChainSawHoldAttack(bool active)
		{
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003803")]
		[Address(RVA = "0x2EB57E0", Offset = "0x2EB47E0", VA = "0x182EB57E0", Slot = "17")]
		internal override void Update()
		{
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003804")]
		[Address(RVA = "0x2EB5040", Offset = "0x2EB4040", VA = "0x182EB5040")]
		private void UpdateLocalPlayer()
		{
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003805")]
		[Address(RVA = "0x2EB41E0", Offset = "0x2EB31E0", VA = "0x182EB41E0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003806")]
		[Address(RVA = "0x2EB55B0", Offset = "0x2EB45B0", VA = "0x182EB55B0")]
		private void UpdateTreeCuttingLocal(bool attackHeld)
		{
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x000105A8 File Offset: 0x0000E7A8
		[Token(Token = "0x6003807")]
		[Address(RVA = "0x2EB4410", Offset = "0x2EB3410", VA = "0x182EB4410", Slot = "22")]
		protected override bool IsBlocking()
		{
			return default(bool);
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x000105C0 File Offset: 0x0000E7C0
		[Token(Token = "0x6003808")]
		[Address(RVA = "0x2EB43E0", Offset = "0x2EB33E0", VA = "0x182EB43E0")]
		private bool HasPower()
		{
			return default(bool);
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003809")]
		[Address(RVA = "0x2EB4170", Offset = "0x2EB3170", VA = "0x182EB4170")]
		private void DrainBattery()
		{
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x000105D8 File Offset: 0x0000E7D8
		[Token(Token = "0x600380A")]
		[Address(RVA = "0x2EB43A0", Offset = "0x2EB33A0", VA = "0x182EB43A0", Slot = "25")]
		protected override bool HasChargeAttack()
		{
			return default(bool);
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x000105F0 File Offset: 0x0000E7F0
		[Token(Token = "0x600380B")]
		[Address(RVA = "0x2EB4980", Offset = "0x2EB3980", VA = "0x182EB4980", Slot = "26")]
		protected override bool ShouldChopTree()
		{
			return default(bool);
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380C")]
		[Address(RVA = "0x2EB4130", Offset = "0x2EB3130", VA = "0x182EB4130", Slot = "15")]
		protected override void AttackHeld()
		{
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380D")]
		[Address(RVA = "0x2EB4680", Offset = "0x2EB3680", VA = "0x182EB4680", Slot = "31")]
		protected override void QueueTreeAttack()
		{
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x00010608 File Offset: 0x0000E808
		[Token(Token = "0x600380E")]
		[Address(RVA = "0x2EB49C0", Offset = "0x2EB39C0", VA = "0x182EB49C0", Slot = "27")]
		protected override bool ShouldGroundAttack()
		{
			return default(bool);
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x2EB42D0", Offset = "0x2EB32D0", VA = "0x182EB42D0")]
		private ChainsawChain GetChain()
		{
			return null;
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003810")]
		[Address(RVA = "0x2EB4660", Offset = "0x2EB3660", VA = "0x182EB4660", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00010620 File Offset: 0x0000E820
		[Token(Token = "0x6003811")]
		[Address(RVA = "0x2EB44C0", Offset = "0x2EB34C0", VA = "0x182EB44C0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003812")]
		[Address(RVA = "0x2EB3FC0", Offset = "0x2EB2FC0", VA = "0x182EB3FC0")]
		private void AffirmEventStarted()
		{
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003813")]
		[Address(RVA = "0x2EB4A00", Offset = "0x2EB3A00", VA = "0x182EB4A00")]
		private void StopEvent()
		{
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003814")]
		[Address(RVA = "0x2EB48A0", Offset = "0x2EB38A0", VA = "0x182EB48A0")]
		private void SetCuttingParameter(float value)
		{
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003815")]
		[Address(RVA = "0x2EB4830", Offset = "0x2EB3830", VA = "0x182EB4830")]
		private void SetCuttingFleshParameter(float value)
		{
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003816")]
		[Address(RVA = "0x2EB4910", Offset = "0x2EB3910", VA = "0x182EB4910")]
		private void SetCuttingTreeParameter(float value)
		{
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x2EB4BE0", Offset = "0x2EB3BE0", VA = "0x182EB4BE0")]
		private void UpdateAudio()
		{
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003818")]
		[Address(RVA = "0x2EB5820", Offset = "0x2EB4820", VA = "0x182EB5820")]
		public ChainsawWeaponController()
		{
		}

		// Token: 0x04002FEC RID: 12268
		[Token(Token = "0x4002FEC")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Min(0f)]
		private float _idleChainSpeed;

		// Token: 0x04002FED RID: 12269
		[Token(Token = "0x4002FED")]
		[FieldOffset(Offset = "0x17C")]
		[SerializeField]
		[Min(0f)]
		private float _activeChainSpeed;

		// Token: 0x04002FEE RID: 12270
		[Token(Token = "0x4002FEE")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Min(0f)]
		private float _chainLerpSpeed;

		// Token: 0x04002FEF RID: 12271
		[Token(Token = "0x4002FEF")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Collider _chainCollider;

		// Token: 0x04002FF0 RID: 12272
		[Token(Token = "0x4002FF0")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private float _fullChargeDurationMinutes;

		// Token: 0x04002FF1 RID: 12273
		[Token(Token = "0x4002FF1")]
		[FieldOffset(Offset = "0x194")]
		[Range(0f, 1f)]
		private float _remainingPower;

		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private BatteryIndicator _batteryIndicator;

		// Token: 0x04002FF3 RID: 12275
		[Token(Token = "0x4002FF3")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _batteryItemId;

		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		[FieldOffset(Offset = "0x1A4")]
		[SerializeField]
		private float _autoRefilThreshold;

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0x1A8")]
		[EventRef]
		[SerializeField]
		private string _replaceBatteryAudioEvent;

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private float _treeCutAnimHeightCenter;

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0x1B4")]
		[SerializeField]
		private float _treeCutAnimHeightMult;

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private bool _debugTreeHeight;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		private float _attackRepeatTime;

		// Token: 0x04002FFA RID: 12282
		[Token(Token = "0x4002FFA")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private float _holdAttackStaminaRate;

		// Token: 0x04002FFB RID: 12283
		[Token(Token = "0x4002FFB")]
		[FieldOffset(Offset = "0x1C8")]
		private ChainsawChain _chainController;

		// Token: 0x04002FFC RID: 12284
		[Token(Token = "0x4002FFC")]
		[FieldOffset(Offset = "0x1D0")]
		private float _chainSpeed;

		// Token: 0x04002FFD RID: 12285
		[Token(Token = "0x4002FFD")]
		[FieldOffset(Offset = "0x1D4")]
		private float _targetChainSpeed;

		// Token: 0x04002FFE RID: 12286
		[Token(Token = "0x4002FFE")]
		[FieldOffset(Offset = "0x1D8")]
		private VolumeContainerItemInstanceModule _powerCapacity;

		// Token: 0x04002FFF RID: 12287
		[Token(Token = "0x4002FFF")]
		[FieldOffset(Offset = "0x1E0")]
		private float _powerDrainRate;

		// Token: 0x04003000 RID: 12288
		[Token(Token = "0x4003000")]
		[FieldOffset(Offset = "0x1E4")]
		private float _treeHeightBlend;

		// Token: 0x04003001 RID: 12289
		[Token(Token = "0x4003001")]
		[FieldOffset(Offset = "0x1E8")]
		private bool _isTreeAttack;

		// Token: 0x04003002 RID: 12290
		[Token(Token = "0x4003002")]
		[FieldOffset(Offset = "0x1E9")]
		private bool _chainSawHoldAttackActive;

		// Token: 0x04003003 RID: 12291
		[Token(Token = "0x4003003")]
		[FieldOffset(Offset = "0x1EC")]
		private float _lastColliderRefreshTime;

		// Token: 0x04003004 RID: 12292
		[Token(Token = "0x4003004")]
		[FieldOffset(Offset = "0x1F0")]
		private bool _anyAttackHeld;

		// Token: 0x04003005 RID: 12293
		[Token(Token = "0x4003005")]
		[FieldOffset(Offset = "0x1F8")]
		private EventInstance _audioEventInstance;

		// Token: 0x04003006 RID: 12294
		[Token(Token = "0x4003006")]
		[FieldOffset(Offset = "0x200")]
		private float _lastNoiseStimuliTime;

		// Token: 0x04003007 RID: 12295
		[Token(Token = "0x4003007")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private ChainSawBladeTrigger _bladeTrigger;
	}
}

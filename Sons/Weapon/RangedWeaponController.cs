using System;
using System.Collections;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Animation;
using Sons.FieldOfView;
using Sons.Gameplay;
using Sons.Inventory;
using Sons.Items.Core;
using Sons.Multiplayer.Client;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x020008CB RID: 2251
	[Token(Token = "0x20008CB")]
	[AddComponentMenu("Sons/Weapon/RangedWeaponController")]
	public abstract class RangedWeaponController : HeldControllerBase
	{
		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x00013A58 File Offset: 0x00011C58
		[Token(Token = "0x1700083C")]
		protected bool IsAiming
		{
			[Token(Token = "0x600404C")]
			[Address(RVA = "0x35F8680", Offset = "0x35F6C80", VA = "0x1835F8680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404D")]
		[Address(RVA = "0xA50BF0", Offset = "0xA4F1F0", VA = "0x180A50BF0")]
		public void ShowProjectileVisual(bool value)
		{
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x00013A70 File Offset: 0x00011C70
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "10")]
		internal virtual bool ShouldShowMuzzleFlash()
		{
			return default(bool);
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404F")]
		[Address(RVA = "0x35F86B0", Offset = "0x35F6CB0", VA = "0x1835F86B0")]
		private void Awake()
		{
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004050")]
		[Address(RVA = "0x61C560", Offset = "0x61AB60", VA = "0x18061C560")]
		private void OnRenderableLoaded(Transform renderableTransform)
		{
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004051")]
		[Address(RVA = "0x35F87D0", Offset = "0x35F6DD0", VA = "0x1835F87D0", Slot = "11")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004052")]
		[Address(RVA = "0x35F8940", Offset = "0x35F6F40", VA = "0x1835F8940", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004053")]
		[Address(RVA = "0x35F8AA0", Offset = "0x35F70A0", VA = "0x1835F8AA0", Slot = "12")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004054")]
		[Address(RVA = "0x26FC740", Offset = "0x26FAD40", VA = "0x1826FC740", Slot = "13")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004055")]
		[Address(RVA = "0x35F9020", Offset = "0x35F7620", VA = "0x1835F9020", Slot = "14")]
		protected virtual void RegisterEvents()
		{
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004056")]
		[Address(RVA = "0x35F95E0", Offset = "0x35F7BE0", VA = "0x1835F95E0", Slot = "15")]
		protected virtual void UnregisterEvents()
		{
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004057")]
		[Address(RVA = "0x35F9B90", Offset = "0x35F8190", VA = "0x1835F9B90", Slot = "16")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004058")]
		[Address(RVA = "0x35F9D10", Offset = "0x35F8310", VA = "0x1835F9D10")]
		private void ApplyCameraAimAdjustments()
		{
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004059")]
		[Address(RVA = "0x35FA020", Offset = "0x35F8620", VA = "0x1835FA020")]
		private void UpdateLocalPlayer()
		{
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405A")]
		[Address(RVA = "0x35FA8B0", Offset = "0x35F8EB0", VA = "0x1835FA8B0")]
		protected void TriggerStartAttack()
		{
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405B")]
		[Address(RVA = "0x35FA980", Offset = "0x35F8F80", VA = "0x1835FA980")]
		protected void ClearTriggeredAttack()
		{
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00013A88 File Offset: 0x00011C88
		[Token(Token = "0x600405C")]
		[Address(RVA = "0x35FAA50", Offset = "0x35F9050", VA = "0x1835FAA50")]
		protected bool IsInAttackState()
		{
			return default(bool);
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405D")]
		[Address(RVA = "0x35FAA70", Offset = "0x35F9070", VA = "0x1835FAA70", Slot = "17")]
		protected virtual void FireWeapon()
		{
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405E")]
		[Address(RVA = "0x35FAC60", Offset = "0x35F9260", VA = "0x1835FAC60")]
		private void SendFireWeaponEvent()
		{
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "18")]
		protected virtual void PlayFireAnimNetwork()
		{
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004060")]
		[Address(RVA = "0x35FAD10", Offset = "0x35F9310", VA = "0x1835FAD10", Slot = "19")]
		public virtual void OnFireWeaponNetwork()
		{
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004061")]
		[Address(RVA = "0x35FAE00", Offset = "0x35F9400", VA = "0x1835FAE00", Slot = "20")]
		public virtual void OnFireWeaponVail()
		{
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004062")]
		[Address(RVA = "0x35FAE40", Offset = "0x35F9440", VA = "0x1835FAE40", Slot = "21")]
		protected virtual void OnAmmoSpent()
		{
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004063")]
		[Address(RVA = "0x35FAFB0", Offset = "0x35F95B0", VA = "0x1835FAFB0", Slot = "22")]
		protected virtual void OnMuzzleFlash()
		{
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004064")]
		[Address(RVA = "0x35FB450", Offset = "0x35F9A50", VA = "0x1835FB450")]
		private void CheckFireInput()
		{
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004065")]
		[Address(RVA = "0x35FB7C0", Offset = "0x35F9DC0", VA = "0x1835FB7C0")]
		private void TriggerFireWeapon()
		{
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004066")]
		[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190", Slot = "23")]
		internal virtual string GetFireRumbleProfileId()
		{
			return null;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x00013AA0 File Offset: 0x00011CA0
		[Token(Token = "0x6004067")]
		[Address(RVA = "0x35FB840", Offset = "0x35F9E40", VA = "0x1835FB840", Slot = "24")]
		protected virtual bool CanAim()
		{
			return default(bool);
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004068")]
		[Address(RVA = "0x35FB860", Offset = "0x35F9E60", VA = "0x1835FB860")]
		private void CheckAimInput()
		{
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004069")]
		[Address(RVA = "0x35FBB80", Offset = "0x35FA180", VA = "0x1835FBB80")]
		private void UpdateAimFov()
		{
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "25")]
		protected virtual void OnSecondaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406B")]
		[Address(RVA = "0x35FBC70", Offset = "0x35FA270", VA = "0x1835FBC70")]
		private void OnReloadAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406C")]
		[Address(RVA = "0x35FC080", Offset = "0x35FA680", VA = "0x1835FC080")]
		private IEnumerator ReloadDelayRoutine(InputAction.CallbackContext context)
		{
			return null;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x00013AB8 File Offset: 0x00011CB8
		[Token(Token = "0x600406D")]
		[Address(RVA = "0x35FC180", Offset = "0x35FA780", VA = "0x1835FC180")]
		protected bool CanReload()
		{
			return default(bool);
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406E")]
		[Address(RVA = "0x35FC2C0", Offset = "0x35FA8C0", VA = "0x1835FC2C0")]
		private void CheckForLeftHandEquipAfterReloading()
		{
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x00013AD0 File Offset: 0x00011CD0
		[Token(Token = "0x600406F")]
		[Address(RVA = "0x35FC330", Offset = "0x35FA930", VA = "0x1835FC330", Slot = "26")]
		protected virtual bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004070")]
		[Address(RVA = "0x35FC340", Offset = "0x35FA940", VA = "0x1835FC340", Slot = "27")]
		protected virtual void Reload()
		{
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004071")]
		[Address(RVA = "0x35FC370", Offset = "0x35FA970", VA = "0x1835FC370")]
		private void SetIsReloading(bool value)
		{
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004072")]
		[Address(RVA = "0x35FC430", Offset = "0x35FAA30", VA = "0x1835FC430")]
		private void ReloadAmmo(RangedWeapon rangedWeapon, bool reloadSingleRound = false)
		{
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004073")]
		[Address(RVA = "0x35FC8A0", Offset = "0x35FAEA0", VA = "0x1835FC8A0")]
		private void SetClampedSpine(bool active)
		{
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004074")]
		[Address(RVA = "0x35FC920", Offset = "0x35FAF20", VA = "0x1835FC920")]
		private void SpawnCasing()
		{
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004075")]
		[Address(RVA = "0x35FCD30", Offset = "0x35FB330", VA = "0x1835FCD30")]
		protected RangedWeapon GetRangedWeapon()
		{
			return null;
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004076")]
		[Address(RVA = "0x35FCE00", Offset = "0x35FB400", VA = "0x1835FCE00")]
		private void CacheRangedWeapon()
		{
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004077")]
		[Address(RVA = "0x35FCFD0", Offset = "0x35FB5D0", VA = "0x1835FCFD0", Slot = "28")]
		public virtual void TriggerShotFiredAudio()
		{
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004078")]
		[Address(RVA = "0x35FD190", Offset = "0x35FB790", VA = "0x1835FD190", Slot = "29")]
		public virtual void TriggerVailAudioEvent(Vector3 position)
		{
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004079")]
		[Address(RVA = "0x35FD360", Offset = "0x35FB960", VA = "0x1835FD360", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407A")]
		[Address(RVA = "0x35FD710", Offset = "0x35FBD10", VA = "0x1835FD710", Slot = "30")]
		protected virtual void RangeShootCallback()
		{
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407B")]
		[Address(RVA = "0x35FD730", Offset = "0x35FBD30", VA = "0x1835FD730", Slot = "31")]
		protected virtual void RangeReloadCallback()
		{
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407C")]
		[Address(RVA = "0x35FD770", Offset = "0x35FBD70", VA = "0x1835FD770", Slot = "32")]
		protected virtual void AttackStartCallback()
		{
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407D")]
		[Address(RVA = "0x35FD780", Offset = "0x35FBD80", VA = "0x1835FD780", Slot = "33")]
		protected virtual void AttackEndCallback()
		{
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "34")]
		protected virtual void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407F")]
		[Address(RVA = "0x35FD790", Offset = "0x35FBD90", VA = "0x1835FD790")]
		private void UpdateLoadedAmmoVisuals()
		{
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004080")]
		[Address(RVA = "0x35FE1E0", Offset = "0x35FC7E0", VA = "0x1835FE1E0")]
		protected void ShowItemRenderable(bool show)
		{
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004081")]
		[Address(RVA = "0x35FE450", Offset = "0x35FCA50", VA = "0x1835FE450")]
		protected void CheckConsumeThrownItem(bool onDisable = false)
		{
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004082")]
		[Address(RVA = "0x35FE530", Offset = "0x35FCB30", VA = "0x1835FE530")]
		protected void SetItemThrown()
		{
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x00013AE8 File Offset: 0x00011CE8
		[Token(Token = "0x6004083")]
		[Address(RVA = "0x35FE540", Offset = "0x35FCB40", VA = "0x1835FE540", Slot = "35")]
		protected virtual bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004084")]
		[Address(RVA = "0x35FE610", Offset = "0x35FCC10", VA = "0x1835FE610")]
		private void UpdatePlayerAimStimuli()
		{
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x35FE740", Offset = "0x35FCD40", VA = "0x1835FE740")]
		private void UpdateAimStimuliState(GameObject aimStimuliGo)
		{
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x35FEFF0", Offset = "0x35FD5F0", VA = "0x1835FEFF0")]
		protected RangedWeaponController()
		{
		}

		// Token: 0x04003575 RID: 13685
		[Token(Token = "0x4003575")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Animator _weaponAnimator;

		// Token: 0x04003576 RID: 13686
		[Token(Token = "0x4003576")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected GameObject _ammoEmpty;

		// Token: 0x04003577 RID: 13687
		[Token(Token = "0x4003577")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected GameObject _ammoSpawn;

		// Token: 0x04003578 RID: 13688
		[Token(Token = "0x4003578")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected Vector3 _casingVelocity;

		// Token: 0x04003579 RID: 13689
		[Token(Token = "0x4003579")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		protected Vector3 _casingAngularVelocity;

		// Token: 0x0400357A RID: 13690
		[Token(Token = "0x400357A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected float _fireDelay;

		// Token: 0x0400357B RID: 13691
		[Token(Token = "0x400357B")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		protected bool _canAim;

		// Token: 0x0400357C RID: 13692
		[Token(Token = "0x400357C")]
		[FieldOffset(Offset = "0x9D")]
		[SerializeField]
		protected bool _mustAimToFire;

		// Token: 0x0400357D RID: 13693
		[Token(Token = "0x400357D")]
		[FieldOffset(Offset = "0x9E")]
		[SerializeField]
		protected bool _requiresTwoHandsToFire;

		// Token: 0x0400357E RID: 13694
		[Token(Token = "0x400357E")]
		[FieldOffset(Offset = "0x9F")]
		[SerializeField]
		protected bool _requiresTwoHandsToReload;

		// Token: 0x0400357F RID: 13695
		[Token(Token = "0x400357F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected bool _reloadSingleRound;

		// Token: 0x04003580 RID: 13696
		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0xA1")]
		[SerializeField]
		protected bool _canInterruptReload;

		// Token: 0x04003581 RID: 13697
		[Token(Token = "0x4003581")]
		[FieldOffset(Offset = "0xA2")]
		[SerializeField]
		protected bool _isChargedWeapon;

		// Token: 0x04003582 RID: 13698
		[Token(Token = "0x4003582")]
		[FieldOffset(Offset = "0xA3")]
		[FormerlySerializedAs("_showLoadedProjectileVisual")]
		[SerializeField]
		protected bool _usesLoadedProjectileVisual;

		// Token: 0x04003583 RID: 13699
		[Token(Token = "0x4003583")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private bool _showProjectileVisual;

		// Token: 0x04003584 RID: 13700
		[Token(Token = "0x4003584")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected VailAudioManager.Noise _fireNoiseStimuli;

		// Token: 0x04003585 RID: 13701
		[Token(Token = "0x4003585")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected MuzzleFlash _muzzleFlashPrefab;

		// Token: 0x04003586 RID: 13702
		[Token(Token = "0x4003586")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _fireGunRumbleProfileId;

		// Token: 0x04003587 RID: 13703
		[Token(Token = "0x4003587")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected RangedWeaponController.FireAudio _playFireAudio;

		// Token: 0x04003588 RID: 13704
		[Token(Token = "0x4003588")]
		[FieldOffset(Offset = "0xC8")]
		[EventRef]
		[SerializeField]
		protected string _gunShotAudioEvent;

		// Token: 0x04003589 RID: 13705
		[Token(Token = "0x4003589")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected bool _waitForEndOfAttack;

		// Token: 0x0400358A RID: 13706
		[Token(Token = "0x400358A")]
		[FieldOffset(Offset = "0xD1")]
		[SerializeField]
		protected bool _shouldSuppressLeftHandFirstLook;

		// Token: 0x0400358B RID: 13707
		[Token(Token = "0x400358B")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine _reloadDelay;

		// Token: 0x0400358C RID: 13708
		[Token(Token = "0x400358C")]
		[FieldOffset(Offset = "0xE0")]
		private CoopPlayerRemoteSetup _remotePlayer;

		// Token: 0x0400358D RID: 13709
		[Token(Token = "0x400358D")]
		[FieldOffset(Offset = "0xE8")]
		protected bool _stashedLeftHandToFire;

		// Token: 0x0400358E RID: 13710
		[Token(Token = "0x400358E")]
		[FieldOffset(Offset = "0xEC")]
		protected RangedWeaponController.AttackState _attackState;

		// Token: 0x0400358F RID: 13711
		[Token(Token = "0x400358F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected bool _clampSpineBool;

		// Token: 0x04003590 RID: 13712
		[Token(Token = "0x4003590")]
		[FieldOffset(Offset = "0xF1")]
		[SerializeField]
		private bool _applyFieldOfViewAim;

		// Token: 0x04003591 RID: 13713
		[Token(Token = "0x4003591")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private FovManager.FieldOfViewChangeSettings _fovChangeSettings;

		// Token: 0x04003592 RID: 13714
		[Token(Token = "0x4003592")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _applyAimCameraHeightAdjustment;

		// Token: 0x04003593 RID: 13715
		[Token(Token = "0x4003593")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private AnimationCurve _aimCameraHeightCurve;

		// Token: 0x04003594 RID: 13716
		[Token(Token = "0x4003594")]
		[FieldOffset(Offset = "0x110")]
		protected MuzzleFlash _muzzleFlashInstance;

		// Token: 0x04003595 RID: 13717
		[Token(Token = "0x4003595")]
		[FieldOffset(Offset = "0x118")]
		protected RangedWeapon _rangedWeapon;

		// Token: 0x04003596 RID: 13718
		[Token(Token = "0x4003596")]
		[FieldOffset(Offset = "0x120")]
		protected float _nextFireDelay;

		// Token: 0x04003597 RID: 13719
		[Token(Token = "0x4003597")]
		[FieldOffset(Offset = "0x128")]
		private Transform _renderableTransform;

		// Token: 0x04003598 RID: 13720
		[Token(Token = "0x4003598")]
		[FieldOffset(Offset = "0x130")]
		private GameObject _loadedProjectileVisual;

		// Token: 0x04003599 RID: 13721
		[Token(Token = "0x4003599")]
		[FieldOffset(Offset = "0x138")]
		private ItemRenderableTag _itemRenderable;

		// Token: 0x0400359A RID: 13722
		[Token(Token = "0x400359A")]
		[FieldOffset(Offset = "0x140")]
		private FovManager _cameraFovManager;

		// Token: 0x0400359B RID: 13723
		[Token(Token = "0x400359B")]
		[FieldOffset(Offset = "0x148")]
		protected bool _isCharging;

		// Token: 0x0400359C RID: 13724
		[Token(Token = "0x400359C")]
		[FieldOffset(Offset = "0x149")]
		private bool _isReloading;

		// Token: 0x0400359D RID: 13725
		[Token(Token = "0x400359D")]
		[FieldOffset(Offset = "0x14A")]
		private bool _hasAimFovApplied;

		// Token: 0x0400359E RID: 13726
		[Token(Token = "0x400359E")]
		[FieldOffset(Offset = "0x14B")]
		private bool _fovRegistered;

		// Token: 0x0400359F RID: 13727
		[Token(Token = "0x400359F")]
		[FieldOffset(Offset = "0x14C")]
		private bool _equipLeftHandWhenReloadIsDone;

		// Token: 0x040035A0 RID: 13728
		[Token(Token = "0x40035A0")]
		[FieldOffset(Offset = "0x14D")]
		private bool _itemWasThrown;

		// Token: 0x040035A1 RID: 13729
		[Token(Token = "0x40035A1")]
		[FieldOffset(Offset = "0x14E")]
		private readonly bool _debugAim;

		// Token: 0x040035A2 RID: 13730
		[Token(Token = "0x40035A2")]
		[FieldOffset(Offset = "0x150")]
		private RangedWeaponController.AimStimuli _aimStimuliState;

		// Token: 0x040035A3 RID: 13731
		[Token(Token = "0x40035A3")]
		[FieldOffset(Offset = "0x154")]
		private float _startAimWarmupTime;

		// Token: 0x040035A4 RID: 13732
		[Token(Token = "0x40035A4")]
		[FieldOffset(Offset = "0x158")]
		private float _lastAimOverTime;

		// Token: 0x040035A5 RID: 13733
		[Token(Token = "0x40035A5")]
		[FieldOffset(Offset = "0x15C")]
		private float _lastAimShowTime;

		// Token: 0x040035A6 RID: 13734
		[Token(Token = "0x40035A6")]
		[FieldOffset(Offset = "0x160")]
		private LayerMask _aimHitMask;

		// Token: 0x020008CC RID: 2252
		[Token(Token = "0x20008CC")]
		protected enum FireAudio
		{
			// Token: 0x040035A8 RID: 13736
			[Token(Token = "0x40035A8")]
			OnAnimShootCallback,
			// Token: 0x040035A9 RID: 13737
			[Token(Token = "0x40035A9")]
			OnFireWeapon
		}

		// Token: 0x020008CD RID: 2253
		[Token(Token = "0x20008CD")]
		protected enum AttackState
		{
			// Token: 0x040035AB RID: 13739
			[Token(Token = "0x40035AB")]
			Idle,
			// Token: 0x040035AC RID: 13740
			[Token(Token = "0x40035AC")]
			Triggered,
			// Token: 0x040035AD RID: 13741
			[Token(Token = "0x40035AD")]
			MidAttack
		}

		// Token: 0x020008CE RID: 2254
		[Token(Token = "0x20008CE")]
		private enum AimStimuli
		{
			// Token: 0x040035AF RID: 13743
			[Token(Token = "0x40035AF")]
			Off,
			// Token: 0x040035B0 RID: 13744
			[Token(Token = "0x40035B0")]
			WarmUp,
			// Token: 0x040035B1 RID: 13745
			[Token(Token = "0x40035B1")]
			On
		}
	}
}

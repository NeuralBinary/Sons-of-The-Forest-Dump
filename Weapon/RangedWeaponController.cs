using System;
using System.Collections;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Animation;
using Sons.FieldOfView;
using Sons.Gameplay;
using Sons.Items.Core;
using Sons.Multiplayer.Client;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x0200085B RID: 2139
	[Token(Token = "0x200085B")]
	[AddComponentMenu("Sons/Weapon/RangedWeaponController")]
	public abstract class RangedWeaponController : HeldControllerBase
	{
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x00010C50 File Offset: 0x0000EE50
		[Token(Token = "0x17000718")]
		protected bool IsAiming
		{
			[Token(Token = "0x6003930")]
			[Address(RVA = "0x2ED91A0", Offset = "0x2ED81A0", VA = "0x182ED91A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003931")]
		[Address(RVA = "0x2ED6F40", Offset = "0x2ED5F40", VA = "0x182ED6F40")]
		public void ShowProjectileVisual(bool value)
		{
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x00010C68 File Offset: 0x0000EE68
		[Token(Token = "0x6003932")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "10")]
		internal virtual bool ShouldShowMuzzleFlash()
		{
			return default(bool);
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003933")]
		[Address(RVA = "0x2ED4800", Offset = "0x2ED3800", VA = "0x182ED4800")]
		private void Awake()
		{
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003934")]
		[Address(RVA = "0x59F9F0", Offset = "0x59E9F0", VA = "0x18059F9F0")]
		private void OnRenderableLoaded(Transform renderableTransform)
		{
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003935")]
		[Address(RVA = "0x2ED7160", Offset = "0x2ED6160", VA = "0x182ED7160", Slot = "11")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003936")]
		[Address(RVA = "0x2ED5A10", Offset = "0x2ED4A10", VA = "0x182ED5A10", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003937")]
		[Address(RVA = "0x2ED5A90", Offset = "0x2ED4A90", VA = "0x182ED5A90", Slot = "12")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003938")]
		[Address(RVA = "0x22AB2B0", Offset = "0x22AA2B0", VA = "0x1822AB2B0", Slot = "13")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003939")]
		[Address(RVA = "0x2ED64A0", Offset = "0x2ED54A0", VA = "0x182ED64A0", Slot = "14")]
		protected virtual void RegisterEvents()
		{
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393A")]
		[Address(RVA = "0x2ED7580", Offset = "0x2ED6580", VA = "0x182ED7580", Slot = "15")]
		protected virtual void UnregisterEvents()
		{
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x2ED8C00", Offset = "0x2ED7C00", VA = "0x182ED8C00", Slot = "16")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393C")]
		[Address(RVA = "0x2ED45F0", Offset = "0x2ED35F0", VA = "0x182ED45F0")]
		private void ApplyCameraAimAdjustments()
		{
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393D")]
		[Address(RVA = "0x2ED84B0", Offset = "0x2ED74B0", VA = "0x182ED84B0")]
		private void UpdateLocalPlayer()
		{
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393E")]
		[Address(RVA = "0x2ED73B0", Offset = "0x2ED63B0", VA = "0x182ED73B0")]
		protected void TriggerStartAttack()
		{
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393F")]
		[Address(RVA = "0x2ED5250", Offset = "0x2ED4250", VA = "0x182ED5250")]
		protected void ClearTriggeredAttack()
		{
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x00010C80 File Offset: 0x0000EE80
		[Token(Token = "0x6003940")]
		[Address(RVA = "0x2ED5880", Offset = "0x2ED4880", VA = "0x182ED5880")]
		protected bool IsInAttackState()
		{
			return default(bool);
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003941")]
		[Address(RVA = "0x2ED52E0", Offset = "0x2ED42E0", VA = "0x182ED52E0", Slot = "17")]
		protected virtual void FireWeapon()
		{
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003942")]
		[Address(RVA = "0x2ED6C40", Offset = "0x2ED5C40", VA = "0x182ED6C40")]
		private void SendFireWeaponEvent()
		{
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003943")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "18")]
		protected virtual void PlayFireAnimNetwork()
		{
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003944")]
		[Address(RVA = "0x2ED5D50", Offset = "0x2ED4D50", VA = "0x182ED5D50", Slot = "19")]
		public virtual void OnFireWeaponNetwork()
		{
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003945")]
		[Address(RVA = "0x2ED5DE0", Offset = "0x2ED4DE0", VA = "0x182ED5DE0", Slot = "20")]
		public virtual void OnFireWeaponVail()
		{
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003946")]
		[Address(RVA = "0x2ED58B0", Offset = "0x2ED48B0", VA = "0x182ED58B0", Slot = "21")]
		protected virtual void OnAmmoSpent()
		{
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003947")]
		[Address(RVA = "0x2ED5E20", Offset = "0x2ED4E20", VA = "0x182ED5E20", Slot = "22")]
		protected virtual void OnMuzzleFlash()
		{
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003948")]
		[Address(RVA = "0x2ED4E60", Offset = "0x2ED3E60", VA = "0x182ED4E60")]
		private void CheckFireInput()
		{
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003949")]
		[Address(RVA = "0x2ED7210", Offset = "0x2ED6210", VA = "0x182ED7210")]
		private void TriggerFireWeapon()
		{
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600394A")]
		[Address(RVA = "0x5F1A50", Offset = "0x5F0A50", VA = "0x1805F1A50", Slot = "23")]
		internal virtual string GetFireRumbleProfileId()
		{
			return null;
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394B")]
		[Address(RVA = "0x2ED4AE0", Offset = "0x2ED3AE0", VA = "0x182ED4AE0")]
		private void CheckAimInput()
		{
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394C")]
		[Address(RVA = "0x2ED78F0", Offset = "0x2ED68F0", VA = "0x182ED78F0")]
		private void UpdateAimFov()
		{
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394D")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "24")]
		protected virtual void OnSecondaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394E")]
		[Address(RVA = "0x2ED60F0", Offset = "0x2ED50F0", VA = "0x182ED60F0")]
		private void OnReloadAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600394F")]
		[Address(RVA = "0x2ED6B80", Offset = "0x2ED5B80", VA = "0x182ED6B80")]
		private IEnumerator ReloadDelayRoutine(InputAction.CallbackContext context)
		{
			return null;
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x00010C98 File Offset: 0x0000EE98
		[Token(Token = "0x6003950")]
		[Address(RVA = "0x2ED49F0", Offset = "0x2ED39F0", VA = "0x182ED49F0")]
		protected bool CanReload()
		{
			return default(bool);
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003951")]
		[Address(RVA = "0x2ED51C0", Offset = "0x2ED41C0", VA = "0x182ED51C0")]
		private void CheckForLeftHandEquipAfterReloading()
		{
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		[Token(Token = "0x6003952")]
		[Address(RVA = "0x2ED58A0", Offset = "0x2ED48A0", VA = "0x182ED58A0", Slot = "25")]
		protected virtual bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003953")]
		[Address(RVA = "0x2ED6C10", Offset = "0x2ED5C10", VA = "0x182ED6C10", Slot = "26")]
		protected virtual void Reload()
		{
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003954")]
		[Address(RVA = "0x2ED6D70", Offset = "0x2ED5D70", VA = "0x182ED6D70")]
		private void SetIsReloading(bool value)
		{
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003955")]
		[Address(RVA = "0x2ED6820", Offset = "0x2ED5820", VA = "0x182ED6820")]
		private void ReloadAmmo(RangedWeapon rangedWeapon, bool reloadSingleRound = false)
		{
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003956")]
		[Address(RVA = "0x2ED6CF0", Offset = "0x2ED5CF0", VA = "0x182ED6CF0")]
		private void SetClampedSpine(bool active)
		{
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003957")]
		[Address(RVA = "0x2ED6F50", Offset = "0x2ED5F50", VA = "0x182ED6F50")]
		private void SpawnCasing()
		{
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003958")]
		[Address(RVA = "0x2ED5490", Offset = "0x2ED4490", VA = "0x182ED5490")]
		protected RangedWeapon GetRangedWeapon()
		{
			return null;
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003959")]
		[Address(RVA = "0x2ED48C0", Offset = "0x2ED38C0", VA = "0x182ED48C0")]
		private void CacheRangedWeapon()
		{
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395A")]
		[Address(RVA = "0x2ED7290", Offset = "0x2ED6290", VA = "0x182ED7290", Slot = "27")]
		public virtual void TriggerShotFiredAudio()
		{
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395B")]
		[Address(RVA = "0x2ED7440", Offset = "0x2ED6440", VA = "0x182ED7440", Slot = "28")]
		public virtual void TriggerVailAudioEvent(Vector3 position)
		{
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395C")]
		[Address(RVA = "0x2ED5610", Offset = "0x2ED4610", VA = "0x182ED5610", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395D")]
		[Address(RVA = "0x2ED6480", Offset = "0x2ED5480", VA = "0x182ED6480", Slot = "29")]
		protected virtual void RangeShootCallback()
		{
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395E")]
		[Address(RVA = "0x2ED6440", Offset = "0x2ED5440", VA = "0x182ED6440", Slot = "30")]
		protected virtual void RangeReloadCallback()
		{
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395F")]
		[Address(RVA = "0x2ED47F0", Offset = "0x2ED37F0", VA = "0x182ED47F0", Slot = "31")]
		protected virtual void AttackStartCallback()
		{
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003960")]
		[Address(RVA = "0x2ED47E0", Offset = "0x2ED37E0", VA = "0x182ED47E0", Slot = "32")]
		protected virtual void AttackEndCallback()
		{
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003961")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "33")]
		protected virtual void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003962")]
		[Address(RVA = "0x2ED7E40", Offset = "0x2ED6E40", VA = "0x182ED7E40")]
		private void UpdateLoadedAmmoVisuals()
		{
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003963")]
		[Address(RVA = "0x2ED6E40", Offset = "0x2ED5E40", VA = "0x182ED6E40")]
		protected void ShowItemRenderable(bool show)
		{
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003964")]
		[Address(RVA = "0x2ED4D80", Offset = "0x2ED3D80", VA = "0x182ED4D80")]
		protected void CheckConsumeThrownItem(bool onDisable = false)
		{
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003965")]
		[Address(RVA = "0x2ED6E30", Offset = "0x2ED5E30", VA = "0x182ED6E30")]
		protected void SetItemThrown()
		{
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		[Token(Token = "0x6003966")]
		[Address(RVA = "0x2ED5800", Offset = "0x2ED4800", VA = "0x182ED5800", Slot = "34")]
		protected virtual bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003967")]
		[Address(RVA = "0x2ED8B40", Offset = "0x2ED7B40", VA = "0x182ED8B40")]
		private void UpdatePlayerAimStimuli()
		{
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003968")]
		[Address(RVA = "0x2ED79A0", Offset = "0x2ED69A0", VA = "0x182ED79A0")]
		private void UpdateAimStimuliState(GameObject aimStimuliGo)
		{
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003969")]
		[Address(RVA = "0x2ED8EB0", Offset = "0x2ED7EB0", VA = "0x182ED8EB0")]
		protected RangedWeaponController()
		{
		}

		// Token: 0x040030AE RID: 12462
		[Token(Token = "0x40030AE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected Animator _weaponAnimator;

		// Token: 0x040030AF RID: 12463
		[Token(Token = "0x40030AF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected GameObject _ammoEmpty;

		// Token: 0x040030B0 RID: 12464
		[Token(Token = "0x40030B0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected GameObject _ammoSpawn;

		// Token: 0x040030B1 RID: 12465
		[Token(Token = "0x40030B1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected Vector3 _casingVelocity;

		// Token: 0x040030B2 RID: 12466
		[Token(Token = "0x40030B2")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		protected Vector3 _casingAngularVelocity;

		// Token: 0x040030B3 RID: 12467
		[Token(Token = "0x40030B3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected float _fireDelay;

		// Token: 0x040030B4 RID: 12468
		[Token(Token = "0x40030B4")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		protected bool _mustAimToFire;

		// Token: 0x040030B5 RID: 12469
		[Token(Token = "0x40030B5")]
		[FieldOffset(Offset = "0xA5")]
		[SerializeField]
		protected bool _requiresTwoHandsToFire;

		// Token: 0x040030B6 RID: 12470
		[Token(Token = "0x40030B6")]
		[FieldOffset(Offset = "0xA6")]
		[SerializeField]
		protected bool _requiresTwoHandsToReload;

		// Token: 0x040030B7 RID: 12471
		[Token(Token = "0x40030B7")]
		[FieldOffset(Offset = "0xA7")]
		[SerializeField]
		protected bool _reloadSingleRound;

		// Token: 0x040030B8 RID: 12472
		[Token(Token = "0x40030B8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected bool _canInterruptReload;

		// Token: 0x040030B9 RID: 12473
		[Token(Token = "0x40030B9")]
		[FieldOffset(Offset = "0xA9")]
		[SerializeField]
		protected bool _isChargedWeapon;

		// Token: 0x040030BA RID: 12474
		[Token(Token = "0x40030BA")]
		[FieldOffset(Offset = "0xAA")]
		[FormerlySerializedAs("_showLoadedProjectileVisual")]
		[SerializeField]
		protected bool _usesLoadedProjectileVisual;

		// Token: 0x040030BB RID: 12475
		[Token(Token = "0x40030BB")]
		[FieldOffset(Offset = "0xAB")]
		[SerializeField]
		private bool _showProjectileVisual;

		// Token: 0x040030BC RID: 12476
		[Token(Token = "0x40030BC")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		protected VailAudioManager.Noise _fireNoiseStimuli;

		// Token: 0x040030BD RID: 12477
		[Token(Token = "0x40030BD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected MuzzleFlash _muzzleFlashPrefab;

		// Token: 0x040030BE RID: 12478
		[Token(Token = "0x40030BE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _fireGunRumbleProfileId;

		// Token: 0x040030BF RID: 12479
		[Token(Token = "0x40030BF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected RangedWeaponController.FireAudio _playFireAudio;

		// Token: 0x040030C0 RID: 12480
		[Token(Token = "0x40030C0")]
		[FieldOffset(Offset = "0xC8")]
		[EventRef]
		[SerializeField]
		protected string _gunShotAudioEvent;

		// Token: 0x040030C1 RID: 12481
		[Token(Token = "0x40030C1")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected bool _waitForEndOfAttack;

		// Token: 0x040030C2 RID: 12482
		[Token(Token = "0x40030C2")]
		[FieldOffset(Offset = "0xD1")]
		[SerializeField]
		protected bool _shouldSuppressLeftHandFirstLook;

		// Token: 0x040030C3 RID: 12483
		[Token(Token = "0x40030C3")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine _reloadDelay;

		// Token: 0x040030C4 RID: 12484
		[Token(Token = "0x40030C4")]
		[FieldOffset(Offset = "0xE0")]
		private CoopPlayerRemoteSetup _remotePlayer;

		// Token: 0x040030C5 RID: 12485
		[Token(Token = "0x40030C5")]
		[FieldOffset(Offset = "0xE8")]
		protected bool _stashedLeftHandToFire;

		// Token: 0x040030C6 RID: 12486
		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0xEC")]
		protected RangedWeaponController.AttackState _attackState;

		// Token: 0x040030C7 RID: 12487
		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected bool _clampSpineBool;

		// Token: 0x040030C8 RID: 12488
		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0xF1")]
		[SerializeField]
		private bool _applyFieldOfViewAim;

		// Token: 0x040030C9 RID: 12489
		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private FovManager.FieldOfViewChangeSettings _fovChangeSettings;

		// Token: 0x040030CA RID: 12490
		[Token(Token = "0x40030CA")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _applyAimCameraHeightAdjustment;

		// Token: 0x040030CB RID: 12491
		[Token(Token = "0x40030CB")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private AnimationCurve _aimCameraHeightCurve;

		// Token: 0x040030CC RID: 12492
		[Token(Token = "0x40030CC")]
		[FieldOffset(Offset = "0x110")]
		protected MuzzleFlash _muzzleFlashInstance;

		// Token: 0x040030CD RID: 12493
		[Token(Token = "0x40030CD")]
		[FieldOffset(Offset = "0x118")]
		protected RangedWeapon _rangedWeapon;

		// Token: 0x040030CE RID: 12494
		[Token(Token = "0x40030CE")]
		[FieldOffset(Offset = "0x120")]
		protected float _nextFireDelay;

		// Token: 0x040030CF RID: 12495
		[Token(Token = "0x40030CF")]
		[FieldOffset(Offset = "0x128")]
		private Transform _renderableTransform;

		// Token: 0x040030D0 RID: 12496
		[Token(Token = "0x40030D0")]
		[FieldOffset(Offset = "0x130")]
		private GameObject _loadedProjectileVisual;

		// Token: 0x040030D1 RID: 12497
		[Token(Token = "0x40030D1")]
		[FieldOffset(Offset = "0x138")]
		private ItemRenderableTag _itemRenderable;

		// Token: 0x040030D2 RID: 12498
		[Token(Token = "0x40030D2")]
		[FieldOffset(Offset = "0x140")]
		private FovManager _cameraFovManager;

		// Token: 0x040030D3 RID: 12499
		[Token(Token = "0x40030D3")]
		[FieldOffset(Offset = "0x148")]
		protected bool _isCharging;

		// Token: 0x040030D4 RID: 12500
		[Token(Token = "0x40030D4")]
		[FieldOffset(Offset = "0x149")]
		private bool _isReloading;

		// Token: 0x040030D5 RID: 12501
		[Token(Token = "0x40030D5")]
		[FieldOffset(Offset = "0x14A")]
		private bool _hasAimFovApplied;

		// Token: 0x040030D6 RID: 12502
		[Token(Token = "0x40030D6")]
		[FieldOffset(Offset = "0x14B")]
		private bool _fovRegistered;

		// Token: 0x040030D7 RID: 12503
		[Token(Token = "0x40030D7")]
		[FieldOffset(Offset = "0x14C")]
		private bool _equipLeftHandWhenReloadIsDone;

		// Token: 0x040030D8 RID: 12504
		[Token(Token = "0x40030D8")]
		[FieldOffset(Offset = "0x14D")]
		private bool _itemWasThrown;

		// Token: 0x040030D9 RID: 12505
		[Token(Token = "0x40030D9")]
		[FieldOffset(Offset = "0x14E")]
		private readonly bool _debugAim;

		// Token: 0x040030DA RID: 12506
		[Token(Token = "0x40030DA")]
		[FieldOffset(Offset = "0x150")]
		private RangedWeaponController.AimStimuli _aimStimuliState;

		// Token: 0x040030DB RID: 12507
		[Token(Token = "0x40030DB")]
		[FieldOffset(Offset = "0x154")]
		private float _startAimWarmupTime;

		// Token: 0x040030DC RID: 12508
		[Token(Token = "0x40030DC")]
		[FieldOffset(Offset = "0x158")]
		private float _lastAimOverTime;

		// Token: 0x040030DD RID: 12509
		[Token(Token = "0x40030DD")]
		[FieldOffset(Offset = "0x15C")]
		private float _lastAimShowTime;

		// Token: 0x040030DE RID: 12510
		[Token(Token = "0x40030DE")]
		[FieldOffset(Offset = "0x160")]
		private LayerMask _aimHitMask;

		// Token: 0x0200085C RID: 2140
		[Token(Token = "0x200085C")]
		protected enum FireAudio
		{
			// Token: 0x040030E0 RID: 12512
			[Token(Token = "0x40030E0")]
			OnAnimShootCallback,
			// Token: 0x040030E1 RID: 12513
			[Token(Token = "0x40030E1")]
			OnFireWeapon
		}

		// Token: 0x0200085D RID: 2141
		[Token(Token = "0x200085D")]
		protected enum AttackState
		{
			// Token: 0x040030E3 RID: 12515
			[Token(Token = "0x40030E3")]
			Idle,
			// Token: 0x040030E4 RID: 12516
			[Token(Token = "0x40030E4")]
			Triggered,
			// Token: 0x040030E5 RID: 12517
			[Token(Token = "0x40030E5")]
			MidAttack
		}

		// Token: 0x0200085E RID: 2142
		[Token(Token = "0x200085E")]
		private enum AimStimuli
		{
			// Token: 0x040030E7 RID: 12519
			[Token(Token = "0x40030E7")]
			Off,
			// Token: 0x040030E8 RID: 12520
			[Token(Token = "0x40030E8")]
			WarmUp,
			// Token: 0x040030E9 RID: 12521
			[Token(Token = "0x40030E9")]
			On
		}
	}
}

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Interfaces;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x0200083E RID: 2110
	[Token(Token = "0x200083E")]
	[AddComponentMenu("Sons/Weapon/FlareWeaponController")]
	public class FlareWeaponController : RangedWeaponController, IBurnable
	{
		// Token: 0x06003837 RID: 14391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003837")]
		[Address(RVA = "0x2EC6E50", Offset = "0x2EC5E50", VA = "0x182EC6E50", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003838")]
		[Address(RVA = "0x2EC6AE0", Offset = "0x2EC5AE0", VA = "0x182EC6AE0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, int itemId)
		{
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003839")]
		[Address(RVA = "0x2EC74A0", Offset = "0x2EC64A0", VA = "0x182EC74A0", Slot = "14")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383A")]
		[Address(RVA = "0x2EC77C0", Offset = "0x2EC67C0", VA = "0x182EC77C0", Slot = "15")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383B")]
		[Address(RVA = "0x2EC6CF0", Offset = "0x2EC5CF0", VA = "0x182EC6CF0")]
		private void OnActivated()
		{
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383C")]
		[Address(RVA = "0x2EC7230", Offset = "0x2EC6230", VA = "0x182EC7230", Slot = "24")]
		protected override void OnSecondaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383D")]
		[Address(RVA = "0x2EC6C10", Offset = "0x2EC5C10", VA = "0x182EC6C10")]
		private void LeftHandReady()
		{
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600383E")]
		[Address(RVA = "0x2EC6A70", Offset = "0x2EC5A70", VA = "0x182EC6A70")]
		private IEnumerator IgniteFlareRoutine()
		{
			return null;
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x2EC6A60", Offset = "0x2EC5A60", VA = "0x182EC6A60", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x2EC6ED0", Offset = "0x2EC5ED0", VA = "0x182EC6ED0", Slot = "33")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003841")]
		[Address(RVA = "0x2EC6690", Offset = "0x2EC5690", VA = "0x182EC6690", Slot = "32")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00010770 File Offset: 0x0000E970
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x2EC6B70", Offset = "0x2EC5B70", VA = "0x182EC6B70", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "27")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x2EC79B0", Offset = "0x2EC69B0", VA = "0x182EC79B0", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x2EC7890", Offset = "0x2EC6890", VA = "0x182EC7890")]
		public void UpdateLightStimuli(bool lightActive)
		{
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003846")]
		[Address(RVA = "0x2EC66F0", Offset = "0x2EC56F0", VA = "0x182EC66F0", Slot = "36")]
		public void Burn()
		{
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06003847 RID: 14407 RVA: 0x00010788 File Offset: 0x0000E988
		// (set) Token: 0x06003848 RID: 14408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000709")]
		public bool IsBurning
		{
			[Token(Token = "0x6003847")]
			[Address(RVA = "0x2EC7A60", Offset = "0x2EC6A60", VA = "0x182EC7A60", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003848")]
			[Address(RVA = "0x2EC7A70", Offset = "0x2EC6A70", VA = "0x182EC7A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003849")]
		[Address(RVA = "0x2EC6910", Offset = "0x2EC5910", VA = "0x182EC6910")]
		private void EnableLitObjects(bool enable)
		{
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x2EC7920", Offset = "0x2EC6920", VA = "0x182EC7920")]
		private void UpdateSfx()
		{
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x2EC7570", Offset = "0x2EC6570", VA = "0x182EC7570")]
		private void StartSfx()
		{
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x2EC7720", Offset = "0x2EC6720", VA = "0x182EC7720")]
		private void StopSfx()
		{
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384D")]
		[Address(RVA = "0x2EC7A40", Offset = "0x2EC6A40", VA = "0x182EC7A40")]
		public FlareWeaponController()
		{
		}

		// Token: 0x04003009 RID: 12297
		[Token(Token = "0x4003009")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private AmmoProperties _litAmmo;

		// Token: 0x0400300A RID: 12298
		[Token(Token = "0x400300A")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private AmmoProperties _unlitAmmo;

		// Token: 0x0400300B RID: 12299
		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private float _stimuliIllumination;

		// Token: 0x0400300C RID: 12300
		[Token(Token = "0x400300C")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[EventRef]
		private string _flareBurningEvent;

		// Token: 0x0400300D RID: 12301
		[Token(Token = "0x400300D")]
		[FieldOffset(Offset = "0x188")]
		private EventInstance _flareBurningSfx;

		// Token: 0x0400300E RID: 12302
		[Token(Token = "0x400300E")]
		[FieldOffset(Offset = "0x190")]
		private bool _isBeingLit;

		// Token: 0x0400300F RID: 12303
		[Token(Token = "0x400300F")]
		[FieldOffset(Offset = "0x191")]
		private bool _isLit;

		// Token: 0x04003010 RID: 12304
		[Token(Token = "0x4003010")]
		[FieldOffset(Offset = "0x192")]
		private bool _needToReEquipLeftHandItem;

		// Token: 0x04003011 RID: 12305
		[Token(Token = "0x4003011")]
		[FieldOffset(Offset = "0x198")]
		private BurnableObjectsActivator[] _burnableObjectsActivators;
	}
}

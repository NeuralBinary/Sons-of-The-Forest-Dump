using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Interfaces;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x020008AE RID: 2222
	[Token(Token = "0x20008AE")]
	[AddComponentMenu("Sons/Weapon/FlareWeaponController")]
	public class FlareWeaponController : RangedWeaponController, IBurnable
	{
		// Token: 0x06003F4C RID: 16204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4C")]
		[Address(RVA = "0x35E27B0", Offset = "0x35E0DB0", VA = "0x1835E27B0", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4D")]
		[Address(RVA = "0x35E2830", Offset = "0x35E0E30", VA = "0x1835E2830", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform playerRootTransform, Transform playerBaseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x35E28C0", Offset = "0x35E0EC0", VA = "0x1835E28C0", Slot = "14")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4F")]
		[Address(RVA = "0x35E29F0", Offset = "0x35E0FF0", VA = "0x1835E29F0", Slot = "15")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F50")]
		[Address(RVA = "0x35E2B20", Offset = "0x35E1120", VA = "0x1835E2B20")]
		private void OnActivated()
		{
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F51")]
		[Address(RVA = "0x35E2CD0", Offset = "0x35E12D0", VA = "0x1835E2CD0", Slot = "25")]
		protected override void OnSecondaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F52")]
		[Address(RVA = "0x35E2FF0", Offset = "0x35E15F0", VA = "0x1835E2FF0")]
		private void LeftHandReady()
		{
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F53")]
		[Address(RVA = "0x35E3140", Offset = "0x35E1740", VA = "0x1835E3140")]
		private IEnumerator IgniteFlareRoutine()
		{
			return null;
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F54")]
		[Address(RVA = "0x35E31D0", Offset = "0x35E17D0", VA = "0x1835E31D0", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x35E31E0", Offset = "0x35E17E0", VA = "0x1835E31E0", Slot = "34")]
		protected override void OnItemLeavesHandCallback()
		{
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x35E3780", Offset = "0x35E1D80", VA = "0x1835E3780", Slot = "33")]
		protected override void AttackEndCallback()
		{
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00013518 File Offset: 0x00011718
		[Token(Token = "0x6003F57")]
		[Address(RVA = "0x35E37E0", Offset = "0x35E1DE0", VA = "0x1835E37E0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public override void TriggerShotFiredAudio()
		{
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x35E3870", Offset = "0x35E1E70", VA = "0x1835E3870", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F5A")]
		[Address(RVA = "0x35E39A0", Offset = "0x35E1FA0", VA = "0x1835E39A0")]
		public void UpdateLightStimuli(bool lightActive)
		{
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x35E3A30", Offset = "0x35E2030", VA = "0x1835E3A30", Slot = "37")]
		public void Burn()
		{
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06003F5C RID: 16220 RVA: 0x00013530 File Offset: 0x00011730
		// (set) Token: 0x06003F5D RID: 16221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082A")]
		public bool IsBurning
		{
			[Token(Token = "0x6003F5C")]
			[Address(RVA = "0x35E3CA0", Offset = "0x35E22A0", VA = "0x1835E3CA0", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003F5D")]
			[Address(RVA = "0x35E3CB0", Offset = "0x35E22B0", VA = "0x1835E3CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F5E")]
		[Address(RVA = "0x35E3CC0", Offset = "0x35E22C0", VA = "0x1835E3CC0")]
		private void EnableLitObjects(bool enable)
		{
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F5F")]
		[Address(RVA = "0x35E3E50", Offset = "0x35E2450", VA = "0x1835E3E50")]
		private void UpdateSfx()
		{
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F60")]
		[Address(RVA = "0x35E3F80", Offset = "0x35E2580", VA = "0x1835E3F80")]
		private void StartSfx()
		{
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F61")]
		[Address(RVA = "0x35E4130", Offset = "0x35E2730", VA = "0x1835E4130")]
		private void StopSfx()
		{
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F62")]
		[Address(RVA = "0x35E41D0", Offset = "0x35E27D0", VA = "0x1835E41D0")]
		public FlareWeaponController()
		{
		}

		// Token: 0x040034CF RID: 13519
		[Token(Token = "0x40034CF")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private AmmoProperties _litAmmo;

		// Token: 0x040034D0 RID: 13520
		[Token(Token = "0x40034D0")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private AmmoProperties _unlitAmmo;

		// Token: 0x040034D1 RID: 13521
		[Token(Token = "0x40034D1")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private float _stimuliIllumination;

		// Token: 0x040034D2 RID: 13522
		[Token(Token = "0x40034D2")]
		[FieldOffset(Offset = "0x180")]
		[EventRef]
		[SerializeField]
		private string _flareBurningEvent;

		// Token: 0x040034D3 RID: 13523
		[Token(Token = "0x40034D3")]
		[FieldOffset(Offset = "0x188")]
		private EventInstance _flareBurningSfx;

		// Token: 0x040034D4 RID: 13524
		[Token(Token = "0x40034D4")]
		[FieldOffset(Offset = "0x190")]
		private bool _isBeingLit;

		// Token: 0x040034D5 RID: 13525
		[Token(Token = "0x40034D5")]
		[FieldOffset(Offset = "0x191")]
		private bool _isLit;

		// Token: 0x040034D6 RID: 13526
		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x192")]
		private bool _needToReEquipLeftHandItem;

		// Token: 0x040034D7 RID: 13527
		[Token(Token = "0x40034D7")]
		[FieldOffset(Offset = "0x198")]
		private BurnableObjectsActivator[] _burnableObjectsActivators;
	}
}

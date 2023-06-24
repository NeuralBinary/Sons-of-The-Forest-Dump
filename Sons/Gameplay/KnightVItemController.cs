using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x02000745 RID: 1861
	[Token(Token = "0x2000745")]
	[AddComponentMenu("Sons/Gameplay/KnightVItemController")]
	public class KnightVItemController : HeldControllerBase, IItemInstanceModuleConsumer
	{
		// Token: 0x060031BF RID: 12735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BF")]
		[Address(RVA = "0x3490910", Offset = "0x348EF10", VA = "0x183490910", Slot = "10")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C0")]
		[Address(RVA = "0x34909D0", Offset = "0x348EFD0", VA = "0x1834909D0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C1")]
		[Address(RVA = "0x3490BB0", Offset = "0x348F1B0", VA = "0x183490BB0")]
		private void OnActivateRidingTriggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C2")]
		[Address(RVA = "0x3490BC0", Offset = "0x348F1C0", VA = "0x183490BC0")]
		private void ActivateRiding()
		{
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C3")]
		[Address(RVA = "0x3490E50", Offset = "0x348F450", VA = "0x183490E50")]
		private void SetIsInMidAction()
		{
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C4")]
		[Address(RVA = "0x3490EC0", Offset = "0x348F4C0", VA = "0x183490EC0")]
		private void ClearIsInMidAction()
		{
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x0000F108 File Offset: 0x0000D308
		[Token(Token = "0x60031C5")]
		[Address(RVA = "0x3490F30", Offset = "0x348F530", VA = "0x183490F30")]
		private bool TransferItemToFeet()
		{
			return default(bool);
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C6")]
		[Address(RVA = "0x3490FF0", Offset = "0x348F5F0", VA = "0x183490FF0")]
		private void ClearActivateRidingCallback()
		{
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C7")]
		[Address(RVA = "0x3491160", Offset = "0x348F760", VA = "0x183491160")]
		private void LateUpdate()
		{
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x0000F120 File Offset: 0x0000D320
		[Token(Token = "0x60031C8")]
		[Address(RVA = "0x34913C0", Offset = "0x348F9C0", VA = "0x1834913C0")]
		private bool CheckIfReady()
		{
			return default(bool);
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C9")]
		[Address(RVA = "0x3491520", Offset = "0x348FB20", VA = "0x183491520")]
		private void CheckPlayerSwitchToRiding()
		{
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x0000F138 File Offset: 0x0000D338
		[Token(Token = "0x60031CA")]
		[Address(RVA = "0x3491590", Offset = "0x348FB90", VA = "0x183491590")]
		private bool IsRiding()
		{
			return default(bool);
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CB")]
		[Address(RVA = "0x34916C0", Offset = "0x348FCC0", VA = "0x1834916C0")]
		private void UpdateRiding()
		{
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CC")]
		[Address(RVA = "0x3491750", Offset = "0x348FD50", VA = "0x183491750")]
		private void UpdateRidingNormalAverage()
		{
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CD")]
		[Address(RVA = "0x3491BA0", Offset = "0x34901A0", VA = "0x183491BA0")]
		private void UpdateRidingDistanceAverage()
		{
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x0000F150 File Offset: 0x0000D350
		[Token(Token = "0x60031CE")]
		[Address(RVA = "0x3491E70", Offset = "0x3490470", VA = "0x183491E70")]
		private Vector3 GetRollingNormalAverage()
		{
			return default(Vector3);
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CF")]
		[Address(RVA = "0x3491FA0", Offset = "0x34905A0", VA = "0x183491FA0")]
		private void OnDisable()
		{
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D0")]
		[Address(RVA = "0x3492120", Offset = "0x3490720", VA = "0x183492120")]
		private void SetVfxEnabled(bool value)
		{
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x0000F168 File Offset: 0x0000D368
		[Token(Token = "0x60031D1")]
		[Address(RVA = "0x3492250", Offset = "0x3490850", VA = "0x183492250", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D2")]
		[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
		public GameObject GetBackupObject()
		{
			return null;
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D3")]
		[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480")]
		public Transform GetDriverTransform()
		{
			return null;
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D4")]
		[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
		public Transform GetWheelTransform()
		{
			return null;
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x0000F180 File Offset: 0x0000D380
		[Token(Token = "0x60031D6")]
		[Address(RVA = "0x2942AF0", Offset = "0x29410F0", VA = "0x182942AF0")]
		public Vector3 GetGroundNormal()
		{
			return default(Vector3);
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x0000F198 File Offset: 0x0000D398
		[Token(Token = "0x60031D7")]
		[Address(RVA = "0x1342C10", Offset = "0x1341210", VA = "0x181342C10")]
		public float GetGroundDistance()
		{
			return 0f;
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D8")]
		[Address(RVA = "0x3492320", Offset = "0x3490920", VA = "0x183492320")]
		public void ShowVelocity(bool value, Vector3 velocity)
		{
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D9")]
		[Address(RVA = "0x34927B0", Offset = "0x3490DB0", VA = "0x1834927B0")]
		public void Dismount()
		{
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DA")]
		[Address(RVA = "0x3492850", Offset = "0x3490E50", VA = "0x183492850")]
		public void SetBushBreaker(bool value)
		{
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x3492970", Offset = "0x3490F70", VA = "0x183492970")]
		public void SetNoiseStimuliActive(bool value)
		{
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DC")]
		[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
		public Transform GetAudioEventSourceTransform()
		{
			return null;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x3492AA0", Offset = "0x34910A0", VA = "0x183492AA0")]
		public void SetBackupEffectActive(bool backupActive)
		{
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DE")]
		[Address(RVA = "0x3492BD0", Offset = "0x34911D0", VA = "0x183492BD0")]
		public void SetBackupLightIntensity(float intensity)
		{
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void TriggerImpactEffect(float impactFactor)
		{
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E0")]
		[Address(RVA = "0x3492E30", Offset = "0x3491430", VA = "0x183492E30")]
		private void UpdatePowerIndicator()
		{
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E1")]
		[Address(RVA = "0x3492E60", Offset = "0x3491460", VA = "0x183492E60")]
		private void CheckAutoRefillBatteries()
		{
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E2")]
		[Address(RVA = "0x3493050", Offset = "0x3491650", VA = "0x183493050")]
		public void DrainPower(float amount)
		{
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[Token(Token = "0x60031E3")]
		[Address(RVA = "0x34930A0", Offset = "0x34916A0", VA = "0x1834930A0")]
		public bool HasPower()
		{
			return default(bool);
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		[Token(Token = "0x1700067E")]
		public float PowerFactorRemaining
		{
			[Token(Token = "0x60031E4")]
			[Address(RVA = "0x34930D0", Offset = "0x34916D0", VA = "0x1834930D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x3493100", Offset = "0x3491700", VA = "0x183493100")]
		public KnightVItemController()
		{
		}

		// Token: 0x04002AEC RID: 10988
		[Token(Token = "0x4002AEC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _groundNormalRaySource;

		// Token: 0x04002AED RID: 10989
		[Token(Token = "0x4002AED")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LayerMask _groundLayerMask;

		// Token: 0x04002AEE RID: 10990
		[Token(Token = "0x4002AEE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _bushBreakerObject;

		// Token: 0x04002AEF RID: 10991
		[Token(Token = "0x4002AEF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _vfxGameObject;

		// Token: 0x04002AF0 RID: 10992
		[Token(Token = "0x4002AF0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _backupGameObject;

		// Token: 0x04002AF1 RID: 10993
		[Token(Token = "0x4002AF1")]
		[FieldOffset(Offset = "0x90")]
		[ColorUsage(false, true)]
		[SerializeField]
		private Color _backupEmissionIntensityInactive;

		// Token: 0x04002AF2 RID: 10994
		[Token(Token = "0x4002AF2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _backupEmissionIntensity;

		// Token: 0x04002AF3 RID: 10995
		[Token(Token = "0x4002AF3")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int _backupLightMaterialIndex;

		// Token: 0x04002AF4 RID: 10996
		[Token(Token = "0x4002AF4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x04002AF5 RID: 10997
		[Token(Token = "0x4002AF5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _audioEventSourceTransform;

		// Token: 0x04002AF6 RID: 10998
		[Token(Token = "0x4002AF6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _wheelTransform;

		// Token: 0x04002AF7 RID: 10999
		[Token(Token = "0x4002AF7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _noiseStimuli;

		// Token: 0x04002AF8 RID: 11000
		[Token(Token = "0x4002AF8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _velocityIndicatorGroup;

		// Token: 0x04002AF9 RID: 11001
		[Token(Token = "0x4002AF9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Transform _velocityIndicatorEnd;

		// Token: 0x04002AFA RID: 11002
		[Token(Token = "0x4002AFA")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Transform _velocityIndicatorLine;

		// Token: 0x04002AFB RID: 11003
		[Token(Token = "0x4002AFB")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float _velocityIndicatorLineScale;

		// Token: 0x04002AFC RID: 11004
		[Token(Token = "0x4002AFC")]
		[FieldOffset(Offset = "0xE4")]
		private Vector3 _rollingNormalAverage;

		// Token: 0x04002AFD RID: 11005
		[Token(Token = "0x4002AFD")]
		[FieldOffset(Offset = "0xF0")]
		private float _rollingDistanceAverage;

		// Token: 0x04002AFE RID: 11006
		[Token(Token = "0x4002AFE")]
		[FieldOffset(Offset = "0xF8")]
		private PlayerKnightVAction _playerKnightVAction;

		// Token: 0x04002AFF RID: 11007
		[Token(Token = "0x4002AFF")]
		[FieldOffset(Offset = "0x100")]
		private Transform _driverTransform;

		// Token: 0x04002B00 RID: 11008
		[Token(Token = "0x4002B00")]
		[FieldOffset(Offset = "0x108")]
		private VolumeContainerItemInstanceModule _powerCapacity;

		// Token: 0x04002B01 RID: 11009
		[Token(Token = "0x4002B01")]
		[FieldOffset(Offset = "0x110")]
		private Vector3[] _rollingNormalAverageSource;

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x118")]
		private float _rollingDistanceAverageSource;

		// Token: 0x04002B03 RID: 11011
		[Token(Token = "0x4002B03")]
		[FieldOffset(Offset = "0x11C")]
		private int _rollingNormalAverageIndex;

		// Token: 0x04002B04 RID: 11012
		[Token(Token = "0x4002B04")]
		[FieldOffset(Offset = "0x120")]
		private bool _activateRidingTriggered;

		// Token: 0x04002B05 RID: 11013
		[Token(Token = "0x4002B05")]
		[FieldOffset(Offset = "0x124")]
		private float _groundNormalMaxDistance;

		// Token: 0x04002B06 RID: 11014
		[Token(Token = "0x4002B06")]
		[FieldOffset(Offset = "0x128")]
		private float _groundDistanceMaxDistance;

		// Token: 0x04002B07 RID: 11015
		[Token(Token = "0x4002B07")]
		[FieldOffset(Offset = "0x12C")]
		private float _rayRadius;

		// Token: 0x04002B08 RID: 11016
		[Token(Token = "0x4002B08")]
		[FieldOffset(Offset = "0x130")]
		private bool _waitingForFeetTransfer;

		// Token: 0x04002B09 RID: 11017
		[Token(Token = "0x4002B09")]
		[FieldOffset(Offset = "0x131")]
		private bool _hasSetIsInMidAction;

		// Token: 0x04002B0A RID: 11018
		[Token(Token = "0x4002B0A")]
		[FieldOffset(Offset = "0x138")]
		private MaterialPropertyBlock _backupLightMaterialPropertyBlock;

		// Token: 0x04002B0B RID: 11019
		[Token(Token = "0x4002B0B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int EmissiveColorId;

		// Token: 0x04002B0C RID: 11020
		[Token(Token = "0x4002B0C")]
		[FieldOffset(Offset = "0x140")]
		[Range(0f, 1f)]
		private float _remainingPower;

		// Token: 0x04002B0D RID: 11021
		[Token(Token = "0x4002B0D")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private BatteryIndicator _batteryIndicator;

		// Token: 0x04002B0E RID: 11022
		[Token(Token = "0x4002B0E")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private float _autoRefillThreshold;

		// Token: 0x04002B0F RID: 11023
		[Token(Token = "0x4002B0F")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[EventRef]
		private string _replaceBatteryAudioEvent;
	}
}

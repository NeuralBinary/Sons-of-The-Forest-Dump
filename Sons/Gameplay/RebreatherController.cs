using System;
using System.Collections;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Multiplayer.Client;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Gameplay
{
	// Token: 0x020007CA RID: 1994
	[Token(Token = "0x20007CA")]
	[AddComponentMenu("Sons/Gameplay/RebreatherController")]
	public class RebreatherController : HeldControllerBase
	{
		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x170006C2")]
		public bool MouthpieceIsLowered
		{
			[Token(Token = "0x60035CD")]
			[Address(RVA = "0x61BF20", Offset = "0x61A520", VA = "0x18061BF20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CE")]
		[Address(RVA = "0x34E8F10", Offset = "0x34E7510", VA = "0x1834E8F10", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CF")]
		[Address(RVA = "0x34E9A60", Offset = "0x34E8060", VA = "0x1834E9A60")]
		private void Update()
		{
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x60035D0")]
		[Address(RVA = "0x34EA0F0", Offset = "0x34E86F0", VA = "0x1834EA0F0")]
		private float CalculateConsumedAirAmount()
		{
			return 0f;
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D1")]
		[Address(RVA = "0x34EA170", Offset = "0x34E8770", VA = "0x1834EA170")]
		private void OnDisable()
		{
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D2")]
		[Address(RVA = "0x34EA350", Offset = "0x34E8950", VA = "0x1834EA350")]
		private void OnValidate()
		{
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D3")]
		[Address(RVA = "0x34EA510", Offset = "0x34E8B10", VA = "0x1834EA510")]
		private void UpdateGauge()
		{
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D4")]
		[Address(RVA = "0x34EA630", Offset = "0x34E8C30", VA = "0x1834EA630")]
		public void RaiseMouthpiece()
		{
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D5")]
		[Address(RVA = "0x34EA660", Offset = "0x34E8C60", VA = "0x1834EA660")]
		public void LowerMouthpiece()
		{
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x34EA690", Offset = "0x34E8C90", VA = "0x1834EA690")]
		private IEnumerator AdjustMouthpieceRoutine(bool lowerMouthpiece)
		{
			return null;
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x34EA750", Offset = "0x34E8D50", VA = "0x1834EA750")]
		private void RemoteUpdateMouthPiece()
		{
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x34EA940", Offset = "0x34E8F40", VA = "0x1834EA940")]
		private void UpdateLight()
		{
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x34EAD20", Offset = "0x34E9320", VA = "0x1834EAD20")]
		private IEnumerator FirstLookAt()
		{
			return null;
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x34EADB0", Offset = "0x34E93B0", VA = "0x1834EADB0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DB")]
		[Address(RVA = "0x34EAEB0", Offset = "0x34E94B0", VA = "0x1834EAEB0")]
		public RebreatherController()
		{
		}

		// Token: 0x04002E6E RID: 11886
		[Token(Token = "0x4002E6E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _airConsumptionRate;

		// Token: 0x04002E6F RID: 11887
		[Token(Token = "0x4002E6F")]
		[FieldOffset(Offset = "0x6C")]
		[Min(0f)]
		[SerializeField]
		private float _airRefillRate;

		// Token: 0x04002E70 RID: 11888
		[Token(Token = "0x4002E70")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _startingGaugeRotation;

		// Token: 0x04002E71 RID: 11889
		[Token(Token = "0x4002E71")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _gaugeRotationRange;

		// Token: 0x04002E72 RID: 11890
		[Token(Token = "0x4002E72")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _gaugePercent;

		// Token: 0x04002E73 RID: 11891
		[Token(Token = "0x4002E73")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationCurve _lightFadeCurve;

		// Token: 0x04002E74 RID: 11892
		[Token(Token = "0x4002E74")]
		[FieldOffset(Offset = "0x88")]
		[Min(0f)]
		[SerializeField]
		private float _maxLightIntensity;

		// Token: 0x04002E75 RID: 11893
		[Token(Token = "0x4002E75")]
		[FieldOffset(Offset = "0x8C")]
		[Min(0f)]
		[SerializeField]
		private float _lightFadeSpeedWhenOutOfWater;

		// Token: 0x04002E76 RID: 11894
		[Token(Token = "0x4002E76")]
		[FieldOffset(Offset = "0x90")]
		[Min(0f)]
		[SerializeField]
		private float _lightFadeSpeedWhenInWater;

		// Token: 0x04002E77 RID: 11895
		[Token(Token = "0x4002E77")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _fadeCurveSpeed;

		// Token: 0x04002E78 RID: 11896
		[Token(Token = "0x4002E78")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _curveDelta;

		// Token: 0x04002E79 RID: 11897
		[Token(Token = "0x4002E79")]
		[FieldOffset(Offset = "0xA0")]
		[EventRef]
		[SerializeField]
		private string _rebreatherAudioEvent;

		// Token: 0x04002E7A RID: 11898
		[Token(Token = "0x4002E7A")]
		[FieldOffset(Offset = "0xA8")]
		[EventRef]
		[SerializeField]
		private string _airRefillAudioEvent;

		// Token: 0x04002E7B RID: 11899
		[Token(Token = "0x4002E7B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _lowerMouthpieceDelay;

		// Token: 0x04002E7C RID: 11900
		[Token(Token = "0x4002E7C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _mouthpiecePrefab;

		// Token: 0x04002E7D RID: 11901
		[Token(Token = "0x4002E7D")]
		[FieldOffset(Offset = "0xC0")]
		private float _lowerMouthpieceDelayStart;

		// Token: 0x04002E7E RID: 11902
		[Token(Token = "0x4002E7E")]
		[FieldOffset(Offset = "0xC8")]
		private EventInstance _rebreatherSfxEvent;

		// Token: 0x04002E7F RID: 11903
		[Token(Token = "0x4002E7F")]
		[FieldOffset(Offset = "0xD0")]
		private EventInstance _airRefillSfxEvent;

		// Token: 0x04002E80 RID: 11904
		[Token(Token = "0x4002E80")]
		[FieldOffset(Offset = "0xD8")]
		private bool _mouthpieceIsLowered;

		// Token: 0x04002E81 RID: 11905
		[Token(Token = "0x4002E81")]
		[FieldOffset(Offset = "0xD9")]
		private bool _isRefilling;

		// Token: 0x04002E82 RID: 11906
		[Token(Token = "0x4002E82")]
		[FieldOffset(Offset = "0xE0")]
		private Transform _gauge;

		// Token: 0x04002E83 RID: 11907
		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0xE8")]
		private HDAdditionalLightData _light;

		// Token: 0x04002E84 RID: 11908
		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0xF0")]
		private VolumeContainerItemInstanceModule _airCapacity;

		// Token: 0x04002E85 RID: 11909
		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0xF8")]
		private Vitals _vitals;

		// Token: 0x04002E86 RID: 11910
		[Token(Token = "0x4002E86")]
		[FieldOffset(Offset = "0x100")]
		private Animator _mouthpieceAnimator;

		// Token: 0x04002E87 RID: 11911
		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x108")]
		private GameObject _mouthpieceInstance;

		// Token: 0x04002E88 RID: 11912
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x110")]
		private Transform _renderableTransform;

		// Token: 0x04002E89 RID: 11913
		[Token(Token = "0x4002E89")]
		[FieldOffset(Offset = "0x118")]
		private CoopPlayerRemoteSetup _remotePlayer;
	}
}

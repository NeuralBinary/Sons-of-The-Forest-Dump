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
	// Token: 0x02000695 RID: 1685
	[Token(Token = "0x2000695")]
	[AddComponentMenu("Sons/Gameplay/RebreatherController")]
	public class RebreatherController : HeldControllerBase
	{
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x0000C678 File Offset: 0x0000A878
		[Token(Token = "0x17000586")]
		public bool MouthpieceIsLowered
		{
			[Token(Token = "0x6002B1C")]
			[Address(RVA = "0x8C5E90", Offset = "0x8C4E90", VA = "0x1808C5E90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0x2DE4160", Offset = "0x2DE3160", VA = "0x182DE4160", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0x2DE5000", Offset = "0x2DE4000", VA = "0x182DE5000")]
		private void Update()
		{
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x0000C690 File Offset: 0x0000A890
		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0x2DE40B0", Offset = "0x2DE30B0", VA = "0x182DE40B0")]
		private float CalculateConsumedAirAmount()
		{
			return default(float);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x2DE4940", Offset = "0x2DE3940", VA = "0x182DE4940")]
		private void OnDisable()
		{
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B21")]
		[Address(RVA = "0x2DE4AC0", Offset = "0x2DE3AC0", VA = "0x182DE4AC0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B22")]
		[Address(RVA = "0x2DE4D40", Offset = "0x2DE3D40", VA = "0x182DE4D40")]
		private void UpdateGauge()
		{
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x2DE4BA0", Offset = "0x2DE3BA0", VA = "0x182DE4BA0")]
		public void RaiseMouthpiece()
		{
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B24")]
		[Address(RVA = "0x2DE48C0", Offset = "0x2DE38C0", VA = "0x182DE48C0")]
		public void LowerMouthpiece()
		{
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B25")]
		[Address(RVA = "0x2DE4030", Offset = "0x2DE3030", VA = "0x182DE4030")]
		private IEnumerator AdjustMouthpieceRoutine(bool lowerMouthpiece)
		{
			return null;
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B26")]
		[Address(RVA = "0x2DE4C20", Offset = "0x2DE3C20", VA = "0x182DE4C20")]
		private void RemoteUpdateMouthPiece()
		{
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B27")]
		[Address(RVA = "0x2DE4DF0", Offset = "0x2DE3DF0", VA = "0x182DE4DF0")]
		private void UpdateLight()
		{
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B28")]
		[Address(RVA = "0x2DE40F0", Offset = "0x2DE30F0", VA = "0x182DE40F0")]
		private IEnumerator FirstLookAt()
		{
			return null;
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[Token(Token = "0x6002B29")]
		[Address(RVA = "0x2DE47B0", Offset = "0x2DE37B0", VA = "0x182DE47B0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B2A")]
		[Address(RVA = "0x2DE5720", Offset = "0x2DE4720", VA = "0x182DE5720")]
		public RebreatherController()
		{
		}

		// Token: 0x040026A4 RID: 9892
		[Token(Token = "0x40026A4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _airConsumptionRate;

		// Token: 0x040026A5 RID: 9893
		[Token(Token = "0x40026A5")]
		[FieldOffset(Offset = "0x74")]
		[Min(0f)]
		[SerializeField]
		private float _airRefillRate;

		// Token: 0x040026A6 RID: 9894
		[Token(Token = "0x40026A6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _startingGaugeRotation;

		// Token: 0x040026A7 RID: 9895
		[Token(Token = "0x40026A7")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _gaugeRotationRange;

		// Token: 0x040026A8 RID: 9896
		[Token(Token = "0x40026A8")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _gaugePercent;

		// Token: 0x040026A9 RID: 9897
		[Token(Token = "0x40026A9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AnimationCurve _lightFadeCurve;

		// Token: 0x040026AA RID: 9898
		[Token(Token = "0x40026AA")]
		[FieldOffset(Offset = "0x90")]
		[Min(0f)]
		[SerializeField]
		private float _maxLightIntensity;

		// Token: 0x040026AB RID: 9899
		[Token(Token = "0x40026AB")]
		[FieldOffset(Offset = "0x94")]
		[Min(0f)]
		[SerializeField]
		private float _lightFadeSpeedWhenOutOfWater;

		// Token: 0x040026AC RID: 9900
		[Token(Token = "0x40026AC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Min(0f)]
		private float _lightFadeSpeedWhenInWater;

		// Token: 0x040026AD RID: 9901
		[Token(Token = "0x40026AD")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _fadeCurveSpeed;

		// Token: 0x040026AE RID: 9902
		[Token(Token = "0x40026AE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _curveDelta;

		// Token: 0x040026AF RID: 9903
		[Token(Token = "0x40026AF")]
		[FieldOffset(Offset = "0xA8")]
		[EventRef]
		[SerializeField]
		private string _rebreatherAudioEvent;

		// Token: 0x040026B0 RID: 9904
		[Token(Token = "0x40026B0")]
		[FieldOffset(Offset = "0xB0")]
		[EventRef]
		[SerializeField]
		private string _airRefillAudioEvent;

		// Token: 0x040026B1 RID: 9905
		[Token(Token = "0x40026B1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _lowerMouthpieceDelay;

		// Token: 0x040026B2 RID: 9906
		[Token(Token = "0x40026B2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _mouthpiecePrefab;

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		[FieldOffset(Offset = "0xC8")]
		private float _lowerMouthpieceDelayStart;

		// Token: 0x040026B4 RID: 9908
		[Token(Token = "0x40026B4")]
		[FieldOffset(Offset = "0xD0")]
		private EventInstance _rebreatherSfxEvent;

		// Token: 0x040026B5 RID: 9909
		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0xD8")]
		private EventInstance _airRefillSfxEvent;

		// Token: 0x040026B6 RID: 9910
		[Token(Token = "0x40026B6")]
		[FieldOffset(Offset = "0xE0")]
		private bool _mouthpieceIsLowered;

		// Token: 0x040026B7 RID: 9911
		[Token(Token = "0x40026B7")]
		[FieldOffset(Offset = "0xE1")]
		private bool _isRefilling;

		// Token: 0x040026B8 RID: 9912
		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0xE8")]
		private Transform _gauge;

		// Token: 0x040026B9 RID: 9913
		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0xF0")]
		private HDAdditionalLightData _light;

		// Token: 0x040026BA RID: 9914
		[Token(Token = "0x40026BA")]
		[FieldOffset(Offset = "0xF8")]
		private VolumeContainerItemInstanceModule _airCapacity;

		// Token: 0x040026BB RID: 9915
		[Token(Token = "0x40026BB")]
		[FieldOffset(Offset = "0x100")]
		private ItemInstance _itemInstance;

		// Token: 0x040026BC RID: 9916
		[Token(Token = "0x40026BC")]
		[FieldOffset(Offset = "0x108")]
		private Vitals _vitals;

		// Token: 0x040026BD RID: 9917
		[Token(Token = "0x40026BD")]
		[FieldOffset(Offset = "0x110")]
		private Animator _mouthpieceAnimator;

		// Token: 0x040026BE RID: 9918
		[Token(Token = "0x40026BE")]
		[FieldOffset(Offset = "0x118")]
		private GameObject _mouthpieceInstance;

		// Token: 0x040026BF RID: 9919
		[Token(Token = "0x40026BF")]
		[FieldOffset(Offset = "0x120")]
		private Transform _renderableTransform;

		// Token: 0x040026C0 RID: 9920
		[Token(Token = "0x40026C0")]
		[FieldOffset(Offset = "0x128")]
		private CoopPlayerRemoteSetup _remotePlayer;
	}
}

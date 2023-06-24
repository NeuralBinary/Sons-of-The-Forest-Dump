using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x0200081A RID: 2074
	[Token(Token = "0x200081A")]
	[AddComponentMenu("Sons/Gameplay/PlayerHangGliderAction")]
	public class PlayerHangGliderAction : MonoBehaviour
	{
		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06003991 RID: 14737 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x1700076D")]
		public bool IsGliding
		{
			[Token(Token = "0x6003991")]
			[Address(RVA = "0xA50BE0", Offset = "0xA4F1E0", VA = "0x180A50BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x1700076E")]
		public float Tilt
		{
			[Token(Token = "0x6003992")]
			[Address(RVA = "0x728340", Offset = "0x726940", VA = "0x180728340")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003993")]
		[Address(RVA = "0x35591F0", Offset = "0x35577F0", VA = "0x1835591F0")]
		private void Start()
		{
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x35592A0", Offset = "0x35578A0", VA = "0x1835592A0")]
		public void SetActive(bool isActive, Transform hangGliderTransform)
		{
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x3559380", Offset = "0x3557980", VA = "0x183559380")]
		private void OnEnable()
		{
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x35593A0", Offset = "0x35579A0", VA = "0x1835593A0")]
		private void Update()
		{
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x35594A0", Offset = "0x3557AA0", VA = "0x1835594A0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x35594C0", Offset = "0x3557AC0", VA = "0x1835594C0")]
		private void UpdateInput()
		{
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003999")]
		[Address(RVA = "0x3559710", Offset = "0x3557D10", VA = "0x183559710")]
		private void UpdateGliding()
		{
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399A")]
		[Address(RVA = "0x3559CB0", Offset = "0x35582B0", VA = "0x183559CB0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399B")]
		[Address(RVA = "0x355A1A0", Offset = "0x35587A0", VA = "0x18355A1A0")]
		private static void FadeValue(ref float sourceValue, float fadeRate)
		{
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399C")]
		[Address(RVA = "0x355A250", Offset = "0x3558850", VA = "0x18355A250")]
		private static void FadeValue(ref Vector3 sourceValue, float fadeRate)
		{
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399D")]
		[Address(RVA = "0x355A3C0", Offset = "0x35589C0", VA = "0x18355A3C0")]
		private void CheckForcedDisconnect()
		{
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399E")]
		[Address(RVA = "0x355A700", Offset = "0x3558D00", VA = "0x18355A700")]
		private void UpdateAudioEventParams()
		{
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x355A8F0", Offset = "0x3558EF0", VA = "0x18355A8F0")]
		private void BeginGliding()
		{
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x355B740", Offset = "0x3559D40", VA = "0x18355B740")]
		private void ApplyInitialUplift(Rigidbody targetRigidbody)
		{
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A1")]
		[Address(RVA = "0x355B970", Offset = "0x3559F70", VA = "0x18355B970")]
		private void GetDriverPositionAndRotation(out Vector3 position, out Quaternion rotation)
		{
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A2")]
		[Address(RVA = "0x355BBE0", Offset = "0x355A1E0", VA = "0x18355BBE0")]
		private static void CalculatePlayerDriverPositionAndRotation(out Vector3 position, out Quaternion rotation)
		{
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A3")]
		[Address(RVA = "0x355BDC0", Offset = "0x355A3C0", VA = "0x18355BDC0")]
		private void StopGliding()
		{
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0x355CB30", Offset = "0x355B130", VA = "0x18355CB30")]
		private void OnHitObstacle(Collider obj)
		{
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0x355CCB0", Offset = "0x355B2B0", VA = "0x18355CCB0")]
		public void TriggerHitObstacle()
		{
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x60039A6")]
		[Address(RVA = "0x355CD20", Offset = "0x355B320", VA = "0x18355CD20")]
		private static Vector2 GetMovementInput()
		{
			return default(Vector2);
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A7")]
		[Address(RVA = "0x355CDF0", Offset = "0x355B3F0", VA = "0x18355CDF0")]
		public PlayerHangGliderAction()
		{
		}

		// Token: 0x0400314E RID: 12622
		[Token(Token = "0x400314E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _timeInAirBeforeGlideActivation;

		// Token: 0x0400314F RID: 12623
		[Token(Token = "0x400314F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _initialUplift;

		// Token: 0x04003150 RID: 12624
		[Token(Token = "0x4003150")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve _shapedPitchFactorCurve;

		// Token: 0x04003151 RID: 12625
		[Token(Token = "0x4003151")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("_baseForce")]
		[SerializeField]
		private float _baseDownPitchForce;

		// Token: 0x04003152 RID: 12626
		[Token(Token = "0x4003152")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _forwardMomentumFade;

		// Token: 0x04003153 RID: 12627
		[Token(Token = "0x4003153")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _velocityFade;

		// Token: 0x04003154 RID: 12628
		[Token(Token = "0x4003154")]
		[FieldOffset(Offset = "0x3C")]
		[FormerlySerializedAs("_rotationFade")]
		[SerializeField]
		private float _headingFade;

		// Token: 0x04003155 RID: 12629
		[Token(Token = "0x4003155")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _tiltFade;

		// Token: 0x04003156 RID: 12630
		[Token(Token = "0x4003156")]
		[FieldOffset(Offset = "0x44")]
		[FormerlySerializedAs("_downForce")]
		[SerializeField]
		private float _constantDownForce;

		// Token: 0x04003157 RID: 12631
		[Token(Token = "0x4003157")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _upPitchDownForce;

		// Token: 0x04003158 RID: 12632
		[Token(Token = "0x4003158")]
		[FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("_baseForward")]
		[SerializeField]
		private float _constantForwardForce;

		// Token: 0x04003159 RID: 12633
		[Token(Token = "0x4003159")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _minMaxPitch;

		// Token: 0x0400315A RID: 12634
		[Token(Token = "0x400315A")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _minMaxTilt;

		// Token: 0x0400315B RID: 12635
		[Token(Token = "0x400315B")]
		[FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("_turnInputRate")]
		[SerializeField]
		private float _headingInputRate;

		// Token: 0x0400315C RID: 12636
		[Token(Token = "0x400315C")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _pitchInputRate;

		// Token: 0x0400315D RID: 12637
		[Token(Token = "0x400315D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _tiltInputRate;

		// Token: 0x0400315E RID: 12638
		[Token(Token = "0x400315E")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _tiltRotationScale;

		// Token: 0x0400315F RID: 12639
		[Token(Token = "0x400315F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Collider _obstacleCollider;

		// Token: 0x04003160 RID: 12640
		[Token(Token = "0x4003160")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OnTriggerProxy _obstacleTriggerProxy;

		// Token: 0x04003161 RID: 12641
		[Token(Token = "0x4003161")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private LayerMask _obstacleLayers;

		// Token: 0x04003162 RID: 12642
		[Token(Token = "0x4003162")]
		[FieldOffset(Offset = "0x80")]
		[EventRef]
		[SerializeField]
		private string _gliderAudioEvent;

		// Token: 0x04003163 RID: 12643
		[Token(Token = "0x4003163")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _maxAudioVelocity;

		// Token: 0x04003164 RID: 12644
		[Token(Token = "0x4003164")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _heightFromGroundDisconnect;

		// Token: 0x04003165 RID: 12645
		[Token(Token = "0x4003165")]
		[FieldOffset(Offset = "0x90")]
		private float _heading;

		// Token: 0x04003166 RID: 12646
		[Token(Token = "0x4003166")]
		[FieldOffset(Offset = "0x94")]
		private float _forwardMomentum;

		// Token: 0x04003167 RID: 12647
		[Token(Token = "0x4003167")]
		[FieldOffset(Offset = "0x98")]
		private float _pitch;

		// Token: 0x04003168 RID: 12648
		[Token(Token = "0x4003168")]
		[FieldOffset(Offset = "0x9C")]
		private float _tilt;

		// Token: 0x04003169 RID: 12649
		[Token(Token = "0x4003169")]
		[FieldOffset(Offset = "0xA0")]
		private float _timeInAir;

		// Token: 0x0400316A RID: 12650
		[Token(Token = "0x400316A")]
		[FieldOffset(Offset = "0xA4")]
		private bool _isGliding;

		// Token: 0x0400316B RID: 12651
		[Token(Token = "0x400316B")]
		[FieldOffset(Offset = "0xA5")]
		private bool _hasHitObstacle;

		// Token: 0x0400316C RID: 12652
		[Token(Token = "0x400316C")]
		[FieldOffset(Offset = "0xA8")]
		private Transform _hangGliderTransform;

		// Token: 0x0400316D RID: 12653
		[Token(Token = "0x400316D")]
		[FieldOffset(Offset = "0xB0")]
		private Transform _guideTransform;

		// Token: 0x0400316E RID: 12654
		[Token(Token = "0x400316E")]
		[FieldOffset(Offset = "0xB8")]
		private Transform _driverTransform;

		// Token: 0x0400316F RID: 12655
		[Token(Token = "0x400316F")]
		[FieldOffset(Offset = "0xC0")]
		private Rigidbody _rigidbody;

		// Token: 0x04003170 RID: 12656
		[Token(Token = "0x4003170")]
		[FieldOffset(Offset = "0xC8")]
		private ParentConstraint _parentConstraint;

		// Token: 0x04003171 RID: 12657
		[Token(Token = "0x4003171")]
		[FieldOffset(Offset = "0xD0")]
		private EventInstance _gliderEventInstance;

		// Token: 0x04003172 RID: 12658
		[Token(Token = "0x4003172")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3 _currentInput;

		// Token: 0x04003173 RID: 12659
		[Token(Token = "0x4003173")]
		private const string GlideSpeedParamKey = "glide_speed";
	}
}

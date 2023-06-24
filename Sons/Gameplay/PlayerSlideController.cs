using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	public class PlayerSlideController : MonoBehaviour
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06003564 RID: 13668 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003565 RID: 13669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000029")]
		public event Action OnStartSlide
		{
			[Token(Token = "0x6003564")]
			[Address(RVA = "0x34DF3A0", Offset = "0x34DD9A0", VA = "0x1834DF3A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003565")]
			[Address(RVA = "0x34DF490", Offset = "0x34DDA90", VA = "0x1834DF490")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06003566 RID: 13670 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003567 RID: 13671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002A")]
		public event Action OnStopSlide
		{
			[Token(Token = "0x6003566")]
			[Address(RVA = "0x34DF580", Offset = "0x34DDB80", VA = "0x1834DF580")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003567")]
			[Address(RVA = "0x34DF670", Offset = "0x34DDC70", VA = "0x1834DF670")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x00010008 File Offset: 0x0000E208
		[Token(Token = "0x6003568")]
		[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
		public float GetRotationSpeed()
		{
			return 0f;
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00010020 File Offset: 0x0000E220
		[Token(Token = "0x6003569")]
		[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
		public float GetAngleSpeed()
		{
			return 0f;
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356A")]
		[Address(RVA = "0x34DF760", Offset = "0x34DDD60", VA = "0x1834DF760")]
		private void OnValidate()
		{
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356B")]
		[Address(RVA = "0x34DFBE0", Offset = "0x34DE1E0", VA = "0x1834DFBE0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356C")]
		[Address(RVA = "0x34DFDC0", Offset = "0x34DE3C0", VA = "0x1834DFDC0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356D")]
		[Address(RVA = "0x34DFEA0", Offset = "0x34DE4A0", VA = "0x1834DFEA0")]
		private void OnTriggerEnter(Collider inCollider)
		{
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356E")]
		[Address(RVA = "0x34E0060", Offset = "0x34DE660", VA = "0x1834E0060")]
		private void OnTriggerExit(Collider inCollider)
		{
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356F")]
		[Address(RVA = "0x34E02B0", Offset = "0x34DE8B0", VA = "0x1834E02B0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003570")]
		[Address(RVA = "0x34E0360", Offset = "0x34DE960", VA = "0x1834E0360")]
		public void SliderStageUpdate()
		{
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003571")]
		[Address(RVA = "0x34E03B0", Offset = "0x34DE9B0", VA = "0x1834E03B0")]
		public void StartSlideDown()
		{
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003572")]
		[Address(RVA = "0x34E07C0", Offset = "0x34DEDC0", VA = "0x1834E07C0")]
		private IEnumerator StartWaitForPlayerSlide()
		{
			return null;
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x6003573")]
		[Address(RVA = "0x34E0850", Offset = "0x34DEE50", VA = "0x1834E0850")]
		public bool IsMidSlideDown()
		{
			return default(bool);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003574")]
		[Address(RVA = "0x34E0870", Offset = "0x34DEE70", VA = "0x1834E0870")]
		private void UpdateSlideDown()
		{
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003575")]
		[Address(RVA = "0x34E14E0", Offset = "0x34DFAE0", VA = "0x1834E14E0")]
		private void ClearSlideDown()
		{
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003576")]
		[Address(RVA = "0x34E1910", Offset = "0x34DFF10", VA = "0x1834E1910")]
		private IEnumerator FinishWaitForPlayerIdle()
		{
			return null;
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003577")]
		[Address(RVA = "0x34E19A0", Offset = "0x34DFFA0", VA = "0x1834E19A0")]
		private void Add(PlayerSlideTrigger slideTrigger)
		{
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003578")]
		[Address(RVA = "0x34E1A90", Offset = "0x34E0090", VA = "0x1834E1A90")]
		private void RefreshTrigger()
		{
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003579")]
		[Address(RVA = "0x34E1AA0", Offset = "0x34E00A0", VA = "0x1834E1AA0")]
		private void Remove(PlayerSlideTrigger slideTrigger)
		{
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357A")]
		[Address(RVA = "0x34E1C20", Offset = "0x34E0220", VA = "0x1834E1C20")]
		public void GetForce(out Vector3 aim, out Vector3 force)
		{
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357B")]
		[Address(RVA = "0x2586730", Offset = "0x2584D30", VA = "0x182586730")]
		public void SetBlocked(bool blocked)
		{
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357C")]
		[Address(RVA = "0x2586750", Offset = "0x2584D50", VA = "0x182586750")]
		public void SetTriggerSlide(bool triggerSlide)
		{
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357D")]
		[Address(RVA = "0x34E2120", Offset = "0x34E0720", VA = "0x1834E2120")]
		public PlayerSlideController()
		{
		}

		// Token: 0x04002E21 RID: 11809
		[Token(Token = "0x4002E21")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TriggerProxy _triggerProxy;

		// Token: 0x04002E22 RID: 11810
		[Token(Token = "0x4002E22")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_playerAnimator")]
		[SerializeField]
		private Animator _targetAnimator;

		// Token: 0x04002E23 RID: 11811
		[Token(Token = "0x4002E23")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Rigidbody _targetRigidbody;

		// Token: 0x04002E24 RID: 11812
		[Token(Token = "0x4002E24")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _maxDistance;

		// Token: 0x04002E25 RID: 11813
		[Token(Token = "0x4002E25")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _rotationSpeed;

		// Token: 0x04002E26 RID: 11814
		[Token(Token = "0x4002E26")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _angleSpeed;

		// Token: 0x04002E27 RID: 11815
		[Token(Token = "0x4002E27")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _baseAntiGravity;

		// Token: 0x04002E28 RID: 11816
		[Token(Token = "0x4002E28")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LayerMask _slideLayerMask;

		// Token: 0x04002E29 RID: 11817
		[Token(Token = "0x4002E29")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector2 _mouseRotatorLimit;

		// Token: 0x04002E2A RID: 11818
		[Token(Token = "0x4002E2A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SonsFMODEventEmitter _slideEmitter;

		// Token: 0x04002E2B RID: 11819
		[Token(Token = "0x4002E2B")]
		[FieldOffset(Offset = "0x60")]
		private ForceMode _forceMode;

		// Token: 0x04002E2C RID: 11820
		[Token(Token = "0x4002E2C")]
		[FieldOffset(Offset = "0x64")]
		private bool _showDebugVectors;

		// Token: 0x04002E2D RID: 11821
		[Token(Token = "0x4002E2D")]
		[FieldOffset(Offset = "0x68")]
		private float _sampledTerrainAngle;

		// Token: 0x04002E2E RID: 11822
		[Token(Token = "0x4002E2E")]
		[FieldOffset(Offset = "0x6C")]
		private float _smoothedTerrainAngle;

		// Token: 0x04002E2F RID: 11823
		[Token(Token = "0x4002E2F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _activeUniqueSlideCount;

		// Token: 0x04002E30 RID: 11824
		[Token(Token = "0x4002E30")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<PlayerSlideTrigger, int> _referenceCounters;

		// Token: 0x04002E31 RID: 11825
		[Token(Token = "0x4002E31")]
		[FieldOffset(Offset = "0x80")]
		private bool _blocked;

		// Token: 0x04002E32 RID: 11826
		[Token(Token = "0x4002E32")]
		[FieldOffset(Offset = "0x81")]
		private bool _triggerSlide;

		// Token: 0x04002E33 RID: 11827
		[Token(Token = "0x4002E33")]
		[FieldOffset(Offset = "0x82")]
		private bool _hasTriggeredSlide;

		// Token: 0x04002E34 RID: 11828
		[Token(Token = "0x4002E34")]
		[FieldOffset(Offset = "0x84")]
		private float _slideDownStartTime;
	}
}

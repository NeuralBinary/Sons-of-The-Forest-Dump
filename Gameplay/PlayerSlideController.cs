using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x02000690 RID: 1680
	[Token(Token = "0x2000690")]
	public class PlayerSlideController : MonoBehaviour
	{
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06002AF3 RID: 10995 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002AF4 RID: 10996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000021")]
		public event Action OnStartSlide
		{
			[Token(Token = "0x6002AF3")]
			[Address(RVA = "0x2DDD090", Offset = "0x2DDC090", VA = "0x182DDD090")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002AF4")]
			[Address(RVA = "0x2DDD1D0", Offset = "0x2DDC1D0", VA = "0x182DDD1D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06002AF5 RID: 10997 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002AF6 RID: 10998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000022")]
		public event Action OnStopSlide
		{
			[Token(Token = "0x6002AF5")]
			[Address(RVA = "0x2DDD130", Offset = "0x2DDC130", VA = "0x182DDD130")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002AF6")]
			[Address(RVA = "0x2DDD270", Offset = "0x2DDC270", VA = "0x182DDD270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x0000C600 File Offset: 0x0000A800
		[Token(Token = "0x6002AF7")]
		[Address(RVA = "0x2004010", Offset = "0x2003010", VA = "0x182004010")]
		public float GetRotationSpeed()
		{
			return default(float);
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x0000C618 File Offset: 0x0000A818
		[Token(Token = "0x6002AF8")]
		[Address(RVA = "0x6C5560", Offset = "0x6C4560", VA = "0x1806C5560")]
		public float GetAngleSpeed()
		{
			return default(float);
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AF9")]
		[Address(RVA = "0x2DDC210", Offset = "0x2DDB210", VA = "0x182DDC210")]
		private void OnValidate()
		{
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0x2DDBE30", Offset = "0x2DDAE30", VA = "0x182DDBE30")]
		private void OnEnable()
		{
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0x2DDBD50", Offset = "0x2DDAD50", VA = "0x182DDBD50")]
		private void OnDisable()
		{
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0x2DDBF70", Offset = "0x2DDAF70", VA = "0x182DDBF70")]
		private void OnTriggerEnter(Collider inCollider)
		{
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFD")]
		[Address(RVA = "0x2DDC080", Offset = "0x2DDB080", VA = "0x182DDC080")]
		private void OnTriggerExit(Collider inCollider)
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFE")]
		[Address(RVA = "0x2DDB970", Offset = "0x2DDA970", VA = "0x182DDB970")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFF")]
		[Address(RVA = "0x2DDC4D0", Offset = "0x2DDB4D0", VA = "0x182DDC4D0")]
		public void SliderStageUpdate()
		{
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B00")]
		[Address(RVA = "0x2DDC520", Offset = "0x2DDB520", VA = "0x182DDC520")]
		public void StartSlideDown()
		{
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x0000C630 File Offset: 0x0000A830
		[Token(Token = "0x6002B01")]
		[Address(RVA = "0x2DDBD30", Offset = "0x2DDAD30", VA = "0x182DDBD30")]
		public bool IsMidSlideDown()
		{
			return default(bool);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B02")]
		[Address(RVA = "0x2DDC770", Offset = "0x2DDB770", VA = "0x182DDC770")]
		private void UpdateSlideDown()
		{
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B03")]
		[Address(RVA = "0x2DDB6C0", Offset = "0x2DDA6C0", VA = "0x182DDB6C0")]
		private void ClearSlideDown()
		{
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B04")]
		[Address(RVA = "0x2DDB620", Offset = "0x2DDA620", VA = "0x182DDB620")]
		private void Add(PlayerSlideTrigger slideTrigger)
		{
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B05")]
		[Address(RVA = "0x2DDC3A0", Offset = "0x2DDB3A0", VA = "0x182DDC3A0")]
		private void RefreshTrigger()
		{
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B06")]
		[Address(RVA = "0x2DDC3B0", Offset = "0x2DDB3B0", VA = "0x182DDC3B0")]
		private void Remove(PlayerSlideTrigger slideTrigger)
		{
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B07")]
		[Address(RVA = "0x2DDB9A0", Offset = "0x2DDA9A0", VA = "0x182DDB9A0")]
		public void GetForce(out Vector3 aim, out Vector3 force)
		{
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B08")]
		[Address(RVA = "0x2180920", Offset = "0x217F920", VA = "0x182180920")]
		public void SetBlocked(bool blocked)
		{
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B09")]
		[Address(RVA = "0x2180AB0", Offset = "0x217FAB0", VA = "0x182180AB0")]
		public void SetTriggerSlide(bool triggerSlide)
		{
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B0A")]
		[Address(RVA = "0x2DDCF50", Offset = "0x2DDBF50", VA = "0x182DDCF50")]
		public PlayerSlideController()
		{
		}

		// Token: 0x04002680 RID: 9856
		[Token(Token = "0x4002680")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TriggerProxy _triggerProxy;

		// Token: 0x04002681 RID: 9857
		[Token(Token = "0x4002681")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_playerAnimator")]
		[SerializeField]
		private Animator _targetAnimator;

		// Token: 0x04002682 RID: 9858
		[Token(Token = "0x4002682")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Rigidbody _targetRigidbody;

		// Token: 0x04002683 RID: 9859
		[Token(Token = "0x4002683")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _maxDistance;

		// Token: 0x04002684 RID: 9860
		[Token(Token = "0x4002684")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _rotationSpeed;

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _angleSpeed;

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _baseAntiGravity;

		// Token: 0x04002687 RID: 9863
		[Token(Token = "0x4002687")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LayerMask _slideLayerMask;

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector2 _mouseRotatorLimit;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SonsFMODEventEmitter _slideEmitter;

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		[FieldOffset(Offset = "0x60")]
		private ForceMode _forceMode;

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		[FieldOffset(Offset = "0x64")]
		private bool _showDebugVectors;

		// Token: 0x0400268C RID: 9868
		[Token(Token = "0x400268C")]
		[FieldOffset(Offset = "0x68")]
		private float _sampledTerrainAngle;

		// Token: 0x0400268D RID: 9869
		[Token(Token = "0x400268D")]
		[FieldOffset(Offset = "0x6C")]
		private float _smoothedTerrainAngle;

		// Token: 0x0400268E RID: 9870
		[Token(Token = "0x400268E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _activeUniqueSlideCount;

		// Token: 0x0400268F RID: 9871
		[Token(Token = "0x400268F")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<PlayerSlideTrigger, int> _referenceCounters;

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[FieldOffset(Offset = "0x80")]
		private bool _blocked;

		// Token: 0x04002691 RID: 9873
		[Token(Token = "0x4002691")]
		[FieldOffset(Offset = "0x81")]
		private bool _triggerSlide;

		// Token: 0x04002692 RID: 9874
		[Token(Token = "0x4002692")]
		[FieldOffset(Offset = "0x82")]
		private bool _hasTriggeredSlide;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[FieldOffset(Offset = "0x84")]
		private float _slideDownStartTime;
	}
}

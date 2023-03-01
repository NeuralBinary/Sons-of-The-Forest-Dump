using System;
using Endnight.Animation;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007F7 RID: 2039
	[Token(Token = "0x20007F7")]
	[AddComponentMenu("Sons/Characters/Simple Animal")]
	public class SimpleAnimal : MonoBehaviour, IAnimatorMoveProxyReceiver
	{
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x170006EF")]
		public VailActorTypeId TypeId
		{
			[Token(Token = "0x60035F5")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return default(VailActorTypeId);
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Token(Token = "0x170006F0")]
		public Vector3 Position
		{
			[Token(Token = "0x60035F6")]
			[Address(RVA = "0x255D2A0", Offset = "0x255C2A0", VA = "0x18255D2A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		[Token(Token = "0x170006F1")]
		public bool IsDead
		{
			[Token(Token = "0x60035F7")]
			[Address(RVA = "0x2402880", Offset = "0x2401880", VA = "0x182402880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F8")]
		[Address(RVA = "0x2E9AB10", Offset = "0x2E99B10", VA = "0x182E9AB10")]
		private void Awake()
		{
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F9")]
		[Address(RVA = "0x2E9C050", Offset = "0x2E9B050", VA = "0x182E9C050")]
		private void OnValidate()
		{
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FA")]
		[Address(RVA = "0x2E9BD30", Offset = "0x2E9AD30", VA = "0x182E9BD30")]
		public void OnSpawn(SimpleAnimalZone spawnZone, Vector3 spawnPos, BoundsShape pathBounds)
		{
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FB")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public void OnAnimatorMove()
		{
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FC")]
		[Address(RVA = "0x2E9BC80", Offset = "0x2E9AC80", VA = "0x182E9BC80")]
		private void OnAnimatorInit()
		{
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		[Token(Token = "0x60035FD")]
		[Address(RVA = "0x2E9B940", Offset = "0x2E9A940", VA = "0x182E9B940")]
		private Vector3 GetRandomVelocity()
		{
			return default(Vector3);
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		[Token(Token = "0x60035FE")]
		[Address(RVA = "0x2E9B4F0", Offset = "0x2E9A4F0", VA = "0x182E9B4F0")]
		private Vector3 GetNewVelocity(Vector3 forward, Vector3 right, float maxAngle)
		{
			return default(Vector3);
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FF")]
		[Address(RVA = "0x2E9C5A0", Offset = "0x2E9B5A0", VA = "0x182E9C5A0")]
		public void Scare(Vector3 scarePoint)
		{
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003600")]
		[Address(RVA = "0x2E9AB80", Offset = "0x2E99B80", VA = "0x182E9AB80")]
		private Rigidbody CreateDeadInstance()
		{
			return null;
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003601")]
		[Address(RVA = "0x2E9BB00", Offset = "0x2E9AB00", VA = "0x182E9BB00")]
		public void HitExplosion(float damage, Vector3 centerPoint)
		{
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003602")]
		[Address(RVA = "0x2E9BBF0", Offset = "0x2E9ABF0", VA = "0x182E9BBF0")]
		public void Hit(float damage)
		{
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x0000FA08 File Offset: 0x0000DC08
		[Token(Token = "0x6003603")]
		[Address(RVA = "0x2E9BC50", Offset = "0x2E9AC50", VA = "0x182E9BC50")]
		private bool IsScared()
		{
			return default(bool);
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x0000FA20 File Offset: 0x0000DC20
		[Token(Token = "0x6003604")]
		[Address(RVA = "0x2E9BC10", Offset = "0x2E9AC10", VA = "0x182E9BC10")]
		private bool IsPointInBounds(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003605")]
		[Address(RVA = "0x2E9C9F0", Offset = "0x2E9B9F0", VA = "0x182E9C9F0")]
		public void Tick(float deltaTime, Vector3 viewPos)
		{
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x0000FA38 File Offset: 0x0000DC38
		[Token(Token = "0x6003606")]
		[Address(RVA = "0x2E9C140", Offset = "0x2E9B140", VA = "0x182E9C140")]
		private bool RaycastPathSegment(Vector3 start, Vector3 end)
		{
			return default(bool);
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003607")]
		[Address(RVA = "0x2E9C7A0", Offset = "0x2E9B7A0", VA = "0x182E9C7A0")]
		private void SetTargetVelocityAndRotation(Vector3 targetVel)
		{
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x2E9C210", Offset = "0x2E9B210", VA = "0x182E9C210")]
		private void Repath()
		{
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003609")]
		[Address(RVA = "0x2E9AF70", Offset = "0x2E99F70", VA = "0x182E9AF70")]
		private void DoWanderMove(float deltaTime)
		{
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x2E9CD20", Offset = "0x2E9BD20", VA = "0x182E9CD20")]
		private void UpdateVisibleFish(float deltaTime, bool isScared)
		{
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x2E9D180", Offset = "0x2E9C180", VA = "0x182E9D180")]
		public void WanderInsideBounds(BoundsShape bounds)
		{
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x2E9B300", Offset = "0x2E9A300", VA = "0x182E9B300")]
		public void FollowPath(PathBoundsList boundsList)
		{
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360D")]
		[Address(RVA = "0x2E9ADE0", Offset = "0x2E99DE0", VA = "0x182E9ADE0")]
		public void DoFollowPathMove(float deltaTime)
		{
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360E")]
		[Address(RVA = "0x2E9D1A0", Offset = "0x2E9C1A0", VA = "0x182E9D1A0")]
		public SimpleAnimal()
		{
		}

		// Token: 0x04002E2D RID: 11821
		[Token(Token = "0x4002E2D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailActorTypeId _typeId;

		// Token: 0x04002E2E RID: 11822
		[Token(Token = "0x4002E2E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BoundsShape _pathBounds;

		// Token: 0x04002E2F RID: 11823
		[Token(Token = "0x4002E2F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002E30 RID: 11824
		[Token(Token = "0x4002E30")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FlightPathMover _pathMover;

		// Token: 0x04002E31 RID: 11825
		[Token(Token = "0x4002E31")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _deadPrefab;

		// Token: 0x04002E32 RID: 11826
		[Token(Token = "0x4002E32")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _explodeForceMult;

		// Token: 0x04002E33 RID: 11827
		[Token(Token = "0x4002E33")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector2 _speedRange;

		// Token: 0x04002E34 RID: 11828
		[Token(Token = "0x4002E34")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector2 _animSpeedMinMax;

		// Token: 0x04002E35 RID: 11829
		[Token(Token = "0x4002E35")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _acceleration;

		// Token: 0x04002E36 RID: 11830
		[Token(Token = "0x4002E36")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector2 _repathCooldown;

		// Token: 0x04002E37 RID: 11831
		[Token(Token = "0x4002E37")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Rotation rate in degrees per second")]
		[SerializeField]
		private float _rotateRate;

		// Token: 0x04002E38 RID: 11832
		[Token(Token = "0x4002E38")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _scaredRotateRate;

		// Token: 0x04002E39 RID: 11833
		[Token(Token = "0x4002E39")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _animTurnSpeed;

		// Token: 0x04002E3A RID: 11834
		[Token(Token = "0x4002E3A")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _animTurnMult;

		// Token: 0x04002E3B RID: 11835
		[Token(Token = "0x4002E3B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Tooltip("When randomly re-pathing, this controls how many degrees yaw it will rotate by")]
		private Vector2 _rotateRange;

		// Token: 0x04002E3C RID: 11836
		[Token(Token = "0x4002E3C")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 90f)]
		[SerializeField]
		private float _maxPitch;

		// Token: 0x04002E3D RID: 11837
		[Token(Token = "0x4002E3D")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _scareDuration;

		// Token: 0x04002E3E RID: 11838
		[Token(Token = "0x4002E3E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector2 _scareSpeedRange;

		// Token: 0x04002E3F RID: 11839
		[Token(Token = "0x4002E3F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _scaredAcceleration;

		// Token: 0x04002E40 RID: 11840
		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Vector2 _sizeRange;

		// Token: 0x04002E41 RID: 11841
		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _visualObject;

		// Token: 0x04002E42 RID: 11842
		[Token(Token = "0x4002E42")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Tooltip("If non-zero, will hide visual object further than this distance from view location.")]
		private float _maxVisibleDistance;

		// Token: 0x04002E43 RID: 11843
		[Token(Token = "0x4002E43")]
		[FieldOffset(Offset = "0xAC")]
		private float _repathTime;

		// Token: 0x04002E44 RID: 11844
		[Token(Token = "0x4002E44")]
		[FieldOffset(Offset = "0xB0")]
		private float _avoidRepathTime;

		// Token: 0x04002E45 RID: 11845
		[Token(Token = "0x4002E45")]
		[FieldOffset(Offset = "0xB4")]
		private float _lastScareTime;

		// Token: 0x04002E46 RID: 11846
		[Token(Token = "0x4002E46")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 _position;

		// Token: 0x04002E47 RID: 11847
		[Token(Token = "0x4002E47")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 _velocity;

		// Token: 0x04002E48 RID: 11848
		[Token(Token = "0x4002E48")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 _targetVelocity;

		// Token: 0x04002E49 RID: 11849
		[Token(Token = "0x4002E49")]
		[FieldOffset(Offset = "0xDC")]
		private float _targetSpeed;

		// Token: 0x04002E4A RID: 11850
		[Token(Token = "0x4002E4A")]
		[FieldOffset(Offset = "0xE0")]
		private Quaternion _rotation;

		// Token: 0x04002E4B RID: 11851
		[Token(Token = "0x4002E4B")]
		[FieldOffset(Offset = "0xF0")]
		private Quaternion _startRotation;

		// Token: 0x04002E4C RID: 11852
		[Token(Token = "0x4002E4C")]
		[FieldOffset(Offset = "0x100")]
		private Quaternion _targetRotation;

		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		[FieldOffset(Offset = "0x110")]
		private SimpleAnimalZone _spawnZone;

		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 _prefabScale;

		// Token: 0x04002E4F RID: 11855
		[Token(Token = "0x4002E4F")]
		[FieldOffset(Offset = "0x124")]
		private float _updateSpeedTime;

		// Token: 0x04002E50 RID: 11856
		[Token(Token = "0x4002E50")]
		[FieldOffset(Offset = "0x128")]
		private float _rotationTime;

		// Token: 0x04002E51 RID: 11857
		[Token(Token = "0x4002E51")]
		[FieldOffset(Offset = "0x12C")]
		private float _rotationOneOverDuration;

		// Token: 0x04002E52 RID: 11858
		[Token(Token = "0x4002E52")]
		[FieldOffset(Offset = "0x130")]
		private bool _isVisible;

		// Token: 0x04002E53 RID: 11859
		[Token(Token = "0x4002E53")]
		[FieldOffset(Offset = "0x131")]
		private bool _isDead;

		// Token: 0x04002E54 RID: 11860
		[Token(Token = "0x4002E54")]
		[FieldOffset(Offset = "0x132")]
		private bool _hasAnimator;

		// Token: 0x04002E55 RID: 11861
		[Token(Token = "0x4002E55")]
		[FieldOffset(Offset = "0x133")]
		private bool _hasDirectionParam;

		// Token: 0x04002E56 RID: 11862
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x134")]
		private float _currentDirectionValue;

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x138")]
		private float _animVarTickDelta;

		// Token: 0x04002E58 RID: 11864
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x13C")]
		private int _tickOffset;

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x140")]
		private SimpleAnimal.MoveState _moveState;

		// Token: 0x04002E5A RID: 11866
		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0x148")]
		private Transform _transform;

		// Token: 0x020007F8 RID: 2040
		[Token(Token = "0x20007F8")]
		private enum MoveState
		{
			// Token: 0x04002E5C RID: 11868
			[Token(Token = "0x4002E5C")]
			WanderInBounds,
			// Token: 0x04002E5D RID: 11869
			[Token(Token = "0x4002E5D")]
			FollowPath
		}
	}
}

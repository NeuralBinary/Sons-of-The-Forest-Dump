using System;
using Endnight.Animation;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000705 RID: 1797
	[Token(Token = "0x2000705")]
	[AddComponentMenu("Sons/Characters/Simple Animal")]
	public class SimpleAnimal : MonoBehaviour, IAnimatorMoveProxyReceiver
	{
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x0000E418 File Offset: 0x0000C618
		[Token(Token = "0x17000664")]
		public VailActorTypeId TypeId
		{
			[Token(Token = "0x6002F9A")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return VailActorTypeId.None;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x0000E430 File Offset: 0x0000C630
		[Token(Token = "0x17000665")]
		public Vector3 Position
		{
			[Token(Token = "0x6002F9B")]
			[Address(RVA = "0x2A27420", Offset = "0x2A25A20", VA = "0x182A27420")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x0000E448 File Offset: 0x0000C648
		[Token(Token = "0x17000666")]
		public Vector3 ForwardDir
		{
			[Token(Token = "0x6002F9C")]
			[Address(RVA = "0x3462950", Offset = "0x3460F50", VA = "0x183462950")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x0000E460 File Offset: 0x0000C660
		[Token(Token = "0x17000667")]
		private Vector3 RightDir
		{
			[Token(Token = "0x6002F9D")]
			[Address(RVA = "0x34629E0", Offset = "0x3460FE0", VA = "0x1834629E0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x0000E478 File Offset: 0x0000C678
		[Token(Token = "0x17000668")]
		public bool IsDead
		{
			[Token(Token = "0x6002F9E")]
			[Address(RVA = "0x288F660", Offset = "0x288DC60", VA = "0x18288F660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F9F")]
		[Address(RVA = "0x3462A70", Offset = "0x3461070", VA = "0x183462A70")]
		private void Awake()
		{
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA0")]
		[Address(RVA = "0x3462BA0", Offset = "0x34611A0", VA = "0x183462BA0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA1")]
		[Address(RVA = "0x3462DE0", Offset = "0x34613E0", VA = "0x183462DE0")]
		public void OnSpawn(SimpleAnimalZone spawnZone, Vector3 spawnPos, BoundsShape pathBounds)
		{
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnAnimatorMove()
		{
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA3")]
		[Address(RVA = "0x3463450", Offset = "0x3461A50", VA = "0x183463450")]
		private void OnAnimatorInit()
		{
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x0000E490 File Offset: 0x0000C690
		[Token(Token = "0x6002FA4")]
		[Address(RVA = "0x34636E0", Offset = "0x3461CE0", VA = "0x1834636E0")]
		private Vector3 GetRandomVelocity()
		{
			return default(Vector3);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		[Token(Token = "0x6002FA5")]
		[Address(RVA = "0x34637C0", Offset = "0x3461DC0", VA = "0x1834637C0")]
		private Vector3 GetNewVelocity(Vector3 forward, Vector3 right, float maxAngle)
		{
			return default(Vector3);
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA6")]
		[Address(RVA = "0x3463CD0", Offset = "0x34622D0", VA = "0x183463CD0")]
		public void Scare(Vector3 scarePoint)
		{
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA7")]
		[Address(RVA = "0x3464090", Offset = "0x3462690", VA = "0x183464090")]
		private Rigidbody CreateDeadInstance()
		{
			return null;
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0x34644B0", Offset = "0x3462AB0", VA = "0x1834644B0")]
		public void HitExplosion(float damage, Vector3 centerPoint)
		{
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA9")]
		[Address(RVA = "0x3464640", Offset = "0x3462C40", VA = "0x183464640")]
		public void Hit(float damage)
		{
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0x3464660", Offset = "0x3462C60", VA = "0x183464660")]
		private bool IsScared()
		{
			return default(bool);
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		[Token(Token = "0x6002FAB")]
		[Address(RVA = "0x34646D0", Offset = "0x3462CD0", VA = "0x1834646D0")]
		private bool IsPointInBounds(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0x3464710", Offset = "0x3462D10", VA = "0x183464710")]
		public void Tick(float deltaTime, Vector3 viewPos)
		{
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		[Token(Token = "0x6002FAD")]
		[Address(RVA = "0x3464A00", Offset = "0x3463000", VA = "0x183464A00")]
		private bool RaycastPathSegment(Vector3 start, Vector3 end)
		{
			return default(bool);
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAE")]
		[Address(RVA = "0x3464BD0", Offset = "0x34631D0", VA = "0x183464BD0")]
		private void SetTargetVelocityAndRotation(Vector3 targetVel)
		{
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAF")]
		[Address(RVA = "0x3464DE0", Offset = "0x34633E0", VA = "0x183464DE0")]
		private void Repath()
		{
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB0")]
		[Address(RVA = "0x3465380", Offset = "0x3463980", VA = "0x183465380")]
		private void DoWanderMove(float deltaTime)
		{
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB1")]
		[Address(RVA = "0x3465650", Offset = "0x3463C50", VA = "0x183465650")]
		private void UpdateVisibleFish(float deltaTime, bool isScared)
		{
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB2")]
		[Address(RVA = "0x3465B20", Offset = "0x3464120", VA = "0x183465B20")]
		public void WanderInsideBounds(BoundsShape bounds)
		{
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB3")]
		[Address(RVA = "0x3465B80", Offset = "0x3464180", VA = "0x183465B80")]
		public void FollowPath(PathBoundsList boundsList)
		{
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB4")]
		[Address(RVA = "0x3465DC0", Offset = "0x34643C0", VA = "0x183465DC0")]
		public void DoFollowPathMove(float deltaTime)
		{
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x34660E0", Offset = "0x34646E0", VA = "0x1834660E0")]
		public SimpleAnimal()
		{
		}

		// Token: 0x0400291E RID: 10526
		[Token(Token = "0x400291E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailActorTypeId _typeId;

		// Token: 0x0400291F RID: 10527
		[Token(Token = "0x400291F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BoundsShape _pathBounds;

		// Token: 0x04002920 RID: 10528
		[Token(Token = "0x4002920")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002921 RID: 10529
		[Token(Token = "0x4002921")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FlightPathMover _pathMover;

		// Token: 0x04002922 RID: 10530
		[Token(Token = "0x4002922")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _deadPrefab;

		// Token: 0x04002923 RID: 10531
		[Token(Token = "0x4002923")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _explodeForceMult;

		// Token: 0x04002924 RID: 10532
		[Token(Token = "0x4002924")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector2 _speedRange;

		// Token: 0x04002925 RID: 10533
		[Token(Token = "0x4002925")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector2 _animSpeedMinMax;

		// Token: 0x04002926 RID: 10534
		[Token(Token = "0x4002926")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _acceleration;

		// Token: 0x04002927 RID: 10535
		[Token(Token = "0x4002927")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector2 _repathCooldown;

		// Token: 0x04002928 RID: 10536
		[Token(Token = "0x4002928")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Rotation rate in degrees per second")]
		[SerializeField]
		private float _rotateRate;

		// Token: 0x04002929 RID: 10537
		[Token(Token = "0x4002929")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _scaredRotateRate;

		// Token: 0x0400292A RID: 10538
		[Token(Token = "0x400292A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _animTurnSpeed;

		// Token: 0x0400292B RID: 10539
		[Token(Token = "0x400292B")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _animTurnMult;

		// Token: 0x0400292C RID: 10540
		[Token(Token = "0x400292C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Tooltip("When randomly re-pathing, this controls how many degrees yaw it will rotate by")]
		private Vector2 _rotateRange;

		// Token: 0x0400292D RID: 10541
		[Token(Token = "0x400292D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Range(0f, 90f)]
		private float _maxPitch;

		// Token: 0x0400292E RID: 10542
		[Token(Token = "0x400292E")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _scareDuration;

		// Token: 0x0400292F RID: 10543
		[Token(Token = "0x400292F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector2 _scareSpeedRange;

		// Token: 0x04002930 RID: 10544
		[Token(Token = "0x4002930")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _scaredAcceleration;

		// Token: 0x04002931 RID: 10545
		[Token(Token = "0x4002931")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Vector2 _sizeRange;

		// Token: 0x04002932 RID: 10546
		[Token(Token = "0x4002932")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _visualObject;

		// Token: 0x04002933 RID: 10547
		[Token(Token = "0x4002933")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("If non-zero, will hide visual object further than this distance from view location.")]
		[SerializeField]
		private float _maxVisibleDistance;

		// Token: 0x04002934 RID: 10548
		[Token(Token = "0x4002934")]
		[FieldOffset(Offset = "0xAC")]
		private float _repathTime;

		// Token: 0x04002935 RID: 10549
		[Token(Token = "0x4002935")]
		[FieldOffset(Offset = "0xB0")]
		private float _avoidRepathTime;

		// Token: 0x04002936 RID: 10550
		[Token(Token = "0x4002936")]
		[FieldOffset(Offset = "0xB4")]
		private float _lastScareTime;

		// Token: 0x04002937 RID: 10551
		[Token(Token = "0x4002937")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 _position;

		// Token: 0x04002938 RID: 10552
		[Token(Token = "0x4002938")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 _velocity;

		// Token: 0x04002939 RID: 10553
		[Token(Token = "0x4002939")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 _targetVelocity;

		// Token: 0x0400293A RID: 10554
		[Token(Token = "0x400293A")]
		[FieldOffset(Offset = "0xDC")]
		private float _targetSpeed;

		// Token: 0x0400293B RID: 10555
		[Token(Token = "0x400293B")]
		[FieldOffset(Offset = "0xE0")]
		private Quaternion _rotation;

		// Token: 0x0400293C RID: 10556
		[Token(Token = "0x400293C")]
		[FieldOffset(Offset = "0xF0")]
		private Quaternion _startRotation;

		// Token: 0x0400293D RID: 10557
		[Token(Token = "0x400293D")]
		[FieldOffset(Offset = "0x100")]
		private Quaternion _targetRotation;

		// Token: 0x0400293E RID: 10558
		[Token(Token = "0x400293E")]
		[FieldOffset(Offset = "0x110")]
		private SimpleAnimalZone _spawnZone;

		// Token: 0x0400293F RID: 10559
		[Token(Token = "0x400293F")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 _prefabScale;

		// Token: 0x04002940 RID: 10560
		[Token(Token = "0x4002940")]
		[FieldOffset(Offset = "0x124")]
		private float _updateSpeedTime;

		// Token: 0x04002941 RID: 10561
		[Token(Token = "0x4002941")]
		[FieldOffset(Offset = "0x128")]
		private float _rotationTime;

		// Token: 0x04002942 RID: 10562
		[Token(Token = "0x4002942")]
		[FieldOffset(Offset = "0x12C")]
		private float _rotationOneOverDuration;

		// Token: 0x04002943 RID: 10563
		[Token(Token = "0x4002943")]
		[FieldOffset(Offset = "0x130")]
		private bool _isVisible;

		// Token: 0x04002944 RID: 10564
		[Token(Token = "0x4002944")]
		[FieldOffset(Offset = "0x131")]
		private bool _isDead;

		// Token: 0x04002945 RID: 10565
		[Token(Token = "0x4002945")]
		[FieldOffset(Offset = "0x132")]
		private bool _hasAnimator;

		// Token: 0x04002946 RID: 10566
		[Token(Token = "0x4002946")]
		[FieldOffset(Offset = "0x133")]
		private bool _hasDirectionParam;

		// Token: 0x04002947 RID: 10567
		[Token(Token = "0x4002947")]
		[FieldOffset(Offset = "0x134")]
		private float _currentDirectionValue;

		// Token: 0x04002948 RID: 10568
		[Token(Token = "0x4002948")]
		[FieldOffset(Offset = "0x138")]
		private float _animVarTickDelta;

		// Token: 0x04002949 RID: 10569
		[Token(Token = "0x4002949")]
		[FieldOffset(Offset = "0x13C")]
		private int _tickOffset;

		// Token: 0x0400294A RID: 10570
		[Token(Token = "0x400294A")]
		[FieldOffset(Offset = "0x140")]
		private SimpleAnimal.MoveState _moveState;

		// Token: 0x0400294B RID: 10571
		[Token(Token = "0x400294B")]
		[FieldOffset(Offset = "0x148")]
		private Transform _transform;

		// Token: 0x02000706 RID: 1798
		[Token(Token = "0x2000706")]
		private enum MoveState
		{
			// Token: 0x0400294D RID: 10573
			[Token(Token = "0x400294D")]
			WanderInBounds,
			// Token: 0x0400294E RID: 10574
			[Token(Token = "0x400294E")]
			FollowPath
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[AddComponentMenu("Pathfinding/AI/RichAI (3D, for navmesh)")]
	public class RichAI : AIBase, IAstarAI
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000028C4 File Offset: 0x00000AC4
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700005E")]
		public bool traversingOffMeshLink
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x625BD0", Offset = "0x6241D0", VA = "0x180625BD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x625BE0", Offset = "0x6241E0", VA = "0x180625BE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x1700005F")]
		public float remainingDistance
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x625BF0", Offset = "0x6241F0", VA = "0x180625BF0", Slot = "53")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x17000060")]
		public bool reachedEndOfPath
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x625D10", Offset = "0x624310", VA = "0x180625D10", Slot = "55")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x17000061")]
		public bool reachedDestination
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x625D50", Offset = "0x624350", VA = "0x180625D50", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x17000062")]
		public bool hasPath
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x626040", Offset = "0x624640", VA = "0x180626040", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x17000063")]
		public bool pathPending
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x626070", Offset = "0x624670", VA = "0x180626070", Slot = "63")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002954 File Offset: 0x00000B54
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000064")]
		public Vector3 steeringTarget
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x626090", Offset = "0x624690", VA = "0x180626090", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x6260B0", Offset = "0x6246B0", VA = "0x1806260B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000296C File Offset: 0x00000B6C
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000065")]
		private float radius
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80", Slot = "42")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90", Slot = "43")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002984 File Offset: 0x00000B84
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000066")]
		private float height
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0", Slot = "44")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0", Slot = "45")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000299C File Offset: 0x00000B9C
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000067")]
		private float maxSpeed
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0", Slot = "49")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000029B4 File Offset: 0x00000BB4
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000068")]
		private bool canSearch
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x61BC60", Offset = "0x61A260", VA = "0x18061BC60", Slot = "58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x61BC90", Offset = "0x61A290", VA = "0x18061BC90", Slot = "59")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000029CC File Offset: 0x00000BCC
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000069")]
		private bool canMove
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0", Slot = "60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0", Slot = "61")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x1700006A")]
		public bool approachingPartEndpoint
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x6260D0", Offset = "0x6246D0", VA = "0x1806260D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x1700006B")]
		public bool approachingPathEndpoint
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x626130", Offset = "0x624730", VA = "0x180626130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x6261C0", Offset = "0x6247C0", VA = "0x1806261C0", Slot = "25")]
		public override void Teleport(Vector3 newPosition, bool clearPath = true)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x6264E0", Offset = "0x624AE0", VA = "0x1806264E0", Slot = "26")]
		protected override void OnDisable()
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x1700006C")]
		protected override bool shouldRecalculatePath
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x626540", Offset = "0x624B40", VA = "0x180626540", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x626600", Offset = "0x624C00", VA = "0x180626600", Slot = "32")]
		public override void SearchPath()
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x626760", Offset = "0x624D60", VA = "0x180626760", Slot = "34")]
		protected override void OnPathComplete(Path p)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x626AF0", Offset = "0x6250F0", VA = "0x180626AF0", Slot = "35")]
		protected override void ClearPath()
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x626B40", Offset = "0x625140", VA = "0x180626B40")]
		protected void NextPart()
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x626C80", Offset = "0x625280", VA = "0x180626C80", Slot = "69")]
		public void GetRemainingPath(List<Vector3> buffer, out bool stale)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "76")]
		protected virtual void OnTargetReached()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x626CD0", Offset = "0x6252D0", VA = "0x180626CD0", Slot = "77")]
		protected virtual Vector3 UpdateTarget(RichFunnel fn)
		{
			return default(Vector3);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x626E00", Offset = "0x625400", VA = "0x180626E00", Slot = "30")]
		protected override void MovementUpdateInternal(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x627230", Offset = "0x625830", VA = "0x180627230")]
		private void TraverseFunnel(RichFunnel fn, float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x627A90", Offset = "0x626090", VA = "0x180627A90")]
		private void FinalMovement(Vector3 position3D, float deltaTime, float distanceToEndOfPath, float slowdownFactor, out Vector3 nextPosition, out Quaternion nextRotation)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x627FE0", Offset = "0x6265E0", VA = "0x180627FE0", Slot = "39")]
		protected override Vector3 ClampToNavmesh(Vector3 position, out bool positionChanged)
		{
			return default(Vector3);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x628380", Offset = "0x626980", VA = "0x180628380")]
		private Vector2 CalculateWallForce(Vector2 position, float elevation, Vector2 directionToTarget)
		{
			return default(Vector2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x628990", Offset = "0x626F90", VA = "0x180628990", Slot = "78")]
		protected virtual IEnumerator TraverseSpecial(RichSpecial link)
		{
			return null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x628A90", Offset = "0x627090", VA = "0x180628A90")]
		protected IEnumerator TraverseOffMeshLinkFallback(RichSpecial link)
		{
			return null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x628B90", Offset = "0x627190", VA = "0x180628B90", Slot = "41")]
		protected override void OnDrawGizmos()
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x628E30", Offset = "0x627430", VA = "0x180628E30", Slot = "9")]
		protected override int OnUpgradeSerializedData(int version, bool unityThread)
		{
			return 0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x628F40", Offset = "0x627540", VA = "0x180628F40")]
		[Obsolete("Use SearchPath instead. [AstarUpgradable: 'UpdatePath' -> 'SearchPath']")]
		public void UpdatePath()
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x1700006D")]
		[Obsolete("Use velocity instead (lowercase 'v'). [AstarUpgradable: 'Velocity' -> 'velocity']")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x628F60", Offset = "0x627560", VA = "0x180628F60")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x1700006E")]
		[Obsolete("Use steeringTarget instead. [AstarUpgradable: 'NextWaypoint' -> 'steeringTarget']")]
		public Vector3 NextWaypoint
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x626090", Offset = "0x624690", VA = "0x180626090")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x1700006F")]
		[Obsolete("Use Vector3.Distance(transform.position, ai.steeringTarget) instead.")]
		public float DistanceToNextWaypoint
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x629030", Offset = "0x627630", VA = "0x180629030")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00002AD4 File Offset: 0x00000CD4
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000070")]
		[Obsolete("Use canSearch instead. [AstarUpgradable: 'repeatedlySearchPaths' -> 'canSearch']")]
		public bool repeatedlySearchPaths
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x61BC60", Offset = "0x61A260", VA = "0x18061BC60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x61BC90", Offset = "0x61A290", VA = "0x18061BC90")]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x17000071")]
		[Obsolete("When unifying the interfaces for different movement scripts, this property has been renamed to reachedEndOfPath (lowercase t).  [AstarUpgradable: 'TargetReached' -> 'reachedEndOfPath']")]
		public bool TargetReached
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x625D10", Offset = "0x624310", VA = "0x180625D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x17000072")]
		[Obsolete("Use pathPending instead (lowercase 'p'). [AstarUpgradable: 'PathPending' -> 'pathPending']")]
		public bool PathPending
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x626070", Offset = "0x624670", VA = "0x180626070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x17000073")]
		[Obsolete("Use approachingPartEndpoint (lowercase 'a') instead")]
		public bool ApproachingPartEndpoint
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x6260D0", Offset = "0x6246D0", VA = "0x1806260D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x17000074")]
		[Obsolete("Use approachingPathEndpoint (lowercase 'a') instead")]
		public bool ApproachingPathEndpoint
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x629040", Offset = "0x627640", VA = "0x180629040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x17000075")]
		[Obsolete("This property has been renamed to 'traversingOffMeshLink'. [AstarUpgradable: 'TraversingSpecial' -> 'traversingOffMeshLink']")]
		public bool TraversingSpecial
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x625BD0", Offset = "0x6241D0", VA = "0x180625BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x17000076")]
		[Obsolete("This property has been renamed to steeringTarget")]
		public Vector3 TargetPoint
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x626090", Offset = "0x624690", VA = "0x180626090")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000077")]
		[Obsolete("Use the onTraverseOffMeshLink event or the ... component instead. Setting this value will add a ... component")]
		public Animation anim
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x629050", Offset = "0x627650", VA = "0x180629050")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x629130", Offset = "0x627730", VA = "0x180629130")]
			set
			{
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x629360", Offset = "0x627960", VA = "0x180629360")]
		public RichAI()
		{
		}

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x130")]
		public float acceleration;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x134")]
		public float rotationSpeed;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x138")]
		public float slowdownTime;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x13C")]
		public float endReachedDistance;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x140")]
		public float wallForce;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x144")]
		public float wallDist;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x148")]
		public bool funnelSimplification;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x149")]
		public bool slowWhenNotFacingTarget;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x150")]
		public Func<RichSpecial, IEnumerator> onTraverseOffMeshLink;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x158")]
		protected readonly RichPath richPath;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x160")]
		protected bool delayUpdatePath;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x161")]
		protected bool lastCorner;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x164")]
		protected float distanceToSteeringTarget;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x168")]
		protected readonly List<Vector3> nextCorners;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x170")]
		protected readonly List<Vector3> wallBuffer;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly Color GizmoColorPath;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x188")]
		[FormerlySerializedAs("anim")]
		[SerializeField]
		[HideInInspector]
		private Animation animCompatibility;
	}
}

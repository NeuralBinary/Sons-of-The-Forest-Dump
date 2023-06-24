using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[AddComponentMenu("Pathfinding/AI/AIPath (2D,3D)")]
	public class AIPath : AIBase, IAstarAI
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x623630", Offset = "0x621C30", VA = "0x180623630", Slot = "25")]
		public override void Teleport(Vector3 newPosition, bool clearPath = true)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x1700003D")]
		public float remainingDistance
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x623660", Offset = "0x621C60", VA = "0x180623660", Slot = "53")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x1700003E")]
		public bool reachedDestination
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x623820", Offset = "0x621E20", VA = "0x180623820", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002744 File Offset: 0x00000944
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700003F")]
		public bool reachedEndOfPath
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x623AB0", Offset = "0x6220B0", VA = "0x180623AB0", Slot = "55")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x623AC0", Offset = "0x6220C0", VA = "0x180623AC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x17000040")]
		public bool hasPath
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x623AD0", Offset = "0x6220D0", VA = "0x180623AD0", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x17000041")]
		public bool pathPending
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x623B00", Offset = "0x622100", VA = "0x180623B00", Slot = "63")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x17000042")]
		public Vector3 steeringTarget
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x623B10", Offset = "0x622110", VA = "0x180623B10", Slot = "66")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000027A4 File Offset: 0x000009A4
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000043")]
		private float radius
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80", Slot = "42")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90", Slot = "43")]
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000027BC File Offset: 0x000009BC
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000044")]
		private float height
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0", Slot = "44")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0", Slot = "45")]
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000027D4 File Offset: 0x000009D4
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000045")]
		private float maxSpeed
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0", Slot = "49")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000027EC File Offset: 0x000009EC
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000046")]
		private bool canSearch
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x61BC60", Offset = "0x61A260", VA = "0x18061BC60", Slot = "58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x61BC90", Offset = "0x61A290", VA = "0x18061BC90", Slot = "59")]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002804 File Offset: 0x00000A04
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000047")]
		private bool canMove
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0", Slot = "60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0", Slot = "61")]
			set
			{
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x623BC0", Offset = "0x6221C0", VA = "0x180623BC0", Slot = "69")]
		public void GetRemainingPath(List<Vector3> buffer, out bool stale)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x623CF0", Offset = "0x6222F0", VA = "0x180623CF0", Slot = "26")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "76")]
		public virtual void OnTargetReached()
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x623DA0", Offset = "0x6223A0", VA = "0x180623DA0", Slot = "34")]
		protected override void OnPathComplete(Path newPath)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x6244D0", Offset = "0x622AD0", VA = "0x1806244D0", Slot = "35")]
		protected override void ClearPath()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x624580", Offset = "0x622B80", VA = "0x180624580", Slot = "30")]
		protected override void MovementUpdateInternal(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x624F60", Offset = "0x623560", VA = "0x180624F60", Slot = "77")]
		protected virtual void CalculateNextRotation(float slowdown, out Quaternion nextRotation)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x625280", Offset = "0x623880", VA = "0x180625280", Slot = "39")]
		protected override Vector3 ClampToNavmesh(Vector3 position, out bool positionChanged)
		{
			return default(Vector3);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x6256D0", Offset = "0x623CD0", VA = "0x1806256D0", Slot = "9")]
		protected override int OnUpgradeSerializedData(int version, bool unityThread)
		{
			return 0;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x17000048")]
		[Obsolete("When unifying the interfaces for different movement scripts, this property has been renamed to reachedEndOfPath.  [AstarUpgradable: 'TargetReached' -> 'reachedEndOfPath']")]
		public bool TargetReached
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x623AB0", Offset = "0x6220B0", VA = "0x180623AB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002864 File Offset: 0x00000A64
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000049")]
		[Obsolete("This field has been renamed to #rotationSpeed and is now in degrees per second instead of a damping factor")]
		public float turningSpeed
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x625700", Offset = "0x623D00", VA = "0x180625700")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x625720", Offset = "0x623D20", VA = "0x180625720")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000287C File Offset: 0x00000A7C
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700004A")]
		[Obsolete("This member has been deprecated. Use 'maxSpeed' instead. [AstarUpgradable: 'speed' -> 'maxSpeed']")]
		public float speed
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x1700004B")]
		[Obsolete("Only exists for compatibility reasons. Use desiredVelocity or steeringTarget instead.")]
		public Vector3 targetDirection
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x625740", Offset = "0x623D40", VA = "0x180625740")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x625900", Offset = "0x623F00", VA = "0x180625900")]
		[Obsolete("This method no longer calculates the velocity. Use the desiredVelocity property instead")]
		public Vector3 CalculateVelocity(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x6259F0", Offset = "0x623FF0", VA = "0x1806259F0")]
		public AIPath()
		{
		}

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x130")]
		public float maxAcceleration;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x134")]
		[FormerlySerializedAs("turningSpeed")]
		public float rotationSpeed;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x138")]
		public float slowdownDistance;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x13C")]
		public float pickNextWaypointDist;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x140")]
		public float endReachedDistance;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x144")]
		public bool alwaysDrawGizmos;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x145")]
		public bool slowWhenNotFacingTarget;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x148")]
		public CloseToDestinationMode whenCloseToDestination;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x14C")]
		public bool constrainInsideGraph;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x150")]
		protected Path path;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x158")]
		protected PathInterpolator interpolator;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x0")]
		private static NNConstraint cachedNNConstraint;
	}
}

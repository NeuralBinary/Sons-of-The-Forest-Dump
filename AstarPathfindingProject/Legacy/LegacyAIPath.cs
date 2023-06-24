using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Legacy
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_legacy_1_1_legacy_a_i_path.php")]
	[AddComponentMenu("Pathfinding/Legacy/AI/Legacy AIPath (3D)")]
	[RequireComponent(typeof(Seeker))]
	public class LegacyAIPath : AIPath
	{
		// Token: 0x060008C0 RID: 2240 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x6E78A0", Offset = "0x6E5EA0", VA = "0x1806E78A0", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x6E7A30", Offset = "0x6E6030", VA = "0x1806E7A30", Slot = "34")]
		protected override void OnPathComplete(Path _p)
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x6E81B0", Offset = "0x6E67B0", VA = "0x1806E81B0", Slot = "27")]
		protected override void Update()
		{
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00005E7C File Offset: 0x0000407C
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x6E8580", Offset = "0x6E6B80", VA = "0x1806E8580")]
		protected float XZSqrMagnitude(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00005E94 File Offset: 0x00004094
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x6E85B0", Offset = "0x6E6BB0", VA = "0x1806E85B0")]
		protected new Vector3 CalculateVelocity(Vector3 currentPosition)
		{
			return default(Vector3);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x6E8B00", Offset = "0x6E7100", VA = "0x1806E8B00")]
		protected void RotateTowards(Vector3 dir)
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00005EAC File Offset: 0x000040AC
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x6E8EA0", Offset = "0x6E74A0", VA = "0x1806E8EA0")]
		protected Vector3 CalculateTargetPoint(Vector3 p, Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x6E91F0", Offset = "0x6E77F0", VA = "0x1806E91F0")]
		public LegacyAIPath()
		{
		}

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x168")]
		public float forwardLook;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x16C")]
		public bool closestOnPathCheck;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x170")]
		protected float minMoveScale;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x174")]
		protected int currentWaypointIndex;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x178")]
		protected Vector3 lastFoundWaypointPosition;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x184")]
		protected float lastFoundWaypointTime;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x188")]
		protected new Vector3 targetDirection;
	}
}

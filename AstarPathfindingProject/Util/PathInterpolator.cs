using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	public class PathInterpolator
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x000063A4 File Offset: 0x000045A4
		[Token(Token = "0x17000148")]
		public virtual Vector3 position
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x70B5F0", Offset = "0x709BF0", VA = "0x18070B5F0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x000063BC File Offset: 0x000045BC
		[Token(Token = "0x17000149")]
		public Vector3 endPoint
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x70B760", Offset = "0x709D60", VA = "0x18070B760")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x000063D4 File Offset: 0x000045D4
		[Token(Token = "0x1700014A")]
		public Vector3 tangent
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x70B800", Offset = "0x709E00", VA = "0x18070B800")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x000063EC File Offset: 0x000045EC
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700014B")]
		public float remainingDistance
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x70B900", Offset = "0x709F00", VA = "0x18070B900")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x70B910", Offset = "0x709F10", VA = "0x18070B910")]
			set
			{
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00006404 File Offset: 0x00004604
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700014C")]
		public float distance
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x70B940", Offset = "0x709F40", VA = "0x18070B940")]
			set
			{
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0000641C File Offset: 0x0000461C
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700014D")]
		public int segmentIndex
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00006434 File Offset: 0x00004634
		[Token(Token = "0x1700014E")]
		public bool valid
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x70BA10", Offset = "0x70A010", VA = "0x18070BA10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x70BA20", Offset = "0x70A020", VA = "0x18070BA20")]
		public void GetRemainingPath(List<Vector3> buffer)
		{
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x70BC50", Offset = "0x70A250", VA = "0x18070BC50")]
		public void SetPath(List<Vector3> path)
		{
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x70BF90", Offset = "0x70A590", VA = "0x18070BF90")]
		public void MoveToSegment(int index, float fractionAlongSegment)
		{
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x70C0C0", Offset = "0x70A6C0", VA = "0x18070C0C0")]
		public void MoveToClosestPoint(Vector3 point)
		{
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x70C460", Offset = "0x70AA60", VA = "0x18070C460")]
		public void MoveToLocallyClosestPoint(Vector3 point, bool allowForwards = true, bool allowBackwards = true)
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x70CC80", Offset = "0x70B280", VA = "0x18070CC80")]
		public void MoveToCircleIntersection2D(Vector3 circleCenter3D, float radius, IMovementPlane transform)
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x70D1C0", Offset = "0x70B7C0", VA = "0x18070D1C0", Slot = "5")]
		protected virtual void PrevSegment()
		{
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x70D2E0", Offset = "0x70B8E0", VA = "0x18070D2E0", Slot = "6")]
		protected virtual void NextSegment()
		{
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x70D410", Offset = "0x70BA10", VA = "0x18070D410")]
		public PathInterpolator()
		{
		}

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x10")]
		private List<Vector3> path;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x18")]
		private float distanceToSegmentStart;

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x1C")]
		private float currentDistance;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0x20")]
		private float currentSegmentLength;

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x24")]
		private float totalDistance;
	}
}

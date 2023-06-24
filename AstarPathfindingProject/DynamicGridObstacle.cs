using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_dynamic_grid_obstacle.php")]
	public class DynamicGridObstacle : GraphModifier
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x170000EC")]
		private Bounds bounds
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x6764E0", Offset = "0x674AE0", VA = "0x1806764E0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x170000ED")]
		private bool colliderEnabled
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x6766F0", Offset = "0x674CF0", VA = "0x1806766F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x676850", Offset = "0x674E50", VA = "0x180676850", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x676CE0", Offset = "0x6752E0", VA = "0x180676CE0", Slot = "13")]
		public override void OnPostScan()
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x676E50", Offset = "0x675450", VA = "0x180676E50")]
		private void Update()
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x6776A0", Offset = "0x675CA0", VA = "0x1806776A0", Slot = "11")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x6778F0", Offset = "0x675EF0", VA = "0x1806778F0")]
		public void DoUpdateGraphs()
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x677FE0", Offset = "0x6765E0", VA = "0x180677FE0")]
		private static float BoundsVolume(Bounds b)
		{
			return 0f;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x678090", Offset = "0x676690", VA = "0x180678090")]
		public DynamicGridObstacle()
		{
		}

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x40")]
		private Collider coll;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x48")]
		private Collider2D coll2D;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x50")]
		private Transform tr;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x58")]
		public float updateError;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x5C")]
		public float checkTime;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x60")]
		private Bounds prevBounds;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion prevRotation;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x88")]
		private bool prevEnabled;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x8C")]
		private float lastCheckTime;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x90")]
		private Queue<GraphUpdateObject> pendingGraphUpdates;
	}
}

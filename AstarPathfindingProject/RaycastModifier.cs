using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	[RequireComponent(typeof(Seeker))]
	[AddComponentMenu("Pathfinding/Modifiers/Raycast Modifier")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_raycast_modifier.php")]
	[Serializable]
	public class RaycastModifier : MonoModifier
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0000599C File Offset: 0x00003B9C
		[Token(Token = "0x17000132")]
		public override int Order
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x6BC980", Offset = "0x6BAF80", VA = "0x1806BC980", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x6C47A0", Offset = "0x6C2DA0", VA = "0x1806C47A0", Slot = "17")]
		public override void Apply(Path p)
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x6C4E60", Offset = "0x6C3460", VA = "0x1806C4E60")]
		private List<Vector3> ApplyGreedy(Path p, List<Vector3> points, Func<GraphNode, bool> filter, NNConstraint nnConstraint)
		{
			return null;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x6C5560", Offset = "0x6C3B60", VA = "0x1806C5560")]
		private List<Vector3> ApplyDP(Path p, List<Vector3> points, Func<GraphNode, bool> filter, NNConstraint nnConstraint)
		{
			return null;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000059B4 File Offset: 0x00003BB4
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x6C60C0", Offset = "0x6C46C0", VA = "0x1806C60C0")]
		protected bool ValidateLine(GraphNode n1, GraphNode n2, Vector3 v1, Vector3 v2, Func<GraphNode, bool> filter, NNConstraint nnConstraint)
		{
			return default(bool);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x6C6BF0", Offset = "0x6C51F0", VA = "0x1806C6BF0")]
		public RaycastModifier()
		{
		}

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x30")]
		public bool useRaycasting;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x34")]
		public LayerMask mask;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Checks around the line between two points, not just the exact line.\nMake sure the ground is either too far below or is not inside the mask since otherwise the raycast might always hit the ground.")]
		public bool thickRaycast;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Distance from the ray which will be checked for colliders")]
		public float thickRaycastRadius;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Check for intersections with 2D colliders instead of 3D colliders.")]
		public bool use2DPhysics;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Offset from the original positions to perform the raycast.\nCan be useful to avoid the raycast intersecting the ground or similar things you do not want to it intersect")]
		public Vector3 raycastOffset;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Use raycasting on the graphs. Only currently works with GridGraph and NavmeshGraph and RecastGraph. This is a pro version feature.")]
		public bool useGraphRaycasting;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("When using the high quality mode the script will try harder to find a shorter path. This is significantly slower than the greedy low quality approach.")]
		public RaycastModifier.Quality quality;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] iterationsByQuality;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x8")]
		private static List<Vector3> buffer;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x10")]
		private static float[] DPCosts;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x18")]
		private static int[] DPParents;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x58")]
		private RaycastModifier.Filter cachedFilter;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x60")]
		private NNConstraint cachedNNConstraint;

		// Token: 0x020000D8 RID: 216
		[Token(Token = "0x20000D8")]
		public enum Quality
		{
			// Token: 0x04000520 RID: 1312
			[Token(Token = "0x4000520")]
			Low,
			// Token: 0x04000521 RID: 1313
			[Token(Token = "0x4000521")]
			Medium,
			// Token: 0x04000522 RID: 1314
			[Token(Token = "0x4000522")]
			High,
			// Token: 0x04000523 RID: 1315
			[Token(Token = "0x4000523")]
			Highest
		}

		// Token: 0x020000D9 RID: 217
		[Token(Token = "0x20000D9")]
		private class Filter
		{
			// Token: 0x060007AD RID: 1965 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x6C7250", Offset = "0x6C5850", VA = "0x1806C7250")]
			public Filter()
			{
			}

			// Token: 0x060007AE RID: 1966 RVA: 0x000059CC File Offset: 0x00003BCC
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x6C7300", Offset = "0x6C5900", VA = "0x1806C7300")]
			private bool CanTraverse(GraphNode node)
			{
				return default(bool);
			}

			// Token: 0x04000524 RID: 1316
			[Token(Token = "0x4000524")]
			[FieldOffset(Offset = "0x10")]
			public Path path;

			// Token: 0x04000525 RID: 1317
			[Token(Token = "0x4000525")]
			[FieldOffset(Offset = "0x18")]
			public readonly Func<GraphNode, bool> cachedDelegate;
		}
	}
}

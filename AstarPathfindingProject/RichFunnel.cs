using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class RichFunnel : RichPathPart
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x62B0C0", Offset = "0x6296C0", VA = "0x18062B0C0")]
		public RichFunnel()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x62B330", Offset = "0x629930", VA = "0x18062B330")]
		public RichFunnel Initialize(RichPath path, NavmeshBase graph)
		{
			return null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x62B4D0", Offset = "0x629AD0", VA = "0x18062B4D0", Slot = "5")]
		public override void OnEnterPool()
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		public TriangleMeshNode CurrentNode
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x62B5C0", Offset = "0x629BC0", VA = "0x18062B5C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x62B640", Offset = "0x629C40", VA = "0x18062B640")]
		public void BuildFunnelCorridor(List<GraphNode> nodes, int start, int end)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x62BDE0", Offset = "0x62A3E0", VA = "0x18062BDE0")]
		private void SimplifyPath(IRaycastableGraph graph, List<GraphNode> nodes, int start, int end, List<GraphNode> result, Vector3 startPoint, Vector3 endPoint)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x62D090", Offset = "0x62B690", VA = "0x18062D090")]
		private void UpdateFunnelCorridor(int splitIndex, List<TriangleMeshNode> prefix)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x62D4A0", Offset = "0x62BAA0", VA = "0x18062D4A0")]
		private bool CheckForDestroyedNodes()
		{
			return default(bool);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x17000080")]
		public float DistanceToEndOfPath
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x62D540", Offset = "0x62BB40", VA = "0x18062D540")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x62D670", Offset = "0x62BC70", VA = "0x18062D670")]
		public Vector3 ClampToNavmesh(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x62D890", Offset = "0x62BE90", VA = "0x18062D890")]
		public Vector3 Update(Vector3 position, List<Vector3> buffer, int numCorners, out bool lastCorner, out bool requiresRepath)
		{
			return default(Vector3);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x62DEA0", Offset = "0x62C4A0", VA = "0x18062DEA0")]
		private bool ClampToNavmeshInternal(ref Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x62E6A0", Offset = "0x62CCA0", VA = "0x18062E6A0")]
		public void FindWalls(List<Vector3> wallBuffer, float range)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x62E6E0", Offset = "0x62CCE0", VA = "0x18062E6E0")]
		private void FindWalls(int nodeIndex, List<Vector3> wallBuffer, Vector3 position, float range)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x62EF40", Offset = "0x62D540", VA = "0x18062EF40")]
		private bool FindNextCorners(Vector3 origin, int startIndex, List<Vector3> funnelPath, int numCorners, out bool lastCorner)
		{
			return default(bool);
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Vector3> left;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<Vector3> right;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x20")]
		private List<TriangleMeshNode> nodes;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 exactStart;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 exactEnd;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x40")]
		private NavmeshBase graph;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x48")]
		private int currentNode;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 currentPosition;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x58")]
		private int checkForDestroyedNodesCounter;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x60")]
		private RichPath path;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x68")]
		private int[] triBuffer;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x70")]
		public bool funnelSimplification;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x0")]
		private static Queue<TriangleMeshNode> navmeshClampQueue;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x8")]
		private static List<TriangleMeshNode> navmeshClampList;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<TriangleMeshNode, TriangleMeshNode> navmeshClampDict;
	}
}

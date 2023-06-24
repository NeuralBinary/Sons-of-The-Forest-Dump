using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public class NodeLink3Node : PointNode
	{
		// Token: 0x06000395 RID: 917 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x6649D0", Offset = "0x662FD0", VA = "0x1806649D0")]
		public NodeLink3Node(AstarPath active)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00003ECC File Offset: 0x000020CC
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x6649E0", Offset = "0x662FE0", VA = "0x1806649E0", Slot = "10")]
		public override bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return default(bool);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x664B20", Offset = "0x663120", VA = "0x180664B20")]
		public GraphNode GetOther(GraphNode a)
		{
			return null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x664C70", Offset = "0x663270", VA = "0x180664C70")]
		private GraphNode GetOtherInternal(GraphNode a)
		{
			return null;
		}

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x38")]
		public NodeLink3 link;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 portalA;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 portalB;
	}
}

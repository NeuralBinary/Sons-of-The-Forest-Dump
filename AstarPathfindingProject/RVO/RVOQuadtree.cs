using System;
using Il2CppDummyDll;
using Pathfinding.RVO.Sampled;
using UnityEngine;

namespace Pathfinding.RVO
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	public class RVOQuadtree
	{
		// Token: 0x06000AA2 RID: 2722 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x720700", Offset = "0x71ED00", VA = "0x180720700")]
		public void Clear()
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x720740", Offset = "0x71ED40", VA = "0x180720740")]
		public void SetBounds(Rect r)
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0000683C File Offset: 0x00004A3C
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x720750", Offset = "0x71ED50", VA = "0x180720750")]
		private int GetNodeIndex()
		{
			return 0;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x720A40", Offset = "0x71F040", VA = "0x180720A40")]
		public void Insert(Agent agent)
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x720EA0", Offset = "0x71F4A0", VA = "0x180720EA0")]
		public void CalculateSpeeds()
		{
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x720EE0", Offset = "0x71F4E0", VA = "0x180720EE0")]
		public void Query(Vector2 p, float speed, float timeHorizon, float agentRadius, Agent agent)
		{
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x721000", Offset = "0x71F600", VA = "0x180721000")]
		public void DebugDraw()
		{
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x721030", Offset = "0x71F630", VA = "0x180721030")]
		private void DebugDrawRec(int i, Rect r)
		{
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x7219A0", Offset = "0x71FFA0", VA = "0x1807219A0")]
		public RVOQuadtree()
		{
		}

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		private const int LeafSize = 15;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x10")]
		private float maxRadius;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x18")]
		private RVOQuadtree.Node[] nodes;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x20")]
		private int filledNodes;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x24")]
		private Rect bounds;

		// Token: 0x02000157 RID: 343
		[Token(Token = "0x2000157")]
		private struct Node
		{
			// Token: 0x06000AAB RID: 2731 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x721A40", Offset = "0x720040", VA = "0x180721A40")]
			public void Add(Agent agent)
			{
			}

			// Token: 0x06000AAC RID: 2732 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x721B20", Offset = "0x720120", VA = "0x180721B20")]
			public void Distribute(RVOQuadtree.Node[] nodes, Rect r)
			{
			}

			// Token: 0x06000AAD RID: 2733 RVA: 0x00006854 File Offset: 0x00004A54
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x721C30", Offset = "0x720230", VA = "0x180721C30")]
			public float CalculateMaxSpeed(RVOQuadtree.Node[] nodes, int index)
			{
				return 0f;
			}

			// Token: 0x04000769 RID: 1897
			[Token(Token = "0x4000769")]
			[FieldOffset(Offset = "0x0")]
			public int child00;

			// Token: 0x0400076A RID: 1898
			[Token(Token = "0x400076A")]
			[FieldOffset(Offset = "0x8")]
			public Agent linkedList;

			// Token: 0x0400076B RID: 1899
			[Token(Token = "0x400076B")]
			[FieldOffset(Offset = "0x10")]
			public byte count;

			// Token: 0x0400076C RID: 1900
			[Token(Token = "0x400076C")]
			[FieldOffset(Offset = "0x14")]
			public float maxSpeed;
		}

		// Token: 0x02000158 RID: 344
		[Token(Token = "0x2000158")]
		private struct QuadtreeQuery
		{
			// Token: 0x06000AAE RID: 2734 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x721E40", Offset = "0x720440", VA = "0x180721E40")]
			public void QueryRec(int i, Rect r)
			{
			}

			// Token: 0x0400076D RID: 1901
			[Token(Token = "0x400076D")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 p;

			// Token: 0x0400076E RID: 1902
			[Token(Token = "0x400076E")]
			[FieldOffset(Offset = "0x8")]
			public float speed;

			// Token: 0x0400076F RID: 1903
			[Token(Token = "0x400076F")]
			[FieldOffset(Offset = "0xC")]
			public float timeHorizon;

			// Token: 0x04000770 RID: 1904
			[Token(Token = "0x4000770")]
			[FieldOffset(Offset = "0x10")]
			public float agentRadius;

			// Token: 0x04000771 RID: 1905
			[Token(Token = "0x4000771")]
			[FieldOffset(Offset = "0x14")]
			public float maxRadius;

			// Token: 0x04000772 RID: 1906
			[Token(Token = "0x4000772")]
			[FieldOffset(Offset = "0x18")]
			public Agent agent;

			// Token: 0x04000773 RID: 1907
			[Token(Token = "0x4000773")]
			[FieldOffset(Offset = "0x20")]
			public RVOQuadtree.Node[] nodes;
		}
	}
}

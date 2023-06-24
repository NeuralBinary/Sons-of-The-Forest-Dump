using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	public static class PathUtilities
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x00005E04 File Offset: 0x00004004
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x6E4240", Offset = "0x6E2840", VA = "0x1806E4240")]
		public static bool IsPathPossible(GraphNode node1, GraphNode node2)
		{
			return default(bool);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00005E1C File Offset: 0x0000401C
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x6E42A0", Offset = "0x6E28A0", VA = "0x1806E42A0")]
		public static bool IsPathPossible(List<GraphNode> nodes)
		{
			return default(bool);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00005E34 File Offset: 0x00004034
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x6E43B0", Offset = "0x6E29B0", VA = "0x1806E43B0")]
		public static bool IsPathPossible(List<GraphNode> nodes, int tagMask)
		{
			return default(bool);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x6E45C0", Offset = "0x6E2BC0", VA = "0x1806E45C0")]
		public static List<GraphNode> GetReachableNodes(GraphNode seed, int tagMask = -1, [Optional] Func<GraphNode, bool> filter)
		{
			return null;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x6E49B0", Offset = "0x6E2FB0", VA = "0x1806E49B0")]
		public static List<GraphNode> BFS(GraphNode seed, int depth, int tagMask = -1, [Optional] Func<GraphNode, bool> filter)
		{
			return null;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x6E4F10", Offset = "0x6E3510", VA = "0x1806E4F10")]
		public static List<Vector3> GetSpiralPoints(int count, float clearance)
		{
			return null;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00005E4C File Offset: 0x0000404C
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x6E5350", Offset = "0x6E3950", VA = "0x1806E5350")]
		private static Vector3 InvoluteOfCircle(float a, float t)
		{
			return default(Vector3);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x6E53D0", Offset = "0x6E39D0", VA = "0x1806E53D0")]
		public static void GetPointsAroundPointWorld(Vector3 p, IRaycastableGraph g, List<Vector3> previousPoints, float radius, float clearanceRadius)
		{
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x6E5630", Offset = "0x6E3C30", VA = "0x1806E5630")]
		public static void GetPointsAroundPoint(Vector3 center, IRaycastableGraph g, List<Vector3> previousPoints, float radius, float clearanceRadius)
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x6E5DD0", Offset = "0x6E43D0", VA = "0x1806E5DD0")]
		public static List<Vector3> GetPointsOnNodes(List<GraphNode> nodes, int count, float clearanceRadius = 0f)
		{
			return null;
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Queue<GraphNode> BFSQueue;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<GraphNode, int> BFSMap;
	}
}

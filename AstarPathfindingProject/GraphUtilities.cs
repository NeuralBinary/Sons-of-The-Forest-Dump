using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public static class GraphUtilities
	{
		// Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x65B4B0", Offset = "0x659AB0", VA = "0x18065B4B0")]
		public static List<Vector3> GetContours(NavGraph graph)
		{
			return null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x65B6F0", Offset = "0x659CF0", VA = "0x18065B6F0")]
		public static void GetContours(INavmesh navmesh, Action<List<Int3>, bool> results)
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x65BAF0", Offset = "0x65A0F0", VA = "0x18065BAF0")]
		public static void GetContours(GridGraph grid, Action<Vector3[]> callback, float yMergeThreshold, [Optional] GridNodeBase[] nodes)
		{
		}
	}
}

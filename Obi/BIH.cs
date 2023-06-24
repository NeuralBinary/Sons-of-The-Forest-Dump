using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public class BIH
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x27D65D0", Offset = "0x27D4BD0", VA = "0x1827D65D0")]
		public static BIHNode[] Build(ref IBounded[] elements, int maxDepth = 10, float maxOverlap = 0.7f)
		{
			return null;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x27D6D10", Offset = "0x27D5310", VA = "0x1827D6D10")]
		public static int HoarePartition(IBounded[] elements, int start, int end, float pivot, ref BIHNode node, int axis)
		{
			return 0;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x27D71B0", Offset = "0x27D57B0", VA = "0x1827D71B0")]
		public static float DistanceToSurface(Triangle[] triangles, Vector3[] vertices, Vector3[] normals, in BIHNode node, in Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x27D75D0", Offset = "0x27D5BD0", VA = "0x1827D75D0")]
		public static float DistanceToSurface(BIHNode[] nodes, Triangle[] triangles, Vector3[] vertices, Vector3[] normals, in Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x27D7630", Offset = "0x27D5C30", VA = "0x1827D7630")]
		public static float DistanceToSurface(BIHNode[] nodes, Triangle[] triangles, Vector3[] vertices, Vector3[] normals, in BIHNode node, in Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BIH()
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x27D7A10", Offset = "0x27D6010", VA = "0x1827D7A10")]
		[CompilerGenerated]
		internal static float <DistanceToSurface>g__MinSignedDistance|4_0(float d1, float d2)
		{
			return 0f;
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public static class Polygon
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x000036EC File Offset: 0x000018EC
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x63D700", Offset = "0x63BD00", VA = "0x18063D700")]
		public static bool ContainsPointXZ(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
		{
			return default(bool);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003704 File Offset: 0x00001904
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x63D810", Offset = "0x63BE10", VA = "0x18063D810")]
		public static bool ContainsPointXZ(Int3 a, Int3 b, Int3 c, Int3 p)
		{
			return default(bool);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000371C File Offset: 0x0000191C
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x63D960", Offset = "0x63BF60", VA = "0x18063D960")]
		public static bool ContainsPoint(Int2 a, Int2 b, Int2 c, Int2 p)
		{
			return default(bool);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x63DA30", Offset = "0x63C030", VA = "0x18063DA30")]
		public static bool ContainsPoint(Vector2[] polyPoints, Vector2 p)
		{
			return default(bool);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x63DB10", Offset = "0x63C110", VA = "0x18063DB10")]
		public static bool ContainsPointXZ(Vector3[] polyPoints, Vector3 p)
		{
			return default(bool);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x63DC00", Offset = "0x63C200", VA = "0x18063DC00")]
		public static int SampleYCoordinateInTriangle(Int3 p1, Int3 p2, Int3 p3, Int3 p)
		{
			return 0;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x63DD70", Offset = "0x63C370", VA = "0x18063DD70")]
		public static Vector3[] ConvexHullXZ(Vector3[] points)
		{
			return null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000377C File Offset: 0x0000197C
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x63E0A0", Offset = "0x63C6A0", VA = "0x18063E0A0")]
		public static Vector2 ClosestPointOnTriangle(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			return default(Vector2);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x63E390", Offset = "0x63C990", VA = "0x18063E390")]
		public static Vector3 ClosestPointOnTriangleXZ(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
		{
			return default(Vector3);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x63E7A0", Offset = "0x63CDA0", VA = "0x18063E7A0")]
		public static Vector3 ClosestPointOnTriangle(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
		{
			return default(Vector3);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x63EC60", Offset = "0x63D260", VA = "0x18063EC60")]
		public static void CompressMesh(List<Int3> vertices, List<int> triangles, out Int3[] outVertices, out int[] outTriangles)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x63F2C0", Offset = "0x63D8C0", VA = "0x18063F2C0")]
		public static void TraceContours(Dictionary<int, int> outline, HashSet<int> hasInEdge, Action<List<int>, bool> results)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x63F5C0", Offset = "0x63DBC0", VA = "0x18063F5C0")]
		public static void Subdivide(List<Vector3> points, List<Vector3> result, int subSegments)
		{
		}

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Int3, int> cached_Int3_int_dict;
	}
}

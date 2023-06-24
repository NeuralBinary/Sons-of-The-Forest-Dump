using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Meshing
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public static class Converter
	{
		// Token: 0x0600025E RID: 606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x24C8FA0", Offset = "0x24C75A0", VA = "0x1824C8FA0")]
		public static Mesh ToMesh(Polygon polygon, IList<ITriangle> triangles)
		{
			return null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x24C9070", Offset = "0x24C7670", VA = "0x1824C9070")]
		public static Mesh ToMesh(Polygon polygon, ITriangle[] triangles)
		{
			return null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x24C92D0", Offset = "0x24C78D0", VA = "0x1824C92D0")]
		private static List<Otri>[] SetNeighbors(Mesh mesh, ITriangle[] triangles)
		{
			return null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x24C9F50", Offset = "0x24C8550", VA = "0x1824C9F50")]
		private static void SetSegments(Mesh mesh, Polygon polygon, List<Otri>[] vertexarray)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x24CAB60", Offset = "0x24C9160", VA = "0x1824CAB60")]
		public static DcelMesh ToDCEL(Mesh mesh)
		{
			return null;
		}
	}
}

using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Voronoi
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class DefaultVoronoiFactory : IVoronoiFactory
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void Initialize(int vertexCount, int edgeCount, int faceCount)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x24AAB70", Offset = "0x24A9170", VA = "0x1824AAB70", Slot = "6")]
		public TriangleNet.Topology.DCEL.Vertex CreateVertex(double x, double y)
		{
			return null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x24AABD0", Offset = "0x24A91D0", VA = "0x1824AABD0", Slot = "7")]
		public HalfEdge CreateHalfEdge(TriangleNet.Topology.DCEL.Vertex origin, Face face)
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x24AAC40", Offset = "0x24A9240", VA = "0x1824AAC40", Slot = "8")]
		public Face CreateFace(TriangleNet.Geometry.Vertex vertex)
		{
			return null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DefaultVoronoiFactory()
		{
		}
	}
}

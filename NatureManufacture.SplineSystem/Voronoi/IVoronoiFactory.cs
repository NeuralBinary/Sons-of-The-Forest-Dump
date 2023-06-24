using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Voronoi
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public interface IVoronoiFactory
	{
		// Token: 0x0600010A RID: 266
		[Token(Token = "0x600010A")]
		void Initialize(int vertexCount, int edgeCount, int faceCount);

		// Token: 0x0600010B RID: 267
		[Token(Token = "0x600010B")]
		void Reset();

		// Token: 0x0600010C RID: 268
		[Token(Token = "0x600010C")]
		TriangleNet.Topology.DCEL.Vertex CreateVertex(double x, double y);

		// Token: 0x0600010D RID: 269
		[Token(Token = "0x600010D")]
		HalfEdge CreateHalfEdge(TriangleNet.Topology.DCEL.Vertex origin, Face face);

		// Token: 0x0600010E RID: 270
		[Token(Token = "0x600010E")]
		Face CreateFace(TriangleNet.Geometry.Vertex vertex);
	}
}

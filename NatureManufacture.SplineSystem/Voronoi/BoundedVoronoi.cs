using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Voronoi
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public class BoundedVoronoi : VoronoiBase
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x24A9740", Offset = "0x24A7D40", VA = "0x1824A9740")]
		public BoundedVoronoi(Mesh mesh)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x24A97E0", Offset = "0x24A7DE0", VA = "0x1824A97E0")]
		public BoundedVoronoi(Mesh mesh, IVoronoiFactory factory, IPredicates predicates)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x24A98A0", Offset = "0x24A7EA0", VA = "0x1824A98A0")]
		private void PostProcess()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x24AA050", Offset = "0x24A8650", VA = "0x1824AA050")]
		private void HandleCase1(HalfEdge edge, TriangleNet.Geometry.Vertex v1, TriangleNet.Geometry.Vertex v2)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x24AA4C0", Offset = "0x24A8AC0", VA = "0x1824AA4C0")]
		private void HandleCase2(HalfEdge edge, TriangleNet.Geometry.Vertex v1, TriangleNet.Geometry.Vertex v2)
		{
		}

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x40")]
		private int offset;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Voronoi
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public abstract class VoronoiBase : DcelMesh
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x24AB1D0", Offset = "0x24A97D0", VA = "0x1824AB1D0")]
		protected VoronoiBase(Mesh mesh, IVoronoiFactory factory, IPredicates predicates, bool generate)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x24AB320", Offset = "0x24A9920", VA = "0x1824AB320")]
		protected void Generate(Mesh mesh)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x24ABB60", Offset = "0x24AA160", VA = "0x1824ABB60")]
		protected List<HalfEdge>[] ComputeVertices(Mesh mesh, TriangleNet.Topology.DCEL.Vertex[] vertices)
		{
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x24AC2F0", Offset = "0x24AA8F0", VA = "0x1824AC2F0")]
		protected void ComputeEdges(Mesh mesh, TriangleNet.Topology.DCEL.Vertex[] vertices, Face[] faces, List<HalfEdge>[] map)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x24AC950", Offset = "0x24AAF50", VA = "0x1824AC950", Slot = "6")]
		protected virtual void ConnectEdges(List<HalfEdge>[] map)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x24ACC90", Offset = "0x24AB290", VA = "0x1824ACC90", Slot = "5")]
		protected override IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x28")]
		protected IPredicates predicates;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x30")]
		protected IVoronoiFactory factory;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x38")]
		protected List<HalfEdge> rays;
	}
}

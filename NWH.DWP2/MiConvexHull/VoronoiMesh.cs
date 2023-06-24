using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public static class VoronoiMesh
	{
		// Token: 0x06000223 RID: 547 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000223")]
		public static VoronoiMesh<TVertex, TCell, TEdge> Create<TVertex, TCell, TEdge>(IList<TVertex> data) where TVertex : IVertex where TCell : TriangulationCell<TVertex, TCell>, new() where TEdge : VoronoiEdge<TVertex, TCell>, new()
		{
			return null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000224")]
		public static VoronoiMesh<TVertex, DefaultTriangulationCell<TVertex>, VoronoiEdge<TVertex, DefaultTriangulationCell<TVertex>>> Create<TVertex>(IList<TVertex> data) where TVertex : IVertex
		{
			return null;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2721E80", Offset = "0x2720480", VA = "0x182721E80")]
		public static VoronoiMesh<DefaultVertex, DefaultTriangulationCell<DefaultVertex>, VoronoiEdge<DefaultVertex, DefaultTriangulationCell<DefaultVertex>>> Create(IList<double[]> data)
		{
			return null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000226")]
		public static VoronoiMesh<TVertex, TCell, VoronoiEdge<TVertex, TCell>> Create<TVertex, TCell>(IList<TVertex> data) where TVertex : IVertex where TCell : TriangulationCell<TVertex, TCell>, new()
		{
			return null;
		}
	}
}

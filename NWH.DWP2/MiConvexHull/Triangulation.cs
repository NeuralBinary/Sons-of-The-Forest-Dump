using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	public static class Triangulation
	{
		// Token: 0x0600020A RID: 522 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600020A")]
		public static ITriangulation<TVertex, DefaultTriangulationCell<TVertex>> CreateDelaunay<TVertex>(IList<TVertex> data) where TVertex : IVertex
		{
			return null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2721840", Offset = "0x271FE40", VA = "0x182721840")]
		public static ITriangulation<DefaultVertex, DefaultTriangulationCell<DefaultVertex>> CreateDelaunay(IList<double[]> data)
		{
			return null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600020C")]
		public static ITriangulation<TVertex, TFace> CreateDelaunay<TVertex, TFace>(IList<TVertex> data) where TVertex : IVertex where TFace : TriangulationCell<TVertex, TFace>, new()
		{
			return null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600020D")]
		public static VoronoiMesh<TVertex, TCell, TEdge> CreateVoronoi<TVertex, TCell, TEdge>(IList<TVertex> data) where TVertex : IVertex where TCell : TriangulationCell<TVertex, TCell>, new() where TEdge : VoronoiEdge<TVertex, TCell>, new()
		{
			return null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600020E")]
		public static VoronoiMesh<TVertex, DefaultTriangulationCell<TVertex>, VoronoiEdge<TVertex, DefaultTriangulationCell<TVertex>>> CreateVoronoi<TVertex>(IList<TVertex> data) where TVertex : IVertex
		{
			return null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2721A30", Offset = "0x2720030", VA = "0x182721A30")]
		public static VoronoiMesh<DefaultVertex, DefaultTriangulationCell<DefaultVertex>, VoronoiEdge<DefaultVertex, DefaultTriangulationCell<DefaultVertex>>> CreateVoronoi(IList<double[]> data)
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000210")]
		public static VoronoiMesh<TVertex, TCell, VoronoiEdge<TVertex, TCell>> CreateVoronoi<TVertex, TCell>(IList<TVertex> data) where TVertex : IVertex where TCell : TriangulationCell<TVertex, TCell>, new()
		{
			return null;
		}
	}
}

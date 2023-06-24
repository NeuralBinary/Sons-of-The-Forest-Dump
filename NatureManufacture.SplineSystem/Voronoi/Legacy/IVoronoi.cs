using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Voronoi.Legacy
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public interface IVoronoi
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000126 RID: 294
		[Token(Token = "0x1700002B")]
		Point[] Points { [Token(Token = "0x6000126")] get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000127 RID: 295
		[Token(Token = "0x1700002C")]
		ICollection<VoronoiRegion> Regions { [Token(Token = "0x6000127")] get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000128 RID: 296
		[Token(Token = "0x1700002D")]
		IEnumerable<IEdge> Edges { [Token(Token = "0x6000128")] get; }
	}
}

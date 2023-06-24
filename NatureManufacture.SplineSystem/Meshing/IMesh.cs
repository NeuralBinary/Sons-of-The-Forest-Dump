using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public interface IMesh
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000270 RID: 624
		[Token(Token = "0x1700006D")]
		ICollection<Vertex> Vertices { [Token(Token = "0x6000270")] get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000271 RID: 625
		[Token(Token = "0x1700006E")]
		IEnumerable<Edge> Edges { [Token(Token = "0x6000271")] get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000272 RID: 626
		[Token(Token = "0x1700006F")]
		ICollection<SubSegment> Segments { [Token(Token = "0x6000272")] get; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000273 RID: 627
		[Token(Token = "0x17000070")]
		ICollection<Triangle> Triangles { [Token(Token = "0x6000273")] get; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000274 RID: 628
		[Token(Token = "0x17000071")]
		IList<Point> Holes { [Token(Token = "0x6000274")] get; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000275 RID: 629
		[Token(Token = "0x17000072")]
		Rectangle Bounds { [Token(Token = "0x6000275")] get; }

		// Token: 0x06000276 RID: 630
		[Token(Token = "0x6000276")]
		void Renumber();

		// Token: 0x06000277 RID: 631
		[Token(Token = "0x6000277")]
		void Refine(QualityOptions quality, bool delaunay);
	}
}

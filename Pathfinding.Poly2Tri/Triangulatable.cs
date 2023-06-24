using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public interface Triangulatable
	{
		// Token: 0x060000AE RID: 174
		[Token(Token = "0x60000AE")]
		void Prepare(TriangulationContext tcx);

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000AF RID: 175
		[Token(Token = "0x1700001A")]
		IList<TriangulationPoint> Points { [Token(Token = "0x60000AF")] get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B0 RID: 176
		[Token(Token = "0x1700001B")]
		IList<DelaunayTriangle> Triangles { [Token(Token = "0x60000B0")] get; }

		// Token: 0x060000B1 RID: 177
		[Token(Token = "0x60000B1")]
		void AddTriangle(DelaunayTriangle t);

		// Token: 0x060000B2 RID: 178
		[Token(Token = "0x60000B2")]
		void AddTriangles(IEnumerable<DelaunayTriangle> list);

		// Token: 0x060000B3 RID: 179
		[Token(Token = "0x60000B3")]
		void ClearTriangles();

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B4 RID: 180
		[Token(Token = "0x1700001C")]
		TriangulationMode TriangulationMode { [Token(Token = "0x60000B4")] get; }
	}
}

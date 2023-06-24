using System;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public interface ITriangle
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600036D RID: 877
		// (set) Token: 0x0600036E RID: 878
		[Token(Token = "0x1700009B")]
		int ID { [Token(Token = "0x600036D")] get; [Token(Token = "0x600036E")] set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600036F RID: 879
		// (set) Token: 0x06000370 RID: 880
		[Token(Token = "0x1700009C")]
		int Label { [Token(Token = "0x600036F")] get; [Token(Token = "0x6000370")] set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000371 RID: 881
		// (set) Token: 0x06000372 RID: 882
		[Token(Token = "0x1700009D")]
		double Area { [Token(Token = "0x6000371")] get; [Token(Token = "0x6000372")] set; }

		// Token: 0x06000373 RID: 883
		[Token(Token = "0x6000373")]
		Vertex GetVertex(int index);

		// Token: 0x06000374 RID: 884
		[Token(Token = "0x6000374")]
		int GetVertexID(int index);

		// Token: 0x06000375 RID: 885
		[Token(Token = "0x6000375")]
		ITriangle GetNeighbor(int index);

		// Token: 0x06000376 RID: 886
		[Token(Token = "0x6000376")]
		int GetNeighborID(int index);

		// Token: 0x06000377 RID: 887
		[Token(Token = "0x6000377")]
		ISegment GetSegment(int index);
	}
}

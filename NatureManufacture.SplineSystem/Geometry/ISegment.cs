using System;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public interface ISegment : IEdge
	{
		// Token: 0x0600036B RID: 875
		[Token(Token = "0x600036B")]
		Vertex GetVertex(int index);

		// Token: 0x0600036C RID: 876
		[Token(Token = "0x600036C")]
		ITriangle GetTriangle(int index);
	}
}

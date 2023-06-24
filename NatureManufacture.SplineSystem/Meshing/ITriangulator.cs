using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Meshing
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public interface ITriangulator
	{
		// Token: 0x0600027A RID: 634
		[Token(Token = "0x600027A")]
		IMesh Triangulate(IList<Vertex> points, Configuration config);
	}
}

using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Meshing
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public interface IConstraintMesher
	{
		// Token: 0x0600026E RID: 622
		[Token(Token = "0x600026E")]
		IMesh Triangulate(IPolygon polygon);

		// Token: 0x0600026F RID: 623
		[Token(Token = "0x600026F")]
		IMesh Triangulate(IPolygon polygon, ConstraintOptions options);
	}
}

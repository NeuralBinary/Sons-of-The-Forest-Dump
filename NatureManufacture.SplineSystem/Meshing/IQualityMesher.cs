using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Meshing
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public interface IQualityMesher
	{
		// Token: 0x06000278 RID: 632
		[Token(Token = "0x6000278")]
		IMesh Triangulate(IPolygon polygon, QualityOptions quality);

		// Token: 0x06000279 RID: 633
		[Token(Token = "0x6000279")]
		IMesh Triangulate(IPolygon polygon, ConstraintOptions options, QualityOptions quality);
	}
}

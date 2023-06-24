using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Meshing
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public class GenericMesher
	{
		// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x24CC170", Offset = "0x24CA770", VA = "0x1824CC170")]
		public GenericMesher()
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x24CC200", Offset = "0x24CA800", VA = "0x1824CC200")]
		public GenericMesher(ITriangulator triangulator)
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x24CC270", Offset = "0x24CA870", VA = "0x1824CC270")]
		public GenericMesher(Configuration config)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2195090", Offset = "0x2193690", VA = "0x182195090")]
		public GenericMesher(ITriangulator triangulator, Configuration config)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x24CC2D0", Offset = "0x24CA8D0", VA = "0x1824CC2D0")]
		public IMesh Triangulate(IList<Vertex> points)
		{
			return null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x24CC330", Offset = "0x24CA930", VA = "0x1824CC330")]
		public IMesh Triangulate(IPolygon polygon)
		{
			return null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x24CC350", Offset = "0x24CA950", VA = "0x1824CC350")]
		public IMesh Triangulate(IPolygon polygon, ConstraintOptions options)
		{
			return null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x24CC370", Offset = "0x24CA970", VA = "0x1824CC370")]
		public IMesh Triangulate(IPolygon polygon, QualityOptions quality)
		{
			return null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x24CC390", Offset = "0x24CA990", VA = "0x1824CC390")]
		public IMesh Triangulate(IPolygon polygon, ConstraintOptions options, QualityOptions quality)
		{
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x24CC570", Offset = "0x24CAB70", VA = "0x1824CC570")]
		public static IMesh StructuredMesh(double width, double height, int nx, int ny)
		{
			return null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x24CC6B0", Offset = "0x24CACB0", VA = "0x1824CC6B0")]
		public static IMesh StructuredMesh(Rectangle bounds, int nx, int ny)
		{
			return null;
		}

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x10")]
		private Configuration config;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x18")]
		private ITriangulator triangulator;
	}
}

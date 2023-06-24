using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Voronoi
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public class StandardVoronoi : VoronoiBase
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x24AACA0", Offset = "0x24A92A0", VA = "0x1824AACA0")]
		public StandardVoronoi(Mesh mesh)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x24AAD50", Offset = "0x24A9350", VA = "0x1824AAD50")]
		public StandardVoronoi(Mesh mesh, Rectangle box)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x24AAE00", Offset = "0x24A9400", VA = "0x1824AAE00")]
		public StandardVoronoi(Mesh mesh, Rectangle box, IVoronoiFactory factory, IPredicates predicates)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x24AAFA0", Offset = "0x24A95A0", VA = "0x1824AAFA0")]
		private void PostProcess(Rectangle box)
		{
		}
	}
}

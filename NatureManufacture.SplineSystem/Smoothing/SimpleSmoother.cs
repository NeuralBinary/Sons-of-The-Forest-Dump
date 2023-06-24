using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Meshing;
using TriangleNet.Topology.DCEL;
using TriangleNet.Voronoi;

namespace TriangleNet.Smoothing
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public class SimpleSmoother : ISmoother
	{
		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x24C2C90", Offset = "0x24C1290", VA = "0x1824C2C90")]
		public SimpleSmoother()
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x24C2CF0", Offset = "0x24C12F0", VA = "0x1824C2CF0")]
		public SimpleSmoother(IVoronoiFactory factory)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x24C3040", Offset = "0x24C1640", VA = "0x1824C3040")]
		public SimpleSmoother(IVoronoiFactory factory, Configuration config)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x24C3190", Offset = "0x24C1790", VA = "0x1824C3190", Slot = "4")]
		public void Smooth(IMesh mesh)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x24C31A0", Offset = "0x24C17A0", VA = "0x1824C31A0", Slot = "5")]
		public void Smooth(IMesh mesh, int limit)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x24C34B0", Offset = "0x24C1AB0", VA = "0x1824C34B0")]
		private void Step(Mesh mesh, IVoronoiFactory factory, IPredicates predicates)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x24C36C0", Offset = "0x24C1CC0", VA = "0x1824C36C0")]
		private void Centroid(Face face, out double x, out double y)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x24C37D0", Offset = "0x24C1DD0", VA = "0x1824C37D0")]
		private Polygon Rebuild(Mesh mesh)
		{
			return null;
		}

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x10")]
		private TrianglePool pool;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x18")]
		private Configuration config;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x20")]
		private IVoronoiFactory factory;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x28")]
		private ConstraintOptions options;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Logging;
using TriangleNet.Meshing.Data;
using TriangleNet.Topology;

namespace TriangleNet.Meshing
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	internal class QualityMesher
	{
		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x24CCFF0", Offset = "0x24CB5F0", VA = "0x1824CCFF0")]
		public QualityMesher(Mesh mesh, Configuration config)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x24CD560", Offset = "0x24CBB60", VA = "0x1824CD560")]
		public void Apply(QualityOptions quality, bool delaunay = false)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x24CD880", Offset = "0x24CBE80", VA = "0x1824CD880")]
		public void AddBadSubseg(BadSubseg badseg)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x24CD8E0", Offset = "0x24CBEE0", VA = "0x1824CD8E0")]
		public int CheckSeg4Encroach(ref Osub testsubseg)
		{
			return 0;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x24CDE80", Offset = "0x24CC480", VA = "0x1824CDE80")]
		public void TestTriangle(ref Otri testtri)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x24CE7D0", Offset = "0x24CCDD0", VA = "0x1824CE7D0")]
		private void TallyEncs()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x24CEA50", Offset = "0x24CD050", VA = "0x1824CEA50")]
		private void SplitEncSegs(bool triflaws)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x24CF9A0", Offset = "0x24CDFA0", VA = "0x1824CF9A0")]
		private void TallyFaces()
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x24CFBB0", Offset = "0x24CE1B0", VA = "0x1824CFBB0")]
		private void SplitTriangle(BadTriangle badtri)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x24D04E0", Offset = "0x24CEAE0", VA = "0x1824D04E0")]
		private void EnforceQuality()
		{
		}

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x10")]
		private IPredicates predicates;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x18")]
		private Queue<BadSubseg> badsubsegs;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x20")]
		private BadTriQueue queue;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x28")]
		private Mesh mesh;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x30")]
		private Behavior behavior;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x38")]
		private NewLocation newLocation;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x40")]
		private ILog<LogItem> logger;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x48")]
		private Triangle newvertex_tri;
	}
}
